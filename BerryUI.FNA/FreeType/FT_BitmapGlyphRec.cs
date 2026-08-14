using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_BitmapGlyphRec
{
    public unsafe FT_GlyphRec root;

    [NativeTypeName("FT_Int")]
    public int left;

    [NativeTypeName("FT_Int")]
    public int top;

    public FT_Bitmap bitmap;
}
