using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Glyph_Class
{
    [NativeTypeName("FT_Long")]
    public nint glyph_size;

    public unsafe FT_Glyph_Format glyph_format;

    [NativeTypeName("FT_Glyph_InitFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, FT_GlyphSlotRec*, int> glyph_init;

    [NativeTypeName("FT_Glyph_DoneFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, void> glyph_done;

    [NativeTypeName("FT_Glyph_CopyFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, FT_GlyphRec*, int> glyph_copy;

    [NativeTypeName("FT_Glyph_TransformFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, FT_Matrix*, FT_Vector*, void> glyph_transform;

    [NativeTypeName("FT_Glyph_GetBBoxFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, FT_BBox*, void> glyph_bbox;

    [NativeTypeName("FT_Glyph_PrepareFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec*, FT_GlyphSlotRec*, int> glyph_prepare;
}
