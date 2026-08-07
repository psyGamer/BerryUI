using BerryUI.Util;

namespace BerryUI.Render;

public enum CmdType : byte {
    Sprite,
}

public struct CmdSprite {
    public required Texture Texture;

    public required URect Source;
    public required URect Destination;

    public required Color Color;
}
