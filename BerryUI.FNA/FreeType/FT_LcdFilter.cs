using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_LcdFilter : uint
{
    NONE = 0,
    DEFAULT = 1,
    LIGHT = 2,
    LEGACY1 = 3,
    LEGACY = 16,
    MAX,
}
