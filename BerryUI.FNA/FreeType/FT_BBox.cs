namespace BerryUI.FNA.FreeType;

public partial struct FT_BBox
{
    [NativeTypeName("FT_Pos")]
    public nint xMin;

    [NativeTypeName("FT_Pos")]
    public nint yMin;

    [NativeTypeName("FT_Pos")]
    public nint xMax;

    [NativeTypeName("FT_Pos")]
    public nint yMax;
}
