namespace BerryUI.FNA.FreeType;

public partial struct FT_Matrix
{
    [NativeTypeName("FT_Fixed")]
    public nint xx;

    [NativeTypeName("FT_Fixed")]
    public nint xy;

    [NativeTypeName("FT_Fixed")]
    public nint yx;

    [NativeTypeName("FT_Fixed")]
    public nint yy;
}
