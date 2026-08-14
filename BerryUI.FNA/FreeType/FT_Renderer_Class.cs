using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Renderer_Class
{
    public unsafe FT_Module_Class root;

    public unsafe FT_Glyph_Format glyph_format;

    [NativeTypeName("FT_Renderer_RenderFunc")]
    public delegate* unmanaged[Cdecl]<FT_Renderer, FT_GlyphSlotRec*, FT_Render_Mode, FT_Vector*, int> render_glyph;

    [NativeTypeName("FT_Renderer_TransformFunc")]
    public delegate* unmanaged[Cdecl]<FT_Renderer, FT_GlyphSlotRec*, FT_Matrix*, FT_Vector*, int> transform_glyph;

    [NativeTypeName("FT_Renderer_GetCBoxFunc")]
    public delegate* unmanaged[Cdecl]<FT_Renderer, FT_GlyphSlotRec*, FT_BBox*, void> get_glyph_cbox;

    [NativeTypeName("FT_Renderer_SetModeFunc")]
    public delegate* unmanaged[Cdecl]<FT_Renderer, nuint, void*, int> set_mode;

    [NativeTypeName("const FT_Raster_Funcs *")]
    public unsafe FT_Raster_Funcs* raster_class;
}
