using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Size_Metrics
{
    [NativeTypeName("FT_UShort")]
    public ushort x_ppem;

    [NativeTypeName("FT_UShort")]
    public ushort y_ppem;

    [NativeTypeName("FT_Fixed")]
    public nint x_scale;

    [NativeTypeName("FT_Fixed")]
    public nint y_scale;

    [NativeTypeName("FT_Pos")]
    public long ascender;

    [NativeTypeName("FT_Pos")]
    public long descender;

    [NativeTypeName("FT_Pos")]
    public long height;

    [NativeTypeName("FT_Pos")]
    public long max_advance;
}
