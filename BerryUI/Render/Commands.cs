using BerryUI.Util;

namespace BerryUI.Render;

public enum CmdType : byte {
    Sprite,
    Text,
}

public struct CmdSprite {
    public required ResourceHandle<Texture> Texture;

    public required URect Source;
    public required URect Destination;

    public required Color Color;
}

public struct CmdText {
    public required ResourceHandle<FontFace> Font;
    public required string Text;

    public required UPoint Position;

    public required Color Color;
}
