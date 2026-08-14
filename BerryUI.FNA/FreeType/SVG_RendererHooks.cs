using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct SVG_RendererHooks
{
    [NativeTypeName("SVG_Lib_Init_Func")]
    public delegate* unmanaged[Cdecl]<void**, int> init_svg;

    [NativeTypeName("SVG_Lib_Free_Func")]
    public delegate* unmanaged[Cdecl]<void**, void> free_svg;

    [NativeTypeName("SVG_Lib_Render_Func")]
    public delegate* unmanaged[Cdecl]<FT_GlyphSlotRec*, void**, int> render_svg;

    [NativeTypeName("SVG_Lib_Preset_Slot_Func")]
    public delegate* unmanaged[Cdecl]<FT_GlyphSlotRec*, byte, void**, int> preset_slot;
}
