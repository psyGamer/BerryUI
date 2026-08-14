using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Bitmap_Size
{
    [NativeTypeName("FT_Short")]
    public short height;

    [NativeTypeName("FT_Short")]
    public short width;

    [NativeTypeName("FT_Pos")]
    public long size;

    [NativeTypeName("FT_Pos")]
    public long x_ppem;

    [NativeTypeName("FT_Pos")]
    public long y_ppem;
}
