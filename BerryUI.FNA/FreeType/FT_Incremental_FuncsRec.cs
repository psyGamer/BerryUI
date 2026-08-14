using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Incremental_FuncsRec
{
    [NativeTypeName("FT_Incremental_GetGlyphDataFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, uint, FT_Data*, int> get_glyph_data;

    [NativeTypeName("FT_Incremental_FreeGlyphDataFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, FT_Data*, void> free_glyph_data;

    [NativeTypeName("FT_Incremental_GetGlyphMetricsFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, uint, byte, FT_Incremental_MetricsRec*, int> get_glyph_metrics;
}
