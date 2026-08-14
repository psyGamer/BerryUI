using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_PaintTranslate
{
    public FT_OpaquePaint paint;

    [NativeTypeName("FT_Fixed")]
    public nint dx;

    [NativeTypeName("FT_Fixed")]
    public nint dy;
}
