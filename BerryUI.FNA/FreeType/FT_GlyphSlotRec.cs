using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_GlyphSlotRec
{
    public unsafe FT_Library library;

    public unsafe FT_Face face;

    [NativeTypeName("FT_GlyphSlot")]
    public unsafe FT_GlyphSlotRec* next;

    [NativeTypeName("FT_UInt")]
    public uint glyph_index;

    public FT_Generic generic;

    public unsafe FT_Glyph_Metrics metrics;

    [NativeTypeName("FT_Fixed")]
    public nint linearHoriAdvance;

    [NativeTypeName("FT_Fixed")]
    public nint linearVertAdvance;

    public FT_Vector advance;

    public unsafe FT_Glyph_Format format;

    public FT_Bitmap bitmap;

    [NativeTypeName("FT_Int")]
    public int bitmap_left;

    [NativeTypeName("FT_Int")]
    public int bitmap_top;

    public FT_Outline outline;

    [NativeTypeName("FT_UInt")]
    public uint num_subglyphs;

    public unsafe FT_SubGlyph subglyphs;

    public void* control_data;

    [NativeTypeName("long")]
    public nint control_len;

    [NativeTypeName("FT_Pos")]
    public long lsb_delta;

    [NativeTypeName("FT_Pos")]
    public long rsb_delta;

    public void* other;

    public unsafe FT_Slot_Internal @internal;
}
