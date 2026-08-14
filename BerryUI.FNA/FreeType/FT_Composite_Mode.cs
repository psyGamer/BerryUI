using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Composite_Mode : uint
{
    CLEAR = 0,
    SRC = 1,
    DEST = 2,
    SRC_OVER = 3,
    DEST_OVER = 4,
    SRC_IN = 5,
    DEST_IN = 6,
    SRC_OUT = 7,
    DEST_OUT = 8,
    SRC_ATOP = 9,
    DEST_ATOP = 10,
    XOR = 11,
    PLUS = 12,
    SCREEN = 13,
    OVERLAY = 14,
    DARKEN = 15,
    LIGHTEN = 16,
    COLOR_DODGE = 17,
    COLOR_BURN = 18,
    HARD_LIGHT = 19,
    SOFT_LIGHT = 20,
    DIFFERENCE = 21,
    EXCLUSION = 22,
    MULTIPLY = 23,
    HSL_HUE = 24,
    HSL_SATURATION = 25,
    HSL_COLOR = 26,
    HSL_LUMINOSITY = 27,
    MAX = 28,
}
