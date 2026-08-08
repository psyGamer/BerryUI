namespace BerryUI.FNA.FreeType;

public partial struct FT_Glyph_Metrics
{
    [NativeTypeName("FT_Pos")]
    public nint width;

    [NativeTypeName("FT_Pos")]
    public nint height;

    [NativeTypeName("FT_Pos")]
    public nint horiBearingX;

    [NativeTypeName("FT_Pos")]
    public nint horiBearingY;

    [NativeTypeName("FT_Pos")]
    public nint horiAdvance;

    [NativeTypeName("FT_Pos")]
    public nint vertBearingX;

    [NativeTypeName("FT_Pos")]
    public nint vertBearingY;

    [NativeTypeName("FT_Pos")]
    public nint vertAdvance;
}
