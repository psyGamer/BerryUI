namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
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
