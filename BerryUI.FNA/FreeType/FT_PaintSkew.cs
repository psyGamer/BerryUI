using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_PaintSkew
{
    public FT_OpaquePaint paint;

    [NativeTypeName("FT_Fixed")]
    public nint x_skew_angle;

    [NativeTypeName("FT_Fixed")]
    public nint y_skew_angle;

    [NativeTypeName("FT_Fixed")]
    public nint center_x;

    [NativeTypeName("FT_Fixed")]
    public nint center_y;
}
