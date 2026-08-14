using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Pixel_Mode : uint
{
    NONE = 0,
    MONO,
    GRAY,
    GRAY2,
    GRAY4,
    LCD,
    LCD_V,
    BGRA,
    MAX,
}
