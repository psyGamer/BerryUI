using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Glyph_Metrics
{
    [NativeTypeName("FT_Pos")]
    public long width;

    [NativeTypeName("FT_Pos")]
    public long height;

    [NativeTypeName("FT_Pos")]
    public long horiBearingX;

    [NativeTypeName("FT_Pos")]
    public long horiBearingY;

    [NativeTypeName("FT_Pos")]
    public long horiAdvance;

    [NativeTypeName("FT_Pos")]
    public long vertBearingX;

    [NativeTypeName("FT_Pos")]
    public long vertBearingY;

    [NativeTypeName("FT_Pos")]
    public long vertAdvance;
}
