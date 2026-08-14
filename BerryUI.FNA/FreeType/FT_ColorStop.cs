using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_ColorStop
{
    [NativeTypeName("FT_Fixed")]
    public nint stop_offset;

    public FT_ColorIndex color;
}
