using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_FaceRec
{
    [NativeTypeName("FT_Long")]
    public nint num_faces;

    [NativeTypeName("FT_Long")]
    public nint face_index;

    [NativeTypeName("FT_Long")]
    public nint face_flags;

    [NativeTypeName("FT_Long")]
    public nint style_flags;

    [NativeTypeName("FT_Long")]
    public nint num_glyphs;

    [NativeTypeName("FT_String *")]
    public sbyte* family_name;

    [NativeTypeName("FT_String *")]
    public sbyte* style_name;

    [NativeTypeName("FT_Int")]
    public int num_fixed_sizes;

    public FT_Bitmap_Size* available_sizes;

    [NativeTypeName("FT_Int")]
    public int num_charmaps;

    [NativeTypeName("FT_CharMap *")]
    public unsafe FT_CharMapRec** charmaps;

    public FT_Generic generic;

    public FT_BBox bbox;

    [NativeTypeName("FT_UShort")]
    public ushort units_per_EM;

    [NativeTypeName("FT_Short")]
    public short ascender;

    [NativeTypeName("FT_Short")]
    public short descender;

    [NativeTypeName("FT_Short")]
    public short height;

    [NativeTypeName("FT_Short")]
    public short max_advance_width;

    [NativeTypeName("FT_Short")]
    public short max_advance_height;

    [NativeTypeName("FT_Short")]
    public short underline_position;

    [NativeTypeName("FT_Short")]
    public short underline_thickness;

    [NativeTypeName("FT_GlyphSlot")]
    public unsafe FT_GlyphSlotRec* glyph;

    [NativeTypeName("FT_Size")]
    public unsafe FT_SizeRec* size;

    [NativeTypeName("FT_CharMap")]
    public unsafe FT_CharMapRec* charmap;

    public unsafe FT_Driver driver;

    public unsafe FT_Memory memory;

    [NativeTypeName("FT_Stream")]
    public unsafe FT_StreamRec* stream;

    public unsafe FT_ListRec sizes_list;

    public FT_Generic autohint;

    public void* extensions;

    public unsafe FT_Face_Internal @internal;
}
