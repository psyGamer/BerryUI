using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Stroker_LineJoin : uint
{
    ROUND = 0,
    BEVEL = 1,
    MITER_VARIABLE = 2,
    MITER = MITER_VARIABLE,
    MITER_FIXED = 3,
}
