using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_GlyphRec
{
    public unsafe FT_Library library;

    [NativeTypeName("const FT_Glyph_Class *")]
    public unsafe FT_Glyph_Class* clazz;

    public unsafe FT_Glyph_Format format;

    public FT_Vector advance;
}
