using BerryUI.Render;
using BerryUI.SourceGen;
using BerryUI.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BerryTexture = BerryUI.Render.Texture;
using BerryFont = BerryUI.Render.Font;
using BerryTextBlob = BerryUI.Render.TextBlob;
using BerryColor = BerryUI.Util.Color;
using FNAColor = Microsoft.Xna.Framework.Color;

namespace BerryUI.FNA;

internal static partial class FNARenderer {
    private enum RenderCmdType : byte { Sprite, Glyph }

    private struct RenderCmd {
        public required RenderCmdType Type;
        public required ResourceHandle<BerryTexture> Texture;

        // TODO: Use ushort
        public required URect Source;
        public required URect Destination;

        public required BerryColor Color;

        public required uint Depth;

        public bool Opaque => Type switch {
            RenderCmdType.Sprite => Color.A == 0xFF, // TODO: Check if texture can be transparent
            RenderCmdType.Glyph => false,
            _ => throw new UnreachableException()
        };
    }

    private struct Batch {
        public RenderCmdType Type;
        public ResourceHandle<BerryTexture> Texture;
        public List<int> Indices;
    }

    // All these collections are caching previous allocations
    private static readonly List<RenderCmd> renderCommandStorage = [];

    private static URect[] nodeRectStorage = [];
    private static RTree.NodeLeaves[] nodeLeavesStorage = [];
    private static readonly Stack<RTree.NodeIndex> nodeIndexStorage = [];

    private static int[] commandIndexStorage = [];
    private static int[] commandBatchIndexStorage = [];

    private const int MaxBatchSize = 16383;

    private static Batch[] batchStorage = [];

    private static short[] indexDataStorage = [];
    private static VertexPositionColorTexture[] vertexDataStorage = [];

    private static int vertexBufferOffset;
    private static bool supportsNoOverwrite;

    private static DynamicVertexBuffer vertexBuffer = null!;
    private static IndexBuffer indexBuffer = null!;

    private static Asset<Effect> spriteEffect = null!;
    private static Asset<Effect> glyphEffect = null!;
    private static Effect SpriteEffect => spriteEffect.Value;
    private static Effect GlyphEffect => glyphEffect.Value;

    public static void LoadContent(GraphicsDevice gd, AssetDirectory assets, bool noOverwrite) {
        const int quadCount = 1024;

        supportsNoOverwrite = noOverwrite;

        indexDataStorage = new short[quadCount * 6];
        vertexDataStorage = new VertexPositionColorTexture[quadCount * 4];

        for (int idx = 0, vtx = 0; idx < indexDataStorage.Length; idx += 6, vtx += 4) {
            indexDataStorage[idx + 0] = (short)(vtx + 0);
            indexDataStorage[idx + 1] = (short)(vtx + 1);
            indexDataStorage[idx + 2] = (short)(vtx + 2);

            indexDataStorage[idx + 3] = (short)(vtx + 3);
            indexDataStorage[idx + 4] = (short)(vtx + 2);
            indexDataStorage[idx + 5] = (short)(vtx + 1);
        }

        vertexBuffer = new DynamicVertexBuffer(gd, VertexPositionColorTexture.VertexDeclaration, vertexDataStorage.Length, BufferUsage.WriteOnly);
        indexBuffer = new DynamicIndexBuffer(gd, IndexElementSize.SixteenBits, indexDataStorage.Length, BufferUsage.WriteOnly);
        indexBuffer.SetData(indexDataStorage);

        spriteEffect = assets.Load("Effects/Sprite.fxb", stream => new Effect(gd, stream.ToByteArray()));
        glyphEffect = assets.Load("Effects/Glyph.fxb", stream => new Effect(gd, stream.ToByteArray()));
    }

    public static unsafe void Render(
        CommandEncoder enc,
        GraphicsDevice gd,
        RenderTarget2D screenTargetA,
        RenderTarget2D screenTargetB,
        bool screenNeedsClear,
        ResourcePool<BerryTexture, FNATexture> texturePool,
        ResourcePool<BerryFont, FNAFont> fontPool,
        ResourcePool<BerryTextBlob, FNATextBlob> textBlobPool
    ) {
        // Flush all pending glyphs to their atlas textures
        foreach (var font in fontPool) {
            font.StoreNew(texturePool);
        }

        // De-compose text commands into their individual glyphs
        renderCommandStorage.Clear();
        renderCommandStorage.EnsureCapacity(enc.Commands.Length);
        foreach (var cmd in enc.Commands) {
            switch (cmd.Active) {
                case CmdType.Sprite:
                    var sprite = cmd.Sprite;
                    renderCommandStorage.Add(new RenderCmd {
                        Type = RenderCmdType.Sprite,
                        Texture = sprite.Texture,
                        Source = sprite.Source,
                        Destination = sprite.Destination,
                        Color = sprite.Color,
                        Depth = sprite.Depth,
                    });
                    break;
                case CmdType.Text:
                    var text = cmd.Text;
                    var blob = textBlobPool[text.Blob];

                    renderCommandStorage.EnsureCapacity(blob.Entries.Length);
                    foreach (var entry in blob.Entries) {
                        if (!blob.Font.TryGetGlyph(entry.ID, out var glyph, out var atlas)) {
                            continue;
                        }

                        var glyphTexture = atlas.GetTexture(glyph.AtlasEntry);

                        renderCommandStorage.Add(new RenderCmd {
                            Type = RenderCmdType.Glyph,
                            Texture = glyphTexture.Handle,
                            Source = glyphTexture.Source,
                            Destination = new URect(
                                x: (uint)(text.Position.X + entry.Offset.X + glyph.Offset.X),
                                y: (uint)(text.Position.Y + entry.Offset.Y + glyph.Offset.Y),
                                w: glyphTexture.Source.Width,
                                h: glyphTexture.Source.Height),
                            Color = text.Color,
                            Depth = text.Depth,
                        });
                    }

                    break;

                default:
                    throw new UnreachableException();
            }
        }

        var renderCommands = CollectionsMarshal.AsSpan(renderCommandStorage);

        // Build an R-Tree from the bounding boxes
        var tree = RTree.BulkLoad(renderCommands, static cmd => cmd.Destination, ref nodeRectStorage, ref nodeLeavesStorage);

        // Sort commands by depth to ensure proper draw order
        CollectionUtils.EnsureArrayCapacityInvalidate(ref commandIndexStorage, renderCommands.Length);
        CollectionUtils.EnsureArrayCapacityInvalidate(ref commandBatchIndexStorage, renderCommands.Length);
        var commandIndices = commandIndexStorage.AsSpan(0, renderCommands.Length);
        var commandBatchIndices = commandBatchIndexStorage.AsSpan(0, renderCommands.Length);

        for (int i = 0; i < renderCommands.Length; i++) {
            commandIndices[i] = i;
        }

        commandIndices.SortWithContext(renderCommands, static (lhsIdx, rhsIdx, renderCommands) => renderCommands[lhsIdx].Depth < renderCommands[rhsIdx].Depth);

        // Construct batches based on depth-sorting constraints
        var batches = Span<Batch>.Empty;
        foreach (int cmdIdx in commandIndices) {
            var cmd = renderCommands[cmdIdx];

            int minBatchIdx = 0;
            if (!cmd.Opaque) {
                // Check for overlap with already placed commands
                switch (cmd.Type) {
                    case RenderCmdType.Sprite:
                        foreach (int overlapCmdIdx in tree.Query(cmd.Destination, nodeIndexStorage)) {
                            var overlapCmd = renderCommands[overlapCmdIdx];
                            if (overlapCmd.Depth > cmd.Depth) {
                                continue;
                            }

                            Debug.Assert(overlapCmd.Depth < cmd.Depth);

                            // For transparent sprites, we must at least be in the same draw call as the covered area
                            minBatchIdx = Math.Max(minBatchIdx, commandBatchIndices[overlapCmdIdx]);
                        }

                        break;

                    case RenderCmdType.Glyph:
                        foreach (int overlapCmdIdx in tree.Query(cmd.Destination, nodeIndexStorage)) {
                            var overlapCmd = renderCommands[overlapCmdIdx];
                            if (overlapCmd.Depth > cmd.Depth) {
                                continue;
                            }

                            Debug.Assert(overlapCmd.Depth < cmd.Depth);

                            // For overlapping glyphs, we cannot share one draw call and need another draw call above
                            minBatchIdx = Math.Max(minBatchIdx, commandBatchIndices[overlapCmdIdx] + 1);
                        }

                        break;

                    default:
                        throw new UnreachableException();
                }
            }

            // Search for the earliest possible batch
            for (int batchIdx = minBatchIdx; batchIdx < batches.Length; batchIdx++) {
                var batch = batches[batchIdx];
                if (batch.Type != cmd.Type || batch.Texture != cmd.Texture || batch.Indices.Count == MaxBatchSize) {
                    continue;
                }

                commandBatchIndices[cmdIdx] = batchIdx;
                batch.Indices.Add(cmdIdx);

                goto NextCmd;
            }

            // Start a new batch
            if (batches.Length == batchStorage.Length) {
                CollectionUtils.EnsureArrayCapacityKeep(ref batchStorage, batches.Length + 1);
                batches = batchStorage.AsSpan(0, batches.Length + 1);

                batches[^1] = new Batch {
                    Type = cmd.Type,
                    Texture = cmd.Texture,
                    Indices = [cmdIdx]
                };
            } else {
                batches = batchStorage.AsSpan(0, batches.Length + 1);
                ref var batch = ref batches[^1];

                batch.Type = cmd.Type;
                batch.Texture = cmd.Texture;
                batch.Indices.Clear();
                batch.Indices.Add(cmdIdx);
            }

            NextCmd: ;
        }

        uint maxBatchCommands = 0;
        foreach (var batch in batches) {
            maxBatchCommands = Math.Max(maxBatchCommands, (uint)batch.Indices.Count);
        }

        maxBatchCommands++; // Add one for the copy during buffer swapping

        // Render the collected batches
        int vertexLength = (int)(maxBatchCommands * 4);
        if (vertexLength > vertexDataStorage.Length) {
            CollectionUtils.EnsureArrayCapacityInvalidate(ref vertexDataStorage, vertexLength);

            vertexBuffer.Dispose();
            vertexBuffer = new DynamicVertexBuffer(gd, VertexPositionColorTexture.VertexDeclaration, vertexDataStorage.Length, BufferUsage.WriteOnly);
        }

        int indexLength = (int)(maxBatchCommands * 6);
        if (indexLength > indexDataStorage.Length) {
            int prevSize = indexDataStorage.Length;
            CollectionUtils.EnsureArrayCapacityKeep(ref indexDataStorage, indexLength);

            for (int idx = prevSize, vtx = prevSize / 3 * 2; idx < indexDataStorage.Length; idx += 6, vtx += 4) {
                indexDataStorage[idx + 0] = (short)(vtx + 0);
                indexDataStorage[idx + 1] = (short)(vtx + 1);
                indexDataStorage[idx + 2] = (short)(vtx + 2);

                indexDataStorage[idx + 3] = (short)(vtx + 3);
                indexDataStorage[idx + 4] = (short)(vtx + 2);
                indexDataStorage[idx + 5] = (short)(vtx + 1);
            }

            indexBuffer.Dispose();
            indexBuffer = new IndexBuffer(gd, IndexElementSize.SixteenBits, indexDataStorage.Length, BufferUsage.WriteOnly);
            indexBuffer.SetData(indexDataStorage);
        }

        RenderTarget2D currFront = screenTargetA, currBack = screenTargetB;
        bool swapped = false;

        var matrix = Matrix.CreateScale(2.0f / gd.Viewport.Width, 2.0f / gd.Viewport.Height, 1.0f) *
                     Matrix.CreateTranslation(-1.0f, -1.0f, 0.0f) *
                     Matrix.CreateScale(1.0f, -1.0f, 1.0f);

        SpriteEffect.Parameters["Matrix"].SetValue(matrix);
        GlyphEffect.Parameters["Matrix"].SetValue(matrix);

        gd.BlendState = BlendState.NonPremultiplied;
        gd.SamplerStates[0] = SamplerState.LinearClamp;
        gd.DepthStencilState = DepthStencilState.None;
        gd.RasterizerState = RasterizerState.CullCounterClockwise;

        gd.Indices = indexBuffer;
        gd.SetVertexBuffer(vertexBuffer);

        const float Gamma = 1.8f;

        // Convert user-colors from sRGB to linear
        SpriteEffect.Parameters["InputGamma"].SetValue(Gamma);
        GlyphEffect.Parameters["InputGamma"].SetValue(Gamma);

        for (int batchIdx = 0; batchIdx < batches.Length; batchIdx++) {
            var batch = batches[batchIdx];
            bool lastBatch = batchIdx == batches.Length - 1;

            var texture = texturePool[batch.Texture];
            var textureSize = new Vector2(texture.Texture.Width, texture.Texture.Height);

            int vertexIdx = 0;
            Effect effect;

            // Prepare batch
            switch (batch.Type) {
                case RenderCmdType.Sprite:
                    if (lastBatch) {
                        // Forward front to screen
                        WriteQuadData(vertexDataStorage, ref vertexIdx,
                            // This source rectangle is special-cased inside the effect
                            source: new URect(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue),
                            destination: new URect(0, 0, (uint)gd.Viewport.Width, (uint)gd.Viewport.Height),
                            BerryColor.White);

                        gd.SetRenderTarget(null);
                        if (screenNeedsClear) {
                            gd.Clear(FNAColor.Black);
                        }
                    } else if (batchIdx == 0) {
                        gd.SetRenderTarget(currFront);
                        gd.Clear(FNAColor.Transparent);
                    }

                    effect = spriteEffect.Value;
                    break;
                case RenderCmdType.Glyph:
                    if (batchIdx > 0) {
                        // Swap the front and back buffers
                        (currFront, currBack) = (currBack, currFront);
                        WriteQuadData(vertexDataStorage, ref vertexIdx,
                            // Source doesn't matter since its transparent anyway
                            source: URect.Empty,
                            destination: new URect(0, 0, (uint)gd.Viewport.Width, (uint)gd.Viewport.Height),
                            BerryColor.Transparent);
                    }

                    if (lastBatch) {
                        gd.SetRenderTarget(null);
                        if (screenNeedsClear) {
                            gd.Clear(FNAColor.Black);
                        }
                    } else if (batchIdx == 0) {
                        gd.SetRenderTarget(currFront);
                        gd.Clear(FNAColor.Transparent);
                    } else {
                        gd.SetRenderTarget(currFront);

                        if (!swapped) {
                            gd.Clear(FNAColor.Transparent);
                            swapped = true;
                        }
                    }

                    effect = glyphEffect.Value;
                    break;

                default:
                    throw new UnreachableException();
            }

            // Convert buffers from linear to sRGB when drawing to screen
            effect.Parameters["OutputGamma"].SetValue(lastBatch ? 1.0f / Gamma : 1.0f);

            // Generate vertex data
            foreach (int cmdIdx in batch.Indices) {
                var cmd = renderCommands[cmdIdx];
                WriteQuadData(vertexDataStorage, ref vertexIdx, cmd.Source, cmd.Destination, cmd.Color);
            }

            // Upload vertex buffer
            int vertexOffset;
            SetDataOptions uploadOptions;
            if (vertexBufferOffset + vertexIdx > vertexDataStorage.Length || !supportsNoOverwrite) {
                vertexOffset = 0;
                uploadOptions = SetDataOptions.Discard;
            } else {
                vertexOffset = vertexBufferOffset;
                uploadOptions = SetDataOptions.NoOverwrite;
            }

            fixed (VertexPositionColorTexture* vertexData = vertexDataStorage) {
                vertexBuffer.SetDataPointerEXT(
                    vertexOffset * VertexPositionColorTexture.VertexDeclaration.VertexStride,
                    (IntPtr)vertexData,
                    vertexIdx * VertexPositionColorTexture.VertexDeclaration.VertexStride,
                    uploadOptions
                );

                vertexBufferOffset = vertexOffset + vertexIdx;
            }

            // Draw
            effect.Parameters["TextureSize"].SetValue(textureSize);
            foreach (var pass in effect.CurrentTechnique.Passes) {
                pass.Apply();

                // Set this _after_ Apply, otherwise EffectParameters override it!
                gd.Textures[0] = texture.Texture;
                gd.Textures[1] = currBack;

                gd.DrawIndexedPrimitives(
                    PrimitiveType.TriangleList,
                    vertexOffset,
                    0,
                    vertexIdx,
                    0,
                    vertexIdx / 2
                );
            }
        }

        static void WriteQuadData(Span<VertexPositionColorTexture> vertices, ref int vertexIndex, URect source, URect destination, BerryColor color) {
            var tl = new VertexPositionColorTexture(destination.TopLeft.ToVector3(), color.ToFNA(), source.TopLeft.ToVector2());
            var tr = new VertexPositionColorTexture(destination.TopRight.ToVector3(), color.ToFNA(), source.TopRight.ToVector2());
            var bl = new VertexPositionColorTexture(destination.BottomLeft.ToVector3(), color.ToFNA(), source.BottomLeft.ToVector2());
            var br = new VertexPositionColorTexture(destination.BottomRight.ToVector3(), color.ToFNA(), source.BottomRight.ToVector2());

            vertices[vertexIndex++] = tl;
            vertices[vertexIndex++] = tr;
            vertices[vertexIndex++] = bl;
            vertices[vertexIndex++] = br;
        }
    }

    private readonly ref partial struct RTree(ReadOnlySpan<URect> rects, ReadOnlySpan<RTree.NodeLeaves> leaves) {
        private const uint NodeCapacity = 9;

        public enum NodeIndexKind : byte { Data = 0, Node = 1 }

        [Bitpacked(bitSize: 32)]
        public readonly partial struct NodeIndex {
            public const uint NoneIndex = (1u << 31) - 1;
            public static readonly NodeIndex None = new(NoneIndex, NodeIndexKind.Data);

            [BitfieldSize(bitSize: 31)] public partial uint Value { get; }
            [BitfieldSize(bitSize: 1)] public partial NodeIndexKind Kind { get; }
        }

        [InlineArray((int)NodeCapacity)]
        public struct NodeLeaves {
            public NodeIndex Index;
        }

        public readonly ReadOnlySpan<URect> Rects = rects;
        public readonly ReadOnlySpan<NodeLeaves> Leaves = leaves;

        /// Implementation of "STR: A Simple and Efficient Algorithm for R-Tree Packing".
        /// Reference paper: https://www.cs.odu.edu/~mln/ltrs-pdfs/icase-1997-14.pdf
        public static RTree BulkLoad<T>(ReadOnlySpan<T> data, Func<T, URect> rectProvider, ref URect[] nodeRectStorage, ref NodeLeaves[] nodeLeavesStorage) {
            uint totalNodeCount = 0;
            uint remaining = (uint)data.Length;
            while (remaining > 1) {
                uint nodeCount = (remaining - 1) / NodeCapacity + 1;

                totalNodeCount += nodeCount;
                remaining = nodeCount;
            }

            // Need to account for stored user data
            uint totalRectCount = (uint)(totalNodeCount + data.Length);

            CollectionUtils.EnsureArrayCapacityInvalidate(ref nodeRectStorage, (int)totalRectCount);
            CollectionUtils.EnsureArrayCapacityInvalidate(ref nodeLeavesStorage, (int)totalNodeCount);

            var nodeRects = nodeRectStorage.AsSpan(0, (int)totalRectCount);
            var nodeLeaves = nodeLeavesStorage.AsSpan(0, (int)totalNodeCount);

            Span<NodeIndex> leaves = stackalloc NodeIndex[data.Length];

            // Fill initial leaves with our data
            for (int i = 0; i < data.Length; i++) {
                nodeRects[(int)(totalNodeCount + i)] = rectProvider(data[i]);
                leaves[i] = new NodeIndex((uint)(totalNodeCount + i), NodeIndexKind.Data);
            }

            int writeIndex = 0;
            while (true) {
                int nodeCount = (int)PackLeaves(nodeRects, nodeLeaves, leaves, writeIndex);
                if (nodeCount == 1) {
                    // We've reached the root
                    Debug.Assert(writeIndex + nodeCount == totalNodeCount);
                    break;
                }

                // Populate generated nodes as leaves for next iteration
                leaves = leaves[..nodeCount];
                for (int i = 0; i < nodeCount; i++) {
                    leaves[i] = new NodeIndex((uint)writeIndex++, NodeIndexKind.Node);
                }
            }

            return new RTree(nodeRects, nodeLeaves);
        }

        private static uint PackLeaves(Span<URect> nodeRects, Span<NodeLeaves> nodeLeaves, Span<NodeIndex> leaves, int writeIndex) {
            uint nodeCount = (uint)(leaves.Length - 1) / NodeCapacity + 1;
            uint sliceCount = (uint)MathF.Sqrt(nodeCount);
            uint sliceSize = sliceCount * NodeCapacity;

            // Sort all entries based on their center x-coordinate
            leaves.SortWithContext(nodeRects, static (lhsIdx, rhsIdx, data) => {
                var lhs = data[(int)lhsIdx.Value];
                var rhs = data[(int)rhsIdx.Value];

                float lhsX = lhs.X + lhs.Width / 2.0f;
                float rhsX = rhs.X + rhs.Width / 2.0f;

                return lhsX < rhsX;
            });

            // Sort individual slices based on their center y-coordinate
            for (uint i = 0; i < sliceCount; i++) {
                int sliceStart = (int)(i * sliceSize);
                int sliceEnd = Math.Min(leaves.Length, (int)(sliceStart + sliceSize));

                var slice = leaves[sliceStart..sliceEnd];
                slice.SortWithContext(nodeRects, static (lhsIdx, rhsIdx, data) => {
                    var lhs = data[(int)lhsIdx.Value];
                    var rhs = data[(int)rhsIdx.Value];

                    float lhsY = lhs.Y + lhs.Height / 2.0f;
                    float rhsY = rhs.Y + rhs.Height / 2.0f;

                    return lhsY < rhsY;
                });
            }

            for (int nodeIdx = 0; nodeIdx < nodeCount; nodeIdx++) {
                int dataStart = (int)(nodeIdx * NodeCapacity);
                int dataEnd = Math.Min(leaves.Length, (int)(dataStart + NodeCapacity));

                var src = leaves[dataStart..dataEnd];

                var mbr = nodeRects[(int)src[0].Value];
                for (int i = 1; i < src.Length; i++) {
                    mbr = URect.Combine(mbr, nodeRects[(int)src[i].Value]);
                }

                nodeRects[writeIndex] = mbr;

                Span<NodeIndex> dst = nodeLeaves[writeIndex];
                dst.Fill(NodeIndex.None);
                src.CopyTo(dst);

                writeIndex++;
            }

            return nodeCount;
        }

        public QueryIterator Query(URect region, Stack<NodeIndex> indexStorage) => new(this, region, indexStorage);

        public ref struct QueryIterator(RTree tree, URect region, Stack<NodeIndex> indexStorage) {
            private readonly RTree tree = tree;

            public int Current { get; private set; }
            public QueryIterator GetEnumerator() => this;

            public bool MoveNext() {
                while (indexStorage.TryPop(out var currIdx)) {
                    if (currIdx.Kind == NodeIndexKind.Data) {
                        Current = (int)(currIdx.Value - tree.Leaves.Length);
                        return true;
                    }

                    indexStorage.EnsureCapacity((int)NodeCapacity);

                    ReadOnlySpan<NodeIndex> children = tree.Leaves[(int)currIdx.Value];
                    foreach (var childIdx in children) {
                        if (childIdx.Value == NodeIndex.NoneIndex) {
                            break;
                        }

                        if (URect.Intersects(region, tree.Rects[(int)childIdx.Value])) {
                            indexStorage.Push(childIdx);
                        }
                    }
                }

                return false;
            }
        }
    }
}
