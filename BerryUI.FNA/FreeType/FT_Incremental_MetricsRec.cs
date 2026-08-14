using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Incremental_MetricsRec
{
    [NativeTypeName("FT_Long")]
    public nint bearing_x;

    [NativeTypeName("FT_Long")]
    public nint bearing_y;

    [NativeTypeName("FT_Long")]
    public nint advance;

    [NativeTypeName("FT_Long")]
    public nint advance_v;
}
