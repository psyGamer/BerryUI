using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_SVG_DocumentRec
{
    [NativeTypeName("FT_Byte *")]
    public byte* svg_document;

    [NativeTypeName("FT_ULong")]
    public nuint svg_document_length;

    public unsafe FT_Size_Metrics metrics;

    [NativeTypeName("FT_UShort")]
    public ushort units_per_EM;

    [NativeTypeName("FT_UShort")]
    public ushort start_glyph_id;

    [NativeTypeName("FT_UShort")]
    public ushort end_glyph_id;

    public FT_Matrix transform;

    public FT_Vector delta;
}
