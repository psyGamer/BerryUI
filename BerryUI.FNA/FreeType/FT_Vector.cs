namespace BerryUI.FNA.FreeType;

public partial struct FT_Vector
{
    [NativeTypeName("FT_Pos")]
    public nint x;

    [NativeTypeName("FT_Pos")]
    public nint y;
}
