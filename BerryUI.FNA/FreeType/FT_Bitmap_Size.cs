namespace BerryUI.FNA.FreeType;

public partial struct FT_Bitmap_Size
{
    [NativeTypeName("FT_Short")]
    public short height;

    [NativeTypeName("FT_Short")]
    public short width;

    [NativeTypeName("FT_Pos")]
    public nint size;

    [NativeTypeName("FT_Pos")]
    public nint x_ppem;

    [NativeTypeName("FT_Pos")]
    public nint y_ppem;
}
