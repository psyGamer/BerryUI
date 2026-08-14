using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Orientation : uint
{
    TRUETYPE = 0,
    POSTSCRIPT = 1,
    FILL_RIGHT = TRUETYPE,
    FILL_LEFT = POSTSCRIPT,
    NONE,
}
