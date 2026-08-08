using BerryUI.Util;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BerryUI.Render;

public readonly struct CommandBuffer {
    public readonly Texture RenderTarget;

    private readonly List<CommandBuffer> dependencies = [];

    private readonly List<CmdType> types = [];
    private readonly List<CmdSprite> sprites = [];
    private readonly List<CmdText> texts = [];

    public ReadOnlyCollection<CommandBuffer> Dependencies => dependencies.AsReadOnly();

    public ReadOnlyCollection<CmdType> CommandTypes => types.AsReadOnly();
    public ReadOnlyCollection<CmdSprite> SpriteCommands => sprites.AsReadOnly();
    public ReadOnlyCollection<CmdText> TextCommands => texts.AsReadOnly();

    public CommandBuffer(Texture renderTarget) {
        RenderTarget = renderTarget;
    }

    public void Rect(URect rect, Color color) {
        Sprite(new CmdSprite {
            Texture = Texture.Pixel.Handle,
            Source = new URect(0, 0, 1, 1),
            Destination = rect,
            Color = color,
        });
    }

    public void Text(FontFace font, string text, UPoint position) {
        Text(new CmdText {
            Font = font.Handle,
            Text = text,
            Position = position,
            Color = Color.White,
        });
    }
    public void Text(FontFace font, string text, UPoint position, Color color) {
        Text(new CmdText {
            Font = font.Handle,
            Text = text,
            Position = position,
            Color = color,
        });
    }

    private void Sprite(CmdSprite sprite) {
        types.Add(CmdType.Sprite);
        sprites.Add(sprite);
    }
    private void Text(CmdText text) {
        types.Add(CmdType.Text);
        texts.Add(text);
    }

    public void Reset() {
        dependencies.Clear();
        types.Clear();
        sprites.Clear();
        texts.Clear();
    }
}
