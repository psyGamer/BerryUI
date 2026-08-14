using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Render_Mode : uint
{
    NORMAL = 0,
    LIGHT,
    MONO,
    LCD,
    LCD_V,
    SDF,
    MAX,
}
