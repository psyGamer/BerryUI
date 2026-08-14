using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_PaintScale
{
    public FT_OpaquePaint paint;

    [NativeTypeName("FT_Fixed")]
    public nint scale_x;

    [NativeTypeName("FT_Fixed")]
    public nint scale_y;

    [NativeTypeName("FT_Fixed")]
    public nint center_x;

    [NativeTypeName("FT_Fixed")]
    public nint center_y;
}
