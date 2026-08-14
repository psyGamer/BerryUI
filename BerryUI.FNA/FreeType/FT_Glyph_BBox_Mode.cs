using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Glyph_BBox_Mode : uint
{
    UNSCALED = 0,
    SUBPIXELS = 0,
    GRIDFIT = 1,
    TRUNCATE = 2,
    PIXELS = 3,
}
