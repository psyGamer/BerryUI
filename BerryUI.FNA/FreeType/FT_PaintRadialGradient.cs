using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_PaintRadialGradient
{
    public FT_ColorLine colorline;

    public FT_Vector c0;

    [NativeTypeName("FT_Pos")]
    public long r0;

    public FT_Vector c1;

    [NativeTypeName("FT_Pos")]
    public long r1;
}
