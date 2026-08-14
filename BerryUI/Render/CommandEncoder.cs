using BerryUI.SourceGen;
using BerryUI.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BerryUI.Render;

[Union(tagged: true, tagType: typeof(CmdType))]
public partial struct Cmd {
    [UnionField] public partial CmdSprite Sprite { get; set; }
    [UnionField] public partial CmdText Text { get; set; }

    public bool Opaque => Active switch {
        CmdType.Sprite => Sprite.Color.A == 0xFF, // TODO: Check if texture can be transparent
        CmdType.Text => false,
        _ => throw new UnreachableException()
    };

    public uint Depth => Active switch {
        CmdType.Sprite => Sprite.Depth,
        CmdType.Text => Text.Depth,
        _ => throw new UnreachableException()
    };

    public URect ContentRect => Active switch {
        CmdType.Sprite => Sprite.Destination,
        CmdType.Text => UI.Backend.GetTextBlob(Text.Blob).Bounds.WithPoint(Text.Position),
        _ => throw new UnreachableException()
    };
}

public enum CmdType : byte {
    Sprite,
    Text,
}

[StructLayout(LayoutKind.Auto)]
public struct CmdSprite {
    public required ResourceHandle<Texture> Texture;

    public required URect Source;
    public required URect Destination;

    public required Color Color;

    public required uint Depth;
}

[StructLayout(LayoutKind.Auto)]
public struct CmdText {
    public required ResourceHandle<TextBlob> Blob;

    public required UPoint Position;

    public required Color Color;

    public required uint Depth;
}

public sealed class CommandEncoder {
    public readonly Texture RenderTarget;

    public ReadOnlyCollection<CommandEncoder> Dependencies => dependencies.AsReadOnly();
    public ReadOnlySpan<Cmd> Commands => CollectionsMarshal.AsSpan(commands);

    public bool IsEmpty => commands.Count == 0;

    private readonly List<CommandEncoder> dependencies = [];
    private readonly List<Cmd> commands = [];

    // Cache the allocated "lists" between usages
    private int[] commandIndices = [];

    private uint depth;

    public uint Depth {
        // Shift widget depth to give each widget 2^10 = 1024 commands
        set => depth = value << 10;
    }

    public CommandEncoder(Texture renderTarget) {
        RenderTarget = renderTarget;
    }

    #region Commands

    public void Rect(URect rect, Color color) {
        Sprite(new CmdSprite {
            Texture = Texture.Pixel.Handle,
            Source = new URect(0, 0, 1, 1),
            Destination = rect,
            Color = color,
            Depth = depth++,
        });
    }

    public void Text(TextBlob text, UPoint position) {
        Text(new CmdText {
            Blob = text.Handle,
            Position = position,
            Color = Color.White,
            Depth = depth++,
        });
    }

    public void Text(TextBlob text, UPoint position, Color color) {
        Text(new CmdText {
            Blob = text.Handle,
            Position = position,
            Color = color,
            Depth = depth++,
        });
    }

    private void Sprite(CmdSprite sprite) {
        commands.Add(sprite);
    }

    private void Text(CmdText text) {
        commands.Add(text);
    }

    #endregion

    #region Sorting

    /// Re-orders all encoded commands to follow their render order.
    /// Should only be used for backends that cannot use a depth buffer.
    public ReadOnlySpan<int> SortDepth() {
        // Super-linear scaling by factor 1.5x
        if (commandIndices.Length < commands.Count) {
            commandIndices = new int[commands.Count + commands.Count / 2];
        }

        var commandIndicesSpan = commandIndices.AsSpan(0, commands.Count);
        Span<uint> commandDepths = stackalloc uint[commands.Count];

        for (int idx = 0; idx < commands.Count; idx++) {
            commandIndicesSpan[idx] = idx;
            commandDepths[idx] = commands[idx].Depth;
        }

        commandDepths.Sort(commandIndicesSpan);

        return commandIndicesSpan;
    }

    public delegate uint GroupHashDelegate(in Cmd cmd);

    private readonly ref struct SortGroupContext(
        ReadOnlySpan<uint> commandGroup,
        ReadOnlySpan<uint> commandDepth,
        ReadOnlySpan<bool> commandOpaque,
        ReadOnlySpan<URect> commandRect,
        Dictionary<uint, float> averageDepths
    ) {
        public readonly ReadOnlySpan<uint> CommandGroup = commandGroup;
        public readonly ReadOnlySpan<uint> CommandDepth = commandDepth;
        public readonly ReadOnlySpan<bool> CommandOpaque = commandOpaque;
        public readonly ReadOnlySpan<URect> CommandRect = commandRect;

        public readonly Dictionary<uint, float> AverageDepths = averageDepths;
    }

    /// Re-orders all encoded commands into groups.
    /// The <see cref="groupHashProvider"/> should provide the unique value for every command which should be grouped together.
    /// Attempts to move command with a high depth (visually in the front) towards the beginning of the list.
    /// Requires that the backend is using a depth buffer for rendering.
    public unsafe ReadOnlySpan<int> SortGroups(GroupHashDelegate groupHashProvider) {
        // Super-linear scaling by factor 1.5x
        if (commandIndices.Length < commands.Count) {
            commandIndices = new int[commands.Count + commands.Count / 2];
        }

        var commandIndicesSpan = commandIndices.AsSpan(0, commands.Count);
        var groupDepths = new Dictionary<uint, (uint Count, uint DepthSum)>();
        Span<uint> commandGroup = stackalloc uint[commands.Count];
        Span<uint> commandDepth = stackalloc uint[commands.Count];
        Span<bool> commandOpaque = stackalloc bool[commands.Count];
        Span<URect> commandRect = stackalloc URect[commands.Count];

        for (int idx = 0; idx < commands.Count; idx++) {
            commandIndicesSpan[idx] = idx;

            var cmd = commands[idx];
            commandGroup[idx] = groupHashProvider(cmd);
            commandDepth[idx] = cmd.Depth;
            commandOpaque[idx] = cmd.Opaque;
            commandRect[idx] = cmd.ContentRect;

            ref var entry = ref CollectionsMarshal.GetValueRefOrAddDefault(groupDepths, commandGroup[idx], out bool exists);
            if (exists) {
                entry.Count++;
                entry.DepthSum += commandDepth[idx];
            } else {
                entry = (Count: 1, DepthSum: commandDepth[idx]);
            }
        }

        var averageDepths = new Dictionary<uint, float>();
        averageDepths.EnsureCapacity(groupDepths.Count);
        foreach ((uint key, (uint count, uint depthSum)) in groupDepths) {
            averageDepths[key] = count / (float)depthSum;
        }

        commandIndicesSpan.SortWithContext(
            new SortGroupContext(commandGroup, commandDepth, commandOpaque, commandRect, averageDepths),
            static (lhsIdx, rhsIdx, ctx) => {
                if (!ctx.CommandOpaque[lhsIdx] || !ctx.CommandOpaque[rhsIdx]) {
                    // At least one of them is semi-transparent, respect actual depth if they overlap
                    var lhsRect = ctx.CommandRect[lhsIdx];
                    var rhsRect = ctx.CommandRect[rhsIdx];

                    if (URect.Intersects(lhsRect, rhsRect)) {
                        // Sort by real depth
                        return ctx.CommandDepth[lhsIdx] < ctx.CommandDepth[rhsIdx];
                    }
                }

                // Both are opaque / don't overlap, just try to group them
                uint lhsGroup = ctx.CommandGroup[lhsIdx];
                uint rhsGroup = ctx.CommandGroup[rhsIdx];

                float lhsDepth = ctx.AverageDepths[lhsGroup];
                float rhsDepth = ctx.AverageDepths[rhsGroup];

                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (lhsDepth != rhsDepth) {
                    return lhsDepth < rhsDepth;
                }

                return lhsGroup < rhsGroup;
            });

        return commandIndicesSpan;
    }

    #endregion

    /// Clears all recorded commands, allowing this encoder to be used again
    public void Reset() {
        dependencies.Clear();
        commands.Clear();
        depth = 0;
    }
}
