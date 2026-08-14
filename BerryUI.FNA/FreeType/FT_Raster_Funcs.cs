using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Raster_Funcs
{
    public unsafe FT_Glyph_Format glyph_format;

    [NativeTypeName("FT_Raster_NewFunc")]
    public delegate* unmanaged[Cdecl]<void*, FT_Raster*, int> raster_new;

    [NativeTypeName("FT_Raster_ResetFunc")]
    public delegate* unmanaged[Cdecl]<FT_Raster, byte*, nuint, void> raster_reset;

    [NativeTypeName("FT_Raster_SetModeFunc")]
    public delegate* unmanaged[Cdecl]<FT_Raster, nuint, void*, int> raster_set_mode;

    [NativeTypeName("FT_Raster_RenderFunc")]
    public delegate* unmanaged[Cdecl]<FT_Raster, FT_Raster_Params*, int> raster_render;

    [NativeTypeName("FT_Raster_DoneFunc")]
    public delegate* unmanaged[Cdecl]<FT_Raster, void> raster_done;
}
