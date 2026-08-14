using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_PaintSweepGradient
{
    public FT_ColorLine colorline;

    public FT_Vector center;

    [NativeTypeName("FT_Fixed")]
    public nint start_angle;

    [NativeTypeName("FT_Fixed")]
    public nint end_angle;
}
