using BerryUI.Util;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BerryUI.Render;

public readonly struct CommandBuffer {
    public readonly Texture RenderTarget;

    private readonly List<CommandBuffer> dependencies = [];

    private readonly List<CmdType> types = [];
    private readonly List<CmdSprite> sprites = [];

    public ReadOnlyCollection<CommandBuffer> Dependencies => dependencies.AsReadOnly();

    public ReadOnlyCollection<CmdType> CommandTypes => types.AsReadOnly();
    public ReadOnlyCollection<CmdSprite> SpriteCommands => sprites.AsReadOnly();

    public CommandBuffer(Texture renderTarget) {
        RenderTarget = renderTarget;
    }

    public void Rect(URect rect, Color color) {
        Sprite(new CmdSprite {
            Texture = Texture.Pixel,
            Source = new URect(0, 0, 1, 1),
            Destination = rect,
            Color = color,
        });
    }

    public void Sprite(CmdSprite sprite) {
        types.Add(CmdType.Sprite);
        sprites.Add(sprite);
    }

    public CommandBuffer SubTexture(Texture renderTarget) {
        var buffer = new CommandBuffer(renderTarget);
        dependencies.Add(buffer);
        return buffer;
    }

    public void Reset() {
        dependencies.Clear();
        types.Clear();
        sprites.Clear();
    }
}
