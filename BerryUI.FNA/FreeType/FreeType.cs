using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using static BerryUI.FNA.FreeType.T1_Blend_Flags;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public static unsafe partial class FreeType
{
    public const uint FT_Mod_Err_Base = 0;
    public const uint FT_Mod_Err_Autofit = 0;
    public const uint FT_Mod_Err_BDF = 0;
    public const uint FT_Mod_Err_Bzip2 = 0;
    public const uint FT_Mod_Err_Cache = 0;
    public const uint FT_Mod_Err_CFF = 0;
    public const uint FT_Mod_Err_CID = 0;
    public const uint FT_Mod_Err_Gzip = 0;
    public const uint FT_Mod_Err_LZW = 0;
    public const uint FT_Mod_Err_OTvalid = 0;
    public const uint FT_Mod_Err_PCF = 0;
    public const uint FT_Mod_Err_PFR = 0;
    public const uint FT_Mod_Err_PSaux = 0;
    public const uint FT_Mod_Err_PShinter = 0;
    public const uint FT_Mod_Err_PSnames = 0;
    public const uint FT_Mod_Err_Raster = 0;
    public const uint FT_Mod_Err_SFNT = 0;
    public const uint FT_Mod_Err_Smooth = 0;
    public const uint FT_Mod_Err_TrueType = 0;
    public const uint FT_Mod_Err_Type1 = 0;
    public const uint FT_Mod_Err_Type42 = 0;
    public const uint FT_Mod_Err_Winfonts = 0;
    public const uint FT_Mod_Err_GXvalid = 0;
    public const uint FT_Mod_Err_Sdf = 0;
    public const uint FT_Mod_Err_Max = 1;

    public const uint FT_Err_Ok = 0x00;
    public const uint FT_Err_Cannot_Open_Resource = 0x01 + 0;
    public const uint FT_Err_Unknown_File_Format = 0x02 + 0;
    public const uint FT_Err_Invalid_File_Format = 0x03 + 0;
    public const uint FT_Err_Invalid_Version = 0x04 + 0;
    public const uint FT_Err_Lower_Module_Version = 0x05 + 0;
    public const uint FT_Err_Invalid_Argument = 0x06 + 0;
    public const uint FT_Err_Unimplemented_Feature = 0x07 + 0;
    public const uint FT_Err_Invalid_Table = 0x08 + 0;
    public const uint FT_Err_Invalid_Offset = 0x09 + 0;
    public const uint FT_Err_Array_Too_Large = 0x0A + 0;
    public const uint FT_Err_Missing_Module = 0x0B + 0;
    public const uint FT_Err_Missing_Property = 0x0C + 0;
    public const uint FT_Err_Invalid_Glyph_Index = 0x10 + 0;
    public const uint FT_Err_Invalid_Character_Code = 0x11 + 0;
    public const uint FT_Err_Invalid_Glyph_Format = 0x12 + 0;
    public const uint FT_Err_Cannot_Render_Glyph = 0x13 + 0;
    public const uint FT_Err_Invalid_Outline = 0x14 + 0;
    public const uint FT_Err_Invalid_Composite = 0x15 + 0;
    public const uint FT_Err_Too_Many_Hints = 0x16 + 0;
    public const uint FT_Err_Invalid_Pixel_Size = 0x17 + 0;
    public const uint FT_Err_Invalid_SVG_Document = 0x18 + 0;
    public const uint FT_Err_Invalid_Handle = 0x20 + 0;
    public const uint FT_Err_Invalid_Library_Handle = 0x21 + 0;
    public const uint FT_Err_Invalid_Driver_Handle = 0x22 + 0;
    public const uint FT_Err_Invalid_Face_Handle = 0x23 + 0;
    public const uint FT_Err_Invalid_Size_Handle = 0x24 + 0;
    public const uint FT_Err_Invalid_Slot_Handle = 0x25 + 0;
    public const uint FT_Err_Invalid_CharMap_Handle = 0x26 + 0;
    public const uint FT_Err_Invalid_Cache_Handle = 0x27 + 0;
    public const uint FT_Err_Invalid_Stream_Handle = 0x28 + 0;
    public const uint FT_Err_Too_Many_Drivers = 0x30 + 0;
    public const uint FT_Err_Too_Many_Extensions = 0x31 + 0;
    public const uint FT_Err_Out_Of_Memory = 0x40 + 0;
    public const uint FT_Err_Unlisted_Object = 0x41 + 0;
    public const uint FT_Err_Cannot_Open_Stream = 0x51 + 0;
    public const uint FT_Err_Invalid_Stream_Seek = 0x52 + 0;
    public const uint FT_Err_Invalid_Stream_Skip = 0x53 + 0;
    public const uint FT_Err_Invalid_Stream_Read = 0x54 + 0;
    public const uint FT_Err_Invalid_Stream_Operation = 0x55 + 0;
    public const uint FT_Err_Invalid_Frame_Operation = 0x56 + 0;
    public const uint FT_Err_Nested_Frame_Access = 0x57 + 0;
    public const uint FT_Err_Invalid_Frame_Read = 0x58 + 0;
    public const uint FT_Err_Raster_Uninitialized = 0x60 + 0;
    public const uint FT_Err_Raster_Corrupted = 0x61 + 0;
    public const uint FT_Err_Raster_Overflow = 0x62 + 0;
    public const uint FT_Err_Raster_Negative_Height = 0x63 + 0;
    public const uint FT_Err_Too_Many_Caches = 0x70 + 0;
    public const uint FT_Err_Invalid_Opcode = 0x80 + 0;
    public const uint FT_Err_Too_Few_Arguments = 0x81 + 0;
    public const uint FT_Err_Stack_Overflow = 0x82 + 0;
    public const uint FT_Err_Code_Overflow = 0x83 + 0;
    public const uint FT_Err_Bad_Argument = 0x84 + 0;
    public const uint FT_Err_Divide_By_Zero = 0x85 + 0;
    public const uint FT_Err_Invalid_Reference = 0x86 + 0;
    public const uint FT_Err_Debug_OpCode = 0x87 + 0;
    public const uint FT_Err_ENDF_In_Exec_Stream = 0x88 + 0;
    public const uint FT_Err_Nested_DEFS = 0x89 + 0;
    public const uint FT_Err_Invalid_CodeRange = 0x8A + 0;
    public const uint FT_Err_Execution_Too_Long = 0x8B + 0;
    public const uint FT_Err_Too_Many_Function_Defs = 0x8C + 0;
    public const uint FT_Err_Too_Many_Instruction_Defs = 0x8D + 0;
    public const uint FT_Err_Table_Missing = 0x8E + 0;
    public const uint FT_Err_Horiz_Header_Missing = 0x8F + 0;
    public const uint FT_Err_Locations_Missing = 0x90 + 0;
    public const uint FT_Err_Name_Table_Missing = 0x91 + 0;
    public const uint FT_Err_CMap_Table_Missing = 0x92 + 0;
    public const uint FT_Err_Hmtx_Table_Missing = 0x93 + 0;
    public const uint FT_Err_Post_Table_Missing = 0x94 + 0;
    public const uint FT_Err_Invalid_Horiz_Metrics = 0x95 + 0;
    public const uint FT_Err_Invalid_CharMap_Format = 0x96 + 0;
    public const uint FT_Err_Invalid_PPem = 0x97 + 0;
    public const uint FT_Err_Invalid_Vert_Metrics = 0x98 + 0;
    public const uint FT_Err_Could_Not_Find_Context = 0x99 + 0;
    public const uint FT_Err_Invalid_Post_Table_Format = 0x9A + 0;
    public const uint FT_Err_Invalid_Post_Table = 0x9B + 0;
    public const uint FT_Err_DEF_In_Glyf_Bytecode = 0x9C + 0;
    public const uint FT_Err_Missing_Bitmap = 0x9D + 0;
    public const uint FT_Err_Missing_SVG_Hooks = 0x9E + 0;
    public const uint FT_Err_Syntax_Error = 0xA0 + 0;
    public const uint FT_Err_Stack_Underflow = 0xA1 + 0;
    public const uint FT_Err_Ignore = 0xA2 + 0;
    public const uint FT_Err_No_Unicode_Glyph_Name = 0xA3 + 0;
    public const uint FT_Err_Glyph_Too_Big = 0xA4 + 0;
    public const uint FT_Err_Missing_Startfont_Field = 0xB0 + 0;
    public const uint FT_Err_Missing_Font_Field = 0xB1 + 0;
    public const uint FT_Err_Missing_Size_Field = 0xB2 + 0;
    public const uint FT_Err_Missing_Fontboundingbox_Field = 0xB3 + 0;
    public const uint FT_Err_Missing_Chars_Field = 0xB4 + 0;
    public const uint FT_Err_Missing_Startchar_Field = 0xB5 + 0;
    public const uint FT_Err_Missing_Encoding_Field = 0xB6 + 0;
    public const uint FT_Err_Missing_Bbx_Field = 0xB7 + 0;
    public const uint FT_Err_Bbx_Too_Big = 0xB8 + 0;
    public const uint FT_Err_Corrupted_Font_Header = 0xB9 + 0;
    public const uint FT_Err_Corrupted_Font_Glyphs = 0xBA + 0;
    public const uint FT_Err_Max = 187;

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Error_String([NativeTypeName("FT_Error")] int error_code);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Init_FreeType(FT_Library* alibrary);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Done_FreeType(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_New_Face(FT_Library library, [NativeTypeName("const char *")] sbyte* filepathname, [NativeTypeName("FT_Long")] nint face_index, FT_Face* aface);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_New_Memory_Face(FT_Library library, [NativeTypeName("const FT_Byte *")] byte* file_base, [NativeTypeName("FT_Long")] nint file_size, [NativeTypeName("FT_Long")] nint face_index, FT_Face* aface);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Open_Face(FT_Library library, [NativeTypeName("const FT_Open_Args *")] FT_Open_Args* args, [NativeTypeName("FT_Long")] nint face_index, FT_Face* aface);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Attach_File(FT_Face face, [NativeTypeName("const char *")] sbyte* filepathname);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Attach_Stream(FT_Face face, [NativeTypeName("const FT_Open_Args *")] FT_Open_Args* parameters);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Reference_Face(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Done_Face(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Select_Size(FT_Face face, [NativeTypeName("FT_Int")] int strike_index);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Request_Size(FT_Face face, [NativeTypeName("FT_Size_Request")] FT_Size_RequestRec* req);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Char_Size(FT_Face face, [NativeTypeName("FT_F26Dot6")] long char_width, [NativeTypeName("FT_F26Dot6")] long char_height, [NativeTypeName("FT_UInt")] uint horz_resolution, [NativeTypeName("FT_UInt")] uint vert_resolution);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Pixel_Sizes(FT_Face face, [NativeTypeName("FT_UInt")] uint pixel_width, [NativeTypeName("FT_UInt")] uint pixel_height);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Load_Glyph(FT_Face face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_Int32")] int load_flags);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Load_Char(FT_Face face, [NativeTypeName("FT_ULong")] nuint char_code, [NativeTypeName("FT_Int32")] int load_flags);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Transform(FT_Face face, FT_Matrix* matrix, FT_Vector* delta);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Get_Transform(FT_Face face, FT_Matrix* matrix, FT_Vector* delta);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Render_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot, FT_Render_Mode render_mode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Kerning(FT_Face face, [NativeTypeName("FT_UInt")] uint left_glyph, [NativeTypeName("FT_UInt")] uint right_glyph, [NativeTypeName("FT_UInt")] uint kern_mode, FT_Vector* akerning);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Track_Kerning(FT_Face face, [NativeTypeName("FT_Fixed")] nint point_size, [NativeTypeName("FT_Int")] int degree, [NativeTypeName("FT_Fixed *")] nint* akerning);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Select_Charmap(FT_Face face, FT_Encoding encoding);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Charmap(FT_Face face, [NativeTypeName("FT_CharMap")] FT_CharMapRec* charmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Get_Charmap_Index([NativeTypeName("FT_CharMap")] FT_CharMapRec* charmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Char_Index(FT_Face face, [NativeTypeName("FT_ULong")] nuint charcode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_First_Char(FT_Face face, [NativeTypeName("FT_UInt *")] uint* agindex);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_Next_Char(FT_Face face, [NativeTypeName("FT_ULong")] nuint char_code, [NativeTypeName("FT_UInt *")] uint* agindex);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Face_Properties(FT_Face face, [NativeTypeName("FT_UInt")] uint num_properties, FT_Parameter* properties);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Name_Index(FT_Face face, [NativeTypeName("const FT_String *")] sbyte* glyph_name);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Glyph_Name(FT_Face face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_Pointer")] void* buffer, [NativeTypeName("FT_UInt")] uint buffer_max);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_Postscript_Name(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_SubGlyph_Info([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* glyph, [NativeTypeName("FT_UInt")] uint sub_index, [NativeTypeName("FT_Int *")] int* p_index, [NativeTypeName("FT_UInt *")] uint* p_flags, [NativeTypeName("FT_Int *")] int* p_arg1, [NativeTypeName("FT_Int *")] int* p_arg2, FT_Matrix* p_transform);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UShort")]
    public static extern ushort FT_Get_FSType_Flags(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Face_GetCharVariantIndex(FT_Face face, [NativeTypeName("FT_ULong")] nuint charcode, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Face_GetCharVariantIsDefault(FT_Face face, [NativeTypeName("FT_ULong")] nuint charcode, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetVariantSelectors(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetVariantsOfChar(FT_Face face, [NativeTypeName("FT_ULong")] nuint charcode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetCharsOfVariant(FT_Face face, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_MulDiv([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b, [NativeTypeName("FT_Long")] nint c);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_MulFix([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_DivFix([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_RoundFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_CeilFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_FloorFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Transform(FT_Vector* vector, [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Library_Version(FT_Library library, [NativeTypeName("FT_Int *")] int* amajor, [NativeTypeName("FT_Int *")] int* aminor, [NativeTypeName("FT_Int *")] int* apatch);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Face_CheckTrueTypePatents(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Face_SetUnpatentedHinting(FT_Face face, [NativeTypeName("FT_Bool")] byte value);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Advance(FT_Face face, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Int32")] int load_flags, [NativeTypeName("FT_Fixed *")] nint* padvance);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Advances(FT_Face face, [NativeTypeName("FT_UInt")] uint start, [NativeTypeName("FT_UInt")] uint count, [NativeTypeName("FT_Int32")] int load_flags, [NativeTypeName("FT_Fixed *")] nint* padvances);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Get_BBox(FT_Outline* outline, FT_BBox* abbox);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_BDF_Charset_ID(FT_Face face, [NativeTypeName("const char **")] sbyte** acharset_encoding, [NativeTypeName("const char **")] sbyte** acharset_registry);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_BDF_Property(FT_Face face, [NativeTypeName("const char *")] sbyte* prop_name, BDF_PropertyRec* aproperty);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Palette_Data_Get(FT_Face face, FT_Palette_Data* apalette);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Palette_Select(FT_Face face, [NativeTypeName("FT_UShort")] ushort palette_index, FT_Color** apalette);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Palette_Set_Foreground_Color(FT_Face face, FT_Color foreground_color);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_Layer(FT_Face face, [NativeTypeName("FT_UInt")] uint base_glyph, [NativeTypeName("FT_UInt *")] uint* aglyph_index, [NativeTypeName("FT_UInt *")] uint* acolor_index, FT_LayerIterator* iterator);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_Paint(FT_Face face, [NativeTypeName("FT_UInt")] uint base_glyph, FT_Color_Root_Transform root_transform, FT_OpaquePaint* paint);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_ClipBox(FT_Face face, [NativeTypeName("FT_UInt")] uint base_glyph, FT_ClipBox* clip_box);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Paint_Layers(FT_Face face, FT_LayerIterator* iterator, FT_OpaquePaint* paint);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Colorline_Stops(FT_Face face, FT_ColorStop* color_stop, FT_ColorStopIterator* iterator);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Paint(FT_Face face, FT_OpaquePaint opaque_paint, FT_COLR_Paint* paint);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Bitmap_Init(FT_Bitmap* abitmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Bitmap_New(FT_Bitmap* abitmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Bitmap_Copy(FT_Library library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source, FT_Bitmap* target);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Bitmap_Embolden(FT_Library library, FT_Bitmap* bitmap, [NativeTypeName("FT_Pos")] long xStrength, [NativeTypeName("FT_Pos")] long yStrength);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Bitmap_Convert(FT_Library library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source, FT_Bitmap* target, [NativeTypeName("FT_Int")] int alignment);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Bitmap_Blend(FT_Library library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source, [NativeTypeName("const FT_Vector")] FT_Vector source_offset, FT_Bitmap* target, FT_Vector* atarget_offset, FT_Color color);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_GlyphSlot_Own_Bitmap([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Bitmap_Done(FT_Library library, FT_Bitmap* bitmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stream_OpenBzip2([NativeTypeName("FT_Stream")] FT_StreamRec* stream, [NativeTypeName("FT_Stream")] FT_StreamRec* source);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_New_Glyph(FT_Library library, FT_Glyph_Format format, [NativeTypeName("FT_Glyph *")] FT_GlyphRec** aglyph);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot, [NativeTypeName("FT_Glyph *")] FT_GlyphRec** aglyph);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Glyph_Copy([NativeTypeName("FT_Glyph")] FT_GlyphRec* source, [NativeTypeName("FT_Glyph *")] FT_GlyphRec** target);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Glyph_Transform([NativeTypeName("FT_Glyph")] FT_GlyphRec* glyph, [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix, [NativeTypeName("const FT_Vector *")] FT_Vector* delta);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Glyph_Get_CBox([NativeTypeName("FT_Glyph")] FT_GlyphRec* glyph, [NativeTypeName("FT_UInt")] uint bbox_mode, FT_BBox* acbox);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Glyph_To_Bitmap([NativeTypeName("FT_Glyph *")] FT_GlyphRec** the_glyph, FT_Render_Mode render_mode, [NativeTypeName("const FT_Vector *")] FT_Vector* origin, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Done_Glyph([NativeTypeName("FT_Glyph")] FT_GlyphRec* glyph);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Matrix_Multiply([NativeTypeName("const FT_Matrix *")] FT_Matrix* a, FT_Matrix* b);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Matrix_Invert(FT_Matrix* matrix);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_Manager_New(FT_Library library, [NativeTypeName("FT_UInt")] uint max_faces, [NativeTypeName("FT_UInt")] uint max_sizes, [NativeTypeName("FT_ULong")] nuint max_bytes, [NativeTypeName("FTC_Face_Requester")] delegate* unmanaged[Cdecl]<void*, FT_Library, void*, FT_Face*, int> requester, [NativeTypeName("FT_Pointer")] void* req_data, [NativeTypeName("FTC_Manager *")] FTC_ManagerRec_** amanager);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_Reset([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_Done([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_Manager_LookupFace([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_FaceID")] void* face_id, FT_Face* aface);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_Manager_LookupSize([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec* scaler, [NativeTypeName("FT_Size *")] FT_SizeRec** asize);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Node_Unref([NativeTypeName("FTC_Node")] FTC_NodeRec_* node, [NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_RemoveFaceID([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_FaceID")] void* face_id);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_CMapCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_CMapCache *")] FTC_CMapCacheRec_** acache);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FTC_CMapCache_Lookup([NativeTypeName("FTC_CMapCache")] FTC_CMapCacheRec_* cache, [NativeTypeName("FTC_FaceID")] void* face_id, [NativeTypeName("FT_Int")] int cmap_index, [NativeTypeName("FT_UInt32")] uint char_code);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_ImageCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_ImageCache *")] FTC_ImageCacheRec_** acache);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_ImageCache_Lookup([NativeTypeName("FTC_ImageCache")] FTC_ImageCacheRec_* cache, [NativeTypeName("FTC_ImageType")] FTC_ImageTypeRec* type, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Glyph *")] FT_GlyphRec** aglyph, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_ImageCache_LookupScaler([NativeTypeName("FTC_ImageCache")] FTC_ImageCacheRec_* cache, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec* scaler, [NativeTypeName("FT_ULong")] nuint load_flags, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Glyph *")] FT_GlyphRec** aglyph, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_SBitCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_SBitCache *")] FTC_SBitCacheRec_** acache);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_SBitCache_Lookup([NativeTypeName("FTC_SBitCache")] FTC_SBitCacheRec_* cache, [NativeTypeName("FTC_ImageType")] FTC_ImageTypeRec* type, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FTC_SBit *")] FTC_SBitRec** sbit, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FTC_SBitCache_LookupScaler([NativeTypeName("FTC_SBitCache")] FTC_SBitCacheRec_* cache, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec* scaler, [NativeTypeName("FT_ULong")] nuint load_flags, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FTC_SBit *")] FTC_SBitRec** sbit, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_CID_Registry_Ordering_Supplement(FT_Face face, [NativeTypeName("const char **")] sbyte** registry, [NativeTypeName("const char **")] sbyte** ordering, [NativeTypeName("FT_Int *")] int* supplement);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_CID_Is_Internally_CID_Keyed(FT_Face face, [NativeTypeName("FT_Bool *")] byte* is_cid);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_CID_From_Glyph_Index(FT_Face face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_UInt *")] uint* cid);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_Font_Format(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_X11_Font_Format(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Get_Gasp(FT_Face face, [NativeTypeName("FT_UInt")] uint ppem);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_TrueTypeGX_Validate(FT_Face face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes[10]")] byte** tables, [NativeTypeName("FT_UInt")] uint table_length);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_TrueTypeGX_Free(FT_Face face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_ClassicKern_Validate(FT_Face face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes *")] byte** ckern_table);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_ClassicKern_Free(FT_Face face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stream_OpenGzip([NativeTypeName("FT_Stream")] FT_StreamRec* stream, [NativeTypeName("FT_Stream")] FT_StreamRec* source);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Gzip_Uncompress(FT_Memory memory, [NativeTypeName("FT_Byte *")] byte* output, [NativeTypeName("FT_ULong *")] nuint* output_len, [NativeTypeName("const FT_Byte *")] byte* input, [NativeTypeName("FT_ULong")] nuint input_len);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Library_SetLcdFilter(FT_Library library, FT_LcdFilter filter);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Library_SetLcdFilterWeights(FT_Library library, [NativeTypeName("unsigned char *")] byte* weights);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Library_SetLcdGeometry(FT_Library library, [NativeTypeName("FT_Vector[3]")] FT_Vector* sub);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ListNode")]
    public static extern FT_ListNodeRec* FT_List_Find([NativeTypeName("FT_List")] FT_ListRec* list, void* data);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Add([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Insert([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Remove([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Up([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_List_Iterate([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_List_Iterator")] delegate* unmanaged[Cdecl]<FT_ListNodeRec*, void*, int> iterator, void* user);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Finalize([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_List_Destructor")] delegate* unmanaged[Cdecl]<FT_Memory, void*, void*, void> destroy, FT_Memory memory, void* user);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Trace_Set_Level([NativeTypeName("const char *")] sbyte* tracing_level);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Trace_Set_Default_Level();

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Log_Handler([NativeTypeName("FT_Custom_Log_Handler")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void*, void> handler);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Default_Log_Handler();

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stream_OpenLZW([NativeTypeName("FT_Stream")] FT_StreamRec* stream, [NativeTypeName("FT_Stream")] FT_StreamRec* source);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Multi_Master(FT_Face face, FT_Multi_Master* amaster);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_MM_Var(FT_Face face, FT_MM_Var** amaster);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Done_MM_Var(FT_Library library, FT_MM_Var* amaster);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_MM_Design_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Long *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Var_Design_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Var_Design_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_MM_Blend_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_MM_Blend_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Var_Blend_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Var_Blend_Coordinates(FT_Face face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_MM_WeightVector(FT_Face face, [NativeTypeName("FT_UInt")] uint len, [NativeTypeName("FT_Fixed *")] nint* weightvector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_MM_WeightVector(FT_Face face, [NativeTypeName("FT_UInt *")] uint* len, [NativeTypeName("FT_Fixed *")] nint* weightvector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Var_Axis_Flags(FT_MM_Var* master, [NativeTypeName("FT_UInt")] uint axis_index, [NativeTypeName("FT_UInt *")] uint* flags);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Named_Instance(FT_Face face, [NativeTypeName("FT_UInt")] uint instance_index);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Default_Named_Instance(FT_Face face, [NativeTypeName("FT_UInt *")] uint* instance_index);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Add_Module(FT_Library library, [NativeTypeName("const FT_Module_Class *")] FT_Module_Class* clazz);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_Module FT_Get_Module(FT_Library library, [NativeTypeName("const char *")] sbyte* module_name);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Remove_Module(FT_Library library, FT_Module module);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Property_Set(FT_Library library, [NativeTypeName("const FT_String *")] sbyte* module_name, [NativeTypeName("const FT_String *")] sbyte* property_name, [NativeTypeName("const void *")] void* value);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Property_Get(FT_Library library, [NativeTypeName("const FT_String *")] sbyte* module_name, [NativeTypeName("const FT_String *")] sbyte* property_name, void* value);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Default_Properties(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Reference_Library(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_New_Library(FT_Memory memory, FT_Library* alibrary);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Done_Library(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Debug_Hook(FT_Library library, [NativeTypeName("FT_UInt")] uint hook_index, [NativeTypeName("FT_DebugHook_Func")] delegate* unmanaged[Cdecl]<void*, int> debug_hook);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Add_Default_Modules(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_TrueTypeEngineType FT_Get_TrueType_Engine_Type(FT_Library library);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_OpenType_Validate(FT_Face face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes *")] byte** BASE_table, [NativeTypeName("FT_Bytes *")] byte** GDEF_table, [NativeTypeName("FT_Bytes *")] byte** GPOS_table, [NativeTypeName("FT_Bytes *")] byte** GSUB_table, [NativeTypeName("FT_Bytes *")] byte** JSTF_table);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_OpenType_Free(FT_Face face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Decompose(FT_Outline* outline, [NativeTypeName("const FT_Outline_Funcs *")] FT_Outline_Funcs* func_interface, void* user);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_New(FT_Library library, [NativeTypeName("FT_UInt")] uint numPoints, [NativeTypeName("FT_Int")] int numContours, FT_Outline* anoutline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Done(FT_Library library, FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Check(FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Get_CBox([NativeTypeName("const FT_Outline *")] FT_Outline* outline, FT_BBox* acbox);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Translate([NativeTypeName("const FT_Outline *")] FT_Outline* outline, [NativeTypeName("FT_Pos")] long xOffset, [NativeTypeName("FT_Pos")] long yOffset);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Copy([NativeTypeName("const FT_Outline *")] FT_Outline* source, FT_Outline* target);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Transform([NativeTypeName("const FT_Outline *")] FT_Outline* outline, [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Embolden(FT_Outline* outline, [NativeTypeName("FT_Pos")] long strength);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_EmboldenXY(FT_Outline* outline, [NativeTypeName("FT_Pos")] long xstrength, [NativeTypeName("FT_Pos")] long ystrength);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Reverse(FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Get_Bitmap(FT_Library library, FT_Outline* outline, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* abitmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Outline_Render(FT_Library library, FT_Outline* outline, FT_Raster_Params* @params);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_Orientation FT_Outline_Get_Orientation(FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_PFR_Metrics(FT_Face face, [NativeTypeName("FT_UInt *")] uint* aoutline_resolution, [NativeTypeName("FT_UInt *")] uint* ametrics_resolution, [NativeTypeName("FT_Fixed *")] nint* ametrics_x_scale, [NativeTypeName("FT_Fixed *")] nint* ametrics_y_scale);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_PFR_Kerning(FT_Face face, [NativeTypeName("FT_UInt")] uint left, [NativeTypeName("FT_UInt")] uint right, FT_Vector* avector);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_PFR_Advance(FT_Face face, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Pos *")] long* aadvance);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_Renderer FT_Get_Renderer(FT_Library library, FT_Glyph_Format format);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Set_Renderer(FT_Library library, FT_Renderer renderer, [NativeTypeName("FT_UInt")] uint num_params, FT_Parameter* parameters);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_New_Size(FT_Face face, [NativeTypeName("FT_Size *")] FT_SizeRec** size);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Done_Size([NativeTypeName("FT_Size")] FT_SizeRec* size);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Activate_Size([NativeTypeName("FT_Size")] FT_SizeRec* size);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Sfnt_Name_Count(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Sfnt_Name(FT_Face face, [NativeTypeName("FT_UInt")] uint idx, FT_SfntName* aname);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_Sfnt_LangTag(FT_Face face, [NativeTypeName("FT_UInt")] uint langID, FT_SfntLangTag* alangTag);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_StrokerBorder FT_Outline_GetInsideBorder(FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern FT_StrokerBorder FT_Outline_GetOutsideBorder(FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_New(FT_Library library, [NativeTypeName("FT_Stroker *")] FT_StrokerRec_** astroker);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Set([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Fixed")] nint radius, FT_Stroker_LineCap line_cap, FT_Stroker_LineJoin line_join, [NativeTypeName("FT_Fixed")] nint miter_limit);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Rewind([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_ParseOutline([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Outline* outline, [NativeTypeName("FT_Bool")] byte opened);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_BeginSubPath([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Vector* to, [NativeTypeName("FT_Bool")] byte open);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_EndSubPath([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_LineTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Vector* to);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_ConicTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Vector* control, FT_Vector* to);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_CubicTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Vector* control1, FT_Vector* control2, FT_Vector* to);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_GetBorderCounts([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_StrokerBorder border, [NativeTypeName("FT_UInt *")] uint* anum_points, [NativeTypeName("FT_UInt *")] uint* anum_contours);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_ExportBorder([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_StrokerBorder border, FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Stroker_GetCounts([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_UInt *")] uint* anum_points, [NativeTypeName("FT_UInt *")] uint* anum_contours);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Export([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, FT_Outline* outline);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Done([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Glyph_Stroke([NativeTypeName("FT_Glyph *")] FT_GlyphRec** pglyph, [NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Glyph_StrokeBorder([NativeTypeName("FT_Glyph *")] FT_GlyphRec** pglyph, [NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Bool")] byte inside, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Embolden([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_AdjustWeight([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot, [NativeTypeName("FT_Fixed")] nint xdelta, [NativeTypeName("FT_Fixed")] nint ydelta);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Oblique([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Slant([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot, [NativeTypeName("FT_Fixed")] nint xslant, [NativeTypeName("FT_Fixed")] nint yslant);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Sin([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Cos([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Tan([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Angle")]
    public static extern nint FT_Atan2([NativeTypeName("FT_Fixed")] nint x, [NativeTypeName("FT_Fixed")] nint y);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Angle")]
    public static extern nint FT_Angle_Diff([NativeTypeName("FT_Angle")] nint angle1, [NativeTypeName("FT_Angle")] nint angle2);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Unit(FT_Vector* vec, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Rotate(FT_Vector* vec, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Vector_Length(FT_Vector* vec);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Polarize(FT_Vector* vec, [NativeTypeName("FT_Fixed *")] nint* length, [NativeTypeName("FT_Angle *")] nint* angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_From_Polar(FT_Vector* vec, [NativeTypeName("FT_Fixed")] nint length, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_WinFNT_Header(FT_Face face, FT_WinFNT_HeaderRec* aheader);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Has_PS_Glyph_Names(FT_Face face);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_PS_Font_Info(FT_Face face, [NativeTypeName("PS_FontInfo")] PS_FontInfoRec* afont_info);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Get_PS_Font_Private(FT_Face face, [NativeTypeName("PS_Private")] PS_PrivateRec* afont_private);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_Get_PS_Font_Value(FT_Face face, PS_Dict_Keys key, [NativeTypeName("FT_UInt")] uint idx, void* value, [NativeTypeName("FT_Long")] nint value_len);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* FT_Get_Sfnt_Table(FT_Face face, FT_Sfnt_Tag tag);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Load_Sfnt_Table(FT_Face face, [NativeTypeName("FT_ULong")] nuint tag, [NativeTypeName("FT_Long")] nint offset, [NativeTypeName("FT_Byte *")] byte* buffer, [NativeTypeName("FT_ULong *")] nuint* length);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern int FT_Sfnt_Table_Info(FT_Face face, [NativeTypeName("FT_UInt")] uint table_index, [NativeTypeName("FT_ULong *")] nuint* tag, [NativeTypeName("FT_ULong *")] nuint* length);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_CMap_Language_ID([NativeTypeName("FT_CharMap")] FT_CharMapRec* charmap);

    [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_Get_CMap_Format([NativeTypeName("FT_CharMap")] FT_CharMapRec* charmap);

    [NativeTypeName("#define ft_pixel_mode_none FT_PIXEL_MODE_NONE")]
    public const FT_Pixel_Mode ft_pixel_mode_none = FT_Pixel_Mode.NONE;

    [NativeTypeName("#define ft_pixel_mode_mono FT_PIXEL_MODE_MONO")]
    public const FT_Pixel_Mode ft_pixel_mode_mono = FT_Pixel_Mode.MONO;

    [NativeTypeName("#define ft_pixel_mode_grays FT_PIXEL_MODE_GRAY")]
    public const FT_Pixel_Mode ft_pixel_mode_grays = FT_Pixel_Mode.GRAY;

    [NativeTypeName("#define ft_pixel_mode_pal2 FT_PIXEL_MODE_GRAY2")]
    public const FT_Pixel_Mode ft_pixel_mode_pal2 = FT_Pixel_Mode.GRAY2;

    [NativeTypeName("#define ft_pixel_mode_pal4 FT_PIXEL_MODE_GRAY4")]
    public const FT_Pixel_Mode ft_pixel_mode_pal4 = FT_Pixel_Mode.GRAY4;

    [NativeTypeName("#define FT_OUTLINE_CONTOURS_MAX USHRT_MAX")]
    public const int FT_OUTLINE_CONTOURS_MAX = (32767 * 2 + 1);

    [NativeTypeName("#define FT_OUTLINE_POINTS_MAX USHRT_MAX")]
    public const int FT_OUTLINE_POINTS_MAX = (32767 * 2 + 1);

    [NativeTypeName("#define FT_OUTLINE_NONE 0x0")]
    public const int FT_OUTLINE_NONE = 0x0;

    [NativeTypeName("#define FT_OUTLINE_OWNER 0x1")]
    public const int FT_OUTLINE_OWNER = 0x1;

    [NativeTypeName("#define FT_OUTLINE_EVEN_ODD_FILL 0x2")]
    public const int FT_OUTLINE_EVEN_ODD_FILL = 0x2;

    [NativeTypeName("#define FT_OUTLINE_REVERSE_FILL 0x4")]
    public const int FT_OUTLINE_REVERSE_FILL = 0x4;

    [NativeTypeName("#define FT_OUTLINE_IGNORE_DROPOUTS 0x8")]
    public const int FT_OUTLINE_IGNORE_DROPOUTS = 0x8;

    [NativeTypeName("#define FT_OUTLINE_SMART_DROPOUTS 0x10")]
    public const int FT_OUTLINE_SMART_DROPOUTS = 0x10;

    [NativeTypeName("#define FT_OUTLINE_INCLUDE_STUBS 0x20")]
    public const int FT_OUTLINE_INCLUDE_STUBS = 0x20;

    [NativeTypeName("#define FT_OUTLINE_OVERLAP 0x40")]
    public const int FT_OUTLINE_OVERLAP = 0x40;

    [NativeTypeName("#define FT_OUTLINE_HIGH_PRECISION 0x100")]
    public const int FT_OUTLINE_HIGH_PRECISION = 0x100;

    [NativeTypeName("#define FT_OUTLINE_SINGLE_PASS 0x200")]
    public const int FT_OUTLINE_SINGLE_PASS = 0x200;

    [NativeTypeName("#define ft_outline_none FT_OUTLINE_NONE")]
    public const int ft_outline_none = 0x0;

    [NativeTypeName("#define ft_outline_owner FT_OUTLINE_OWNER")]
    public const int ft_outline_owner = 0x1;

    [NativeTypeName("#define ft_outline_even_odd_fill FT_OUTLINE_EVEN_ODD_FILL")]
    public const int ft_outline_even_odd_fill = 0x2;

    [NativeTypeName("#define ft_outline_reverse_fill FT_OUTLINE_REVERSE_FILL")]
    public const int ft_outline_reverse_fill = 0x4;

    [NativeTypeName("#define ft_outline_ignore_dropouts FT_OUTLINE_IGNORE_DROPOUTS")]
    public const int ft_outline_ignore_dropouts = 0x8;

    [NativeTypeName("#define ft_outline_high_precision FT_OUTLINE_HIGH_PRECISION")]
    public const int ft_outline_high_precision = 0x100;

    [NativeTypeName("#define ft_outline_single_pass FT_OUTLINE_SINGLE_PASS")]
    public const int ft_outline_single_pass = 0x200;

    [NativeTypeName("#define FT_CURVE_TAG_ON 0x01")]
    public const int FT_CURVE_TAG_ON = 0x01;

    [NativeTypeName("#define FT_CURVE_TAG_CONIC 0x00")]
    public const int FT_CURVE_TAG_CONIC = 0x00;

    [NativeTypeName("#define FT_CURVE_TAG_CUBIC 0x02")]
    public const int FT_CURVE_TAG_CUBIC = 0x02;

    [NativeTypeName("#define FT_CURVE_TAG_HAS_SCANMODE 0x04")]
    public const int FT_CURVE_TAG_HAS_SCANMODE = 0x04;

    [NativeTypeName("#define FT_CURVE_TAG_TOUCH_X 0x08")]
    public const int FT_CURVE_TAG_TOUCH_X = 0x08;

    [NativeTypeName("#define FT_CURVE_TAG_TOUCH_Y 0x10")]
    public const int FT_CURVE_TAG_TOUCH_Y = 0x10;

    [NativeTypeName("#define FT_CURVE_TAG_TOUCH_BOTH ( FT_CURVE_TAG_TOUCH_X | \\\n                                     FT_CURVE_TAG_TOUCH_Y )")]
    public const int FT_CURVE_TAG_TOUCH_BOTH = (0x08 | 0x10);

    [NativeTypeName("#define FT_Curve_Tag_On FT_CURVE_TAG_ON")]
    public const int FT_Curve_Tag_On = 0x01;

    [NativeTypeName("#define FT_Curve_Tag_Conic FT_CURVE_TAG_CONIC")]
    public const int FT_Curve_Tag_Conic = 0x00;

    [NativeTypeName("#define FT_Curve_Tag_Cubic FT_CURVE_TAG_CUBIC")]
    public const int FT_Curve_Tag_Cubic = 0x02;

    [NativeTypeName("#define FT_Curve_Tag_Touch_X FT_CURVE_TAG_TOUCH_X")]
    public const int FT_Curve_Tag_Touch_X = 0x08;

    [NativeTypeName("#define FT_Curve_Tag_Touch_Y FT_CURVE_TAG_TOUCH_Y")]
    public const int FT_Curve_Tag_Touch_Y = 0x10;

    [NativeTypeName("#define ft_glyph_format_none FT_GLYPH_FORMAT_NONE")]
    public const FT_Glyph_Format ft_glyph_format_none = FT_Glyph_Format.NONE;

    [NativeTypeName("#define ft_glyph_format_composite FT_GLYPH_FORMAT_COMPOSITE")]
    public const FT_Glyph_Format ft_glyph_format_composite = FT_Glyph_Format.COMPOSITE;

    [NativeTypeName("#define ft_glyph_format_bitmap FT_GLYPH_FORMAT_BITMAP")]
    public const FT_Glyph_Format ft_glyph_format_bitmap = FT_Glyph_Format.BITMAP;

    [NativeTypeName("#define ft_glyph_format_outline FT_GLYPH_FORMAT_OUTLINE")]
    public const FT_Glyph_Format ft_glyph_format_outline = FT_Glyph_Format.OUTLINE;

    [NativeTypeName("#define ft_glyph_format_plotter FT_GLYPH_FORMAT_PLOTTER")]
    public const FT_Glyph_Format ft_glyph_format_plotter = FT_Glyph_Format.PLOTTER;

    [NativeTypeName("#define FT_RASTER_FLAG_DEFAULT 0x0")]
    public const int FT_RASTER_FLAG_DEFAULT = 0x0;

    [NativeTypeName("#define FT_RASTER_FLAG_AA 0x1")]
    public const int FT_RASTER_FLAG_AA = 0x1;

    [NativeTypeName("#define FT_RASTER_FLAG_DIRECT 0x2")]
    public const int FT_RASTER_FLAG_DIRECT = 0x2;

    [NativeTypeName("#define FT_RASTER_FLAG_CLIP 0x4")]
    public const int FT_RASTER_FLAG_CLIP = 0x4;

    [NativeTypeName("#define FT_RASTER_FLAG_SDF 0x8")]
    public const int FT_RASTER_FLAG_SDF = 0x8;

    [NativeTypeName("#define ft_raster_flag_default FT_RASTER_FLAG_DEFAULT")]
    public const int ft_raster_flag_default = 0x0;

    [NativeTypeName("#define ft_raster_flag_aa FT_RASTER_FLAG_AA")]
    public const int ft_raster_flag_aa = 0x1;

    [NativeTypeName("#define ft_raster_flag_direct FT_RASTER_FLAG_DIRECT")]
    public const int ft_raster_flag_direct = 0x2;

    [NativeTypeName("#define ft_raster_flag_clip FT_RASTER_FLAG_CLIP")]
    public const int ft_raster_flag_clip = 0x4;

    [NativeTypeName("#define FT_ERR_BASE 0")]
    public const int FT_ERR_BASE = 0;

    [NativeTypeName("#define ft_encoding_none FT_ENCODING_NONE")]
    public const FT_Encoding ft_encoding_none = FT_Encoding.NONE;

    [NativeTypeName("#define ft_encoding_unicode FT_ENCODING_UNICODE")]
    public const FT_Encoding ft_encoding_unicode = FT_Encoding.UNICODE;

    [NativeTypeName("#define ft_encoding_symbol FT_ENCODING_MS_SYMBOL")]
    public const FT_Encoding ft_encoding_symbol = FT_Encoding.MS_SYMBOL;

    [NativeTypeName("#define ft_encoding_latin_1 FT_ENCODING_ADOBE_LATIN_1")]
    public const FT_Encoding ft_encoding_latin_1 = FT_Encoding.ADOBE_LATIN_1;

    [NativeTypeName("#define ft_encoding_latin_2 FT_ENCODING_OLD_LATIN_2")]
    public const FT_Encoding ft_encoding_latin_2 = FT_Encoding.OLD_LATIN_2;

    [NativeTypeName("#define ft_encoding_sjis FT_ENCODING_SJIS")]
    public const FT_Encoding ft_encoding_sjis = FT_Encoding.SJIS;

    [NativeTypeName("#define ft_encoding_gb2312 FT_ENCODING_PRC")]
    public const FT_Encoding ft_encoding_gb2312 = FT_Encoding.PRC;

    [NativeTypeName("#define ft_encoding_big5 FT_ENCODING_BIG5")]
    public const FT_Encoding ft_encoding_big5 = FT_Encoding.BIG5;

    [NativeTypeName("#define ft_encoding_wansung FT_ENCODING_WANSUNG")]
    public const FT_Encoding ft_encoding_wansung = FT_Encoding.WANSUNG;

    [NativeTypeName("#define ft_encoding_johab FT_ENCODING_JOHAB")]
    public const FT_Encoding ft_encoding_johab = FT_Encoding.JOHAB;

    [NativeTypeName("#define ft_encoding_adobe_standard FT_ENCODING_ADOBE_STANDARD")]
    public const FT_Encoding ft_encoding_adobe_standard = FT_Encoding.ADOBE_STANDARD;

    [NativeTypeName("#define ft_encoding_adobe_expert FT_ENCODING_ADOBE_EXPERT")]
    public const FT_Encoding ft_encoding_adobe_expert = FT_Encoding.ADOBE_EXPERT;

    [NativeTypeName("#define ft_encoding_adobe_custom FT_ENCODING_ADOBE_CUSTOM")]
    public const FT_Encoding ft_encoding_adobe_custom = FT_Encoding.ADOBE_CUSTOM;

    [NativeTypeName("#define ft_encoding_apple_roman FT_ENCODING_APPLE_ROMAN")]
    public const FT_Encoding ft_encoding_apple_roman = FT_Encoding.APPLE_ROMAN;

    [NativeTypeName("#define FT_FACE_FLAG_SCALABLE ( 1L <<  0 )")]
    public const nint FT_FACE_FLAG_SCALABLE = (1 << 0);

    [NativeTypeName("#define FT_FACE_FLAG_FIXED_SIZES ( 1L <<  1 )")]
    public const nint FT_FACE_FLAG_FIXED_SIZES = (1 << 1);

    [NativeTypeName("#define FT_FACE_FLAG_FIXED_WIDTH ( 1L <<  2 )")]
    public const nint FT_FACE_FLAG_FIXED_WIDTH = (1 << 2);

    [NativeTypeName("#define FT_FACE_FLAG_SFNT ( 1L <<  3 )")]
    public const nint FT_FACE_FLAG_SFNT = (1 << 3);

    [NativeTypeName("#define FT_FACE_FLAG_HORIZONTAL ( 1L <<  4 )")]
    public const nint FT_FACE_FLAG_HORIZONTAL = (1 << 4);

    [NativeTypeName("#define FT_FACE_FLAG_VERTICAL ( 1L <<  5 )")]
    public const nint FT_FACE_FLAG_VERTICAL = (1 << 5);

    [NativeTypeName("#define FT_FACE_FLAG_KERNING ( 1L <<  6 )")]
    public const nint FT_FACE_FLAG_KERNING = (1 << 6);

    [NativeTypeName("#define FT_FACE_FLAG_FAST_GLYPHS ( 1L <<  7 )")]
    public const nint FT_FACE_FLAG_FAST_GLYPHS = (1 << 7);

    [NativeTypeName("#define FT_FACE_FLAG_MULTIPLE_MASTERS ( 1L <<  8 )")]
    public const nint FT_FACE_FLAG_MULTIPLE_MASTERS = (1 << 8);

    [NativeTypeName("#define FT_FACE_FLAG_GLYPH_NAMES ( 1L <<  9 )")]
    public const nint FT_FACE_FLAG_GLYPH_NAMES = (1 << 9);

    [NativeTypeName("#define FT_FACE_FLAG_EXTERNAL_STREAM ( 1L << 10 )")]
    public const nint FT_FACE_FLAG_EXTERNAL_STREAM = (1 << 10);

    [NativeTypeName("#define FT_FACE_FLAG_HINTER ( 1L << 11 )")]
    public const nint FT_FACE_FLAG_HINTER = (1 << 11);

    [NativeTypeName("#define FT_FACE_FLAG_CID_KEYED ( 1L << 12 )")]
    public const nint FT_FACE_FLAG_CID_KEYED = (1 << 12);

    [NativeTypeName("#define FT_FACE_FLAG_TRICKY ( 1L << 13 )")]
    public const nint FT_FACE_FLAG_TRICKY = (1 << 13);

    [NativeTypeName("#define FT_FACE_FLAG_COLOR ( 1L << 14 )")]
    public const nint FT_FACE_FLAG_COLOR = (1 << 14);

    [NativeTypeName("#define FT_FACE_FLAG_VARIATION ( 1L << 15 )")]
    public const nint FT_FACE_FLAG_VARIATION = (1 << 15);

    [NativeTypeName("#define FT_FACE_FLAG_SVG ( 1L << 16 )")]
    public const nint FT_FACE_FLAG_SVG = (1 << 16);

    [NativeTypeName("#define FT_FACE_FLAG_SBIX ( 1L << 17 )")]
    public const nint FT_FACE_FLAG_SBIX = (1 << 17);

    [NativeTypeName("#define FT_FACE_FLAG_SBIX_OVERLAY ( 1L << 18 )")]
    public const nint FT_FACE_FLAG_SBIX_OVERLAY = (1 << 18);

    [NativeTypeName("#define FT_STYLE_FLAG_ITALIC ( 1 << 0 )")]
    public const int FT_STYLE_FLAG_ITALIC = (1 << 0);

    [NativeTypeName("#define FT_STYLE_FLAG_BOLD ( 1 << 1 )")]
    public const int FT_STYLE_FLAG_BOLD = (1 << 1);

    [NativeTypeName("#define FT_OPEN_MEMORY 0x1")]
    public const int FT_OPEN_MEMORY = 0x1;

    [NativeTypeName("#define FT_OPEN_STREAM 0x2")]
    public const int FT_OPEN_STREAM = 0x2;

    [NativeTypeName("#define FT_OPEN_PATHNAME 0x4")]
    public const int FT_OPEN_PATHNAME = 0x4;

    [NativeTypeName("#define FT_OPEN_DRIVER 0x8")]
    public const int FT_OPEN_DRIVER = 0x8;

    [NativeTypeName("#define FT_OPEN_PARAMS 0x10")]
    public const int FT_OPEN_PARAMS = 0x10;

    [NativeTypeName("#define ft_open_memory FT_OPEN_MEMORY")]
    public const int ft_open_memory = 0x1;

    [NativeTypeName("#define ft_open_stream FT_OPEN_STREAM")]
    public const int ft_open_stream = 0x2;

    [NativeTypeName("#define ft_open_pathname FT_OPEN_PATHNAME")]
    public const int ft_open_pathname = 0x4;

    [NativeTypeName("#define ft_open_driver FT_OPEN_DRIVER")]
    public const int ft_open_driver = 0x8;

    [NativeTypeName("#define ft_open_params FT_OPEN_PARAMS")]
    public const int ft_open_params = 0x10;

    [NativeTypeName("#define FT_LOAD_DEFAULT 0x0")]
    public const int FT_LOAD_DEFAULT = 0x0;

    [NativeTypeName("#define FT_LOAD_NO_SCALE ( 1L << 0  )")]
    public const nint FT_LOAD_NO_SCALE = (1 << 0);

    [NativeTypeName("#define FT_LOAD_NO_HINTING ( 1L << 1  )")]
    public const nint FT_LOAD_NO_HINTING = (1 << 1);

    [NativeTypeName("#define FT_LOAD_RENDER ( 1L << 2  )")]
    public const nint FT_LOAD_RENDER = (1 << 2);

    [NativeTypeName("#define FT_LOAD_NO_BITMAP ( 1L << 3  )")]
    public const nint FT_LOAD_NO_BITMAP = (1 << 3);

    [NativeTypeName("#define FT_LOAD_VERTICAL_LAYOUT ( 1L << 4  )")]
    public const nint FT_LOAD_VERTICAL_LAYOUT = (1 << 4);

    [NativeTypeName("#define FT_LOAD_FORCE_AUTOHINT ( 1L << 5  )")]
    public const nint FT_LOAD_FORCE_AUTOHINT = (1 << 5);

    [NativeTypeName("#define FT_LOAD_CROP_BITMAP ( 1L << 6  )")]
    public const nint FT_LOAD_CROP_BITMAP = (1 << 6);

    [NativeTypeName("#define FT_LOAD_PEDANTIC ( 1L << 7  )")]
    public const nint FT_LOAD_PEDANTIC = (1 << 7);

    [NativeTypeName("#define FT_LOAD_IGNORE_GLOBAL_ADVANCE_WIDTH ( 1L << 9  )")]
    public const nint FT_LOAD_IGNORE_GLOBAL_ADVANCE_WIDTH = (1 << 9);

    [NativeTypeName("#define FT_LOAD_NO_RECURSE ( 1L << 10 )")]
    public const nint FT_LOAD_NO_RECURSE = (1 << 10);

    [NativeTypeName("#define FT_LOAD_IGNORE_TRANSFORM ( 1L << 11 )")]
    public const nint FT_LOAD_IGNORE_TRANSFORM = (1 << 11);

    [NativeTypeName("#define FT_LOAD_MONOCHROME ( 1L << 12 )")]
    public const nint FT_LOAD_MONOCHROME = (1 << 12);

    [NativeTypeName("#define FT_LOAD_LINEAR_DESIGN ( 1L << 13 )")]
    public const nint FT_LOAD_LINEAR_DESIGN = (1 << 13);

    [NativeTypeName("#define FT_LOAD_SBITS_ONLY ( 1L << 14 )")]
    public const nint FT_LOAD_SBITS_ONLY = (1 << 14);

    [NativeTypeName("#define FT_LOAD_NO_AUTOHINT ( 1L << 15 )")]
    public const nint FT_LOAD_NO_AUTOHINT = (1 << 15);

    [NativeTypeName("#define FT_LOAD_COLOR ( 1L << 20 )")]
    public const nint FT_LOAD_COLOR = (1 << 20);

    [NativeTypeName("#define FT_LOAD_COMPUTE_METRICS ( 1L << 21 )")]
    public const nint FT_LOAD_COMPUTE_METRICS = (1 << 21);

    [NativeTypeName("#define FT_LOAD_BITMAP_METRICS_ONLY ( 1L << 22 )")]
    public const nint FT_LOAD_BITMAP_METRICS_ONLY = (1 << 22);

    [NativeTypeName("#define FT_LOAD_NO_SVG ( 1L << 24 )")]
    public const nint FT_LOAD_NO_SVG = (1 << 24);

    [NativeTypeName("#define FT_LOAD_ADVANCE_ONLY ( 1L << 8  )")]
    public const nint FT_LOAD_ADVANCE_ONLY = (1 << 8);

    [NativeTypeName("#define FT_LOAD_SVG_ONLY ( 1L << 23 )")]
    public const nint FT_LOAD_SVG_ONLY = (1 << 23);

    [NativeTypeName("#define FT_LOAD_TARGET_NORMAL FT_LOAD_TARGET_( FT_RENDER_MODE_NORMAL )")]
    public const int FT_LOAD_TARGET_NORMAL = ((int)((int)(FT_Render_Mode.NORMAL) & 15) << 16);

    [NativeTypeName("#define FT_LOAD_TARGET_LIGHT FT_LOAD_TARGET_( FT_RENDER_MODE_LIGHT  )")]
    public const int FT_LOAD_TARGET_LIGHT = ((int)((int)(FT_Render_Mode.LIGHT) & 15) << 16);

    [NativeTypeName("#define FT_LOAD_TARGET_MONO FT_LOAD_TARGET_( FT_RENDER_MODE_MONO   )")]
    public const int FT_LOAD_TARGET_MONO = ((int)((int)(FT_Render_Mode.MONO) & 15) << 16);

    [NativeTypeName("#define FT_LOAD_TARGET_LCD FT_LOAD_TARGET_( FT_RENDER_MODE_LCD    )")]
    public const int FT_LOAD_TARGET_LCD = ((int)((int)(FT_Render_Mode.LCD) & 15) << 16);

    [NativeTypeName("#define FT_LOAD_TARGET_LCD_V FT_LOAD_TARGET_( FT_RENDER_MODE_LCD_V  )")]
    public const int FT_LOAD_TARGET_LCD_V = ((int)((int)(FT_Render_Mode.LCD_V) & 15) << 16);

    [NativeTypeName("#define ft_render_mode_normal FT_RENDER_MODE_NORMAL")]
    public const FT_Render_Mode ft_render_mode_normal = FT_Render_Mode.NORMAL;

    [NativeTypeName("#define ft_render_mode_mono FT_RENDER_MODE_MONO")]
    public const FT_Render_Mode ft_render_mode_mono = FT_Render_Mode.MONO;

    [NativeTypeName("#define ft_kerning_default FT_KERNING_DEFAULT")]
    public const FT_Kerning_Mode ft_kerning_default = FT_Kerning_Mode.DEFAULT;

    [NativeTypeName("#define ft_kerning_unfitted FT_KERNING_UNFITTED")]
    public const FT_Kerning_Mode ft_kerning_unfitted = FT_Kerning_Mode.UNFITTED;

    [NativeTypeName("#define ft_kerning_unscaled FT_KERNING_UNSCALED")]
    public const FT_Kerning_Mode ft_kerning_unscaled = FT_Kerning_Mode.UNSCALED;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_ARGS_ARE_WORDS 1")]
    public const int FT_SUBGLYPH_FLAG_ARGS_ARE_WORDS = 1;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_ARGS_ARE_XY_VALUES 2")]
    public const int FT_SUBGLYPH_FLAG_ARGS_ARE_XY_VALUES = 2;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_ROUND_XY_TO_GRID 4")]
    public const int FT_SUBGLYPH_FLAG_ROUND_XY_TO_GRID = 4;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_SCALE 8")]
    public const int FT_SUBGLYPH_FLAG_SCALE = 8;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_XY_SCALE 0x40")]
    public const int FT_SUBGLYPH_FLAG_XY_SCALE = 0x40;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_2X2 0x80")]
    public const int FT_SUBGLYPH_FLAG_2X2 = 0x80;

    [NativeTypeName("#define FT_SUBGLYPH_FLAG_USE_MY_METRICS 0x200")]
    public const int FT_SUBGLYPH_FLAG_USE_MY_METRICS = 0x200;

    [NativeTypeName("#define FT_FSTYPE_INSTALLABLE_EMBEDDING 0x0000")]
    public const int FT_FSTYPE_INSTALLABLE_EMBEDDING = 0x0000;

    [NativeTypeName("#define FT_FSTYPE_RESTRICTED_LICENSE_EMBEDDING 0x0002")]
    public const int FT_FSTYPE_RESTRICTED_LICENSE_EMBEDDING = 0x0002;

    [NativeTypeName("#define FT_FSTYPE_PREVIEW_AND_PRINT_EMBEDDING 0x0004")]
    public const int FT_FSTYPE_PREVIEW_AND_PRINT_EMBEDDING = 0x0004;

    [NativeTypeName("#define FT_FSTYPE_EDITABLE_EMBEDDING 0x0008")]
    public const int FT_FSTYPE_EDITABLE_EMBEDDING = 0x0008;

    [NativeTypeName("#define FT_FSTYPE_NO_SUBSETTING 0x0100")]
    public const int FT_FSTYPE_NO_SUBSETTING = 0x0100;

    [NativeTypeName("#define FT_FSTYPE_BITMAP_EMBEDDING_ONLY 0x0200")]
    public const int FT_FSTYPE_BITMAP_EMBEDDING_ONLY = 0x0200;

    [NativeTypeName("#define FREETYPE_MAJOR 2")]
    public const int FREETYPE_MAJOR = 2;

    [NativeTypeName("#define FREETYPE_MINOR 14")]
    public const int FREETYPE_MINOR = 14;

    [NativeTypeName("#define FREETYPE_PATCH 3")]
    public const int FREETYPE_PATCH = 3;

    [NativeTypeName("#define FT_ADVANCE_FLAG_FAST_ONLY 0x20000000L")]
    public const nint FT_ADVANCE_FLAG_FAST_ONLY = 0x20000000;

    [NativeTypeName("#define FT_PALETTE_FOR_LIGHT_BACKGROUND 0x01")]
    public const int FT_PALETTE_FOR_LIGHT_BACKGROUND = 0x01;

    [NativeTypeName("#define FT_PALETTE_FOR_DARK_BACKGROUND 0x02")]
    public const int FT_PALETTE_FOR_DARK_BACKGROUND = 0x02;

    [NativeTypeName("#define ft_glyph_bbox_unscaled FT_GLYPH_BBOX_UNSCALED")]
    public const FT_Glyph_BBox_Mode ft_glyph_bbox_unscaled = FT_Glyph_BBox_Mode.UNSCALED;

    [NativeTypeName("#define ft_glyph_bbox_subpixels FT_GLYPH_BBOX_SUBPIXELS")]
    public const FT_Glyph_BBox_Mode ft_glyph_bbox_subpixels = FT_Glyph_BBox_Mode.SUBPIXELS;

    [NativeTypeName("#define ft_glyph_bbox_gridfit FT_GLYPH_BBOX_GRIDFIT")]
    public const FT_Glyph_BBox_Mode ft_glyph_bbox_gridfit = FT_Glyph_BBox_Mode.GRIDFIT;

    [NativeTypeName("#define ft_glyph_bbox_truncate FT_GLYPH_BBOX_TRUNCATE")]
    public const FT_Glyph_BBox_Mode ft_glyph_bbox_truncate = FT_Glyph_BBox_Mode.TRUNCATE;

    [NativeTypeName("#define ft_glyph_bbox_pixels FT_GLYPH_BBOX_PIXELS")]
    public const FT_Glyph_BBox_Mode ft_glyph_bbox_pixels = FT_Glyph_BBox_Mode.PIXELS;

    [NativeTypeName("#define FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_FAMILY FT_MAKE_TAG( 'i', 'g', 'p', 'f' )")]
    public const uint FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_FAMILY = (((uint)((byte)('i')) << 24) | ((uint)((byte)('g')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('f')));

    [NativeTypeName("#define FT_PARAM_TAG_IGNORE_PREFERRED_FAMILY FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_FAMILY")]
    public const uint FT_PARAM_TAG_IGNORE_PREFERRED_FAMILY = (((uint)((byte)('i')) << 24) | ((uint)((byte)('g')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('f')));

    [NativeTypeName("#define FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_SUBFAMILY FT_MAKE_TAG( 'i', 'g', 'p', 's' )")]
    public const uint FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_SUBFAMILY = (((uint)((byte)('i')) << 24) | ((uint)((byte)('g')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('s')));

    [NativeTypeName("#define FT_PARAM_TAG_IGNORE_PREFERRED_SUBFAMILY FT_PARAM_TAG_IGNORE_TYPOGRAPHIC_SUBFAMILY")]
    public const uint FT_PARAM_TAG_IGNORE_PREFERRED_SUBFAMILY = (((uint)((byte)('i')) << 24) | ((uint)((byte)('g')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('s')));

    [NativeTypeName("#define FT_PARAM_TAG_INCREMENTAL FT_MAKE_TAG( 'i', 'n', 'c', 'r' )")]
    public const uint FT_PARAM_TAG_INCREMENTAL = (((uint)((byte)('i')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define FT_PARAM_TAG_IGNORE_SBIX FT_MAKE_TAG( 'i', 's', 'b', 'x' )")]
    public const uint FT_PARAM_TAG_IGNORE_SBIX = (((uint)((byte)('i')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('b')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define FT_PARAM_TAG_LCD_FILTER_WEIGHTS FT_MAKE_TAG( 'l', 'c', 'd', 'f' )")]
    public const uint FT_PARAM_TAG_LCD_FILTER_WEIGHTS = (((uint)((byte)('l')) << 24) | ((uint)((byte)('c')) << 16) | ((uint)((byte)('d')) << 8) | (uint)((byte)('f')));

    [NativeTypeName("#define FT_PARAM_TAG_RANDOM_SEED FT_MAKE_TAG( 's', 'e', 'e', 'd' )")]
    public const uint FT_PARAM_TAG_RANDOM_SEED = (((uint)((byte)('s')) << 24) | ((uint)((byte)('e')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('d')));

    [NativeTypeName("#define FT_PARAM_TAG_STEM_DARKENING FT_MAKE_TAG( 'd', 'a', 'r', 'k' )")]
    public const uint FT_PARAM_TAG_STEM_DARKENING = (((uint)((byte)('d')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('k')));

    [NativeTypeName("#define FT_PARAM_TAG_UNPATENTED_HINTING FT_MAKE_TAG( 'u', 'n', 'p', 'a' )")]
    public const uint FT_PARAM_TAG_UNPATENTED_HINTING = (((uint)((byte)('u')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('a')));

    [NativeTypeName("#define FT_HINTING_FREETYPE 0")]
    public const int FT_HINTING_FREETYPE = 0;

    [NativeTypeName("#define FT_HINTING_ADOBE 1")]
    public const int FT_HINTING_ADOBE = 1;

    [NativeTypeName("#define FT_CFF_HINTING_FREETYPE FT_HINTING_FREETYPE")]
    public const int FT_CFF_HINTING_FREETYPE = 0;

    [NativeTypeName("#define FT_CFF_HINTING_ADOBE FT_HINTING_ADOBE")]
    public const int FT_CFF_HINTING_ADOBE = 1;

    [NativeTypeName("#define TT_INTERPRETER_VERSION_35 35")]
    public const int TT_INTERPRETER_VERSION_35 = 35;

    [NativeTypeName("#define TT_INTERPRETER_VERSION_38 38")]
    public const int TT_INTERPRETER_VERSION_38 = 38;

    [NativeTypeName("#define TT_INTERPRETER_VERSION_40 40")]
    public const int TT_INTERPRETER_VERSION_40 = 40;

    [NativeTypeName("#define FT_AUTOHINTER_SCRIPT_NONE 0")]
    public const int FT_AUTOHINTER_SCRIPT_NONE = 0;

    [NativeTypeName("#define FT_AUTOHINTER_SCRIPT_LATIN 1")]
    public const int FT_AUTOHINTER_SCRIPT_LATIN = 1;

    [NativeTypeName("#define FT_AUTOHINTER_SCRIPT_CJK 2")]
    public const int FT_AUTOHINTER_SCRIPT_CJK = 2;

    [NativeTypeName("#define FT_AUTOHINTER_SCRIPT_INDIC 3")]
    public const int FT_AUTOHINTER_SCRIPT_INDIC = 3;

    [NativeTypeName("#define FT_GASP_NO_TABLE -1")]
    public const int FT_GASP_NO_TABLE = -1;

    [NativeTypeName("#define FT_GASP_DO_GRIDFIT 0x01")]
    public const int FT_GASP_DO_GRIDFIT = 0x01;

    [NativeTypeName("#define FT_GASP_DO_GRAY 0x02")]
    public const int FT_GASP_DO_GRAY = 0x02;

    [NativeTypeName("#define FT_GASP_SYMMETRIC_GRIDFIT 0x04")]
    public const int FT_GASP_SYMMETRIC_GRIDFIT = 0x04;

    [NativeTypeName("#define FT_GASP_SYMMETRIC_SMOOTHING 0x08")]
    public const int FT_GASP_SYMMETRIC_SMOOTHING = 0x08;

    [NativeTypeName("#define FT_VALIDATE_feat_INDEX 0")]
    public const int FT_VALIDATE_feat_INDEX = 0;

    [NativeTypeName("#define FT_VALIDATE_mort_INDEX 1")]
    public const int FT_VALIDATE_mort_INDEX = 1;

    [NativeTypeName("#define FT_VALIDATE_morx_INDEX 2")]
    public const int FT_VALIDATE_morx_INDEX = 2;

    [NativeTypeName("#define FT_VALIDATE_bsln_INDEX 3")]
    public const int FT_VALIDATE_bsln_INDEX = 3;

    [NativeTypeName("#define FT_VALIDATE_just_INDEX 4")]
    public const int FT_VALIDATE_just_INDEX = 4;

    [NativeTypeName("#define FT_VALIDATE_kern_INDEX 5")]
    public const int FT_VALIDATE_kern_INDEX = 5;

    [NativeTypeName("#define FT_VALIDATE_opbd_INDEX 6")]
    public const int FT_VALIDATE_opbd_INDEX = 6;

    [NativeTypeName("#define FT_VALIDATE_trak_INDEX 7")]
    public const int FT_VALIDATE_trak_INDEX = 7;

    [NativeTypeName("#define FT_VALIDATE_prop_INDEX 8")]
    public const int FT_VALIDATE_prop_INDEX = 8;

    [NativeTypeName("#define FT_VALIDATE_lcar_INDEX 9")]
    public const int FT_VALIDATE_lcar_INDEX = 9;

    [NativeTypeName("#define FT_VALIDATE_GX_LAST_INDEX FT_VALIDATE_lcar_INDEX")]
    public const int FT_VALIDATE_GX_LAST_INDEX = 9;

    [NativeTypeName("#define FT_VALIDATE_GX_LENGTH ( FT_VALIDATE_GX_LAST_INDEX + 1 )")]
    public const int FT_VALIDATE_GX_LENGTH = (9 + 1);

    [NativeTypeName("#define FT_VALIDATE_GX_START 0x4000")]
    public const int FT_VALIDATE_GX_START = 0x4000;

    [NativeTypeName("#define FT_VALIDATE_feat FT_VALIDATE_GX_BITFIELD( feat )")]
    public const int FT_VALIDATE_feat = (0x4000 << 0);

    [NativeTypeName("#define FT_VALIDATE_mort FT_VALIDATE_GX_BITFIELD( mort )")]
    public const int FT_VALIDATE_mort = (0x4000 << 1);

    [NativeTypeName("#define FT_VALIDATE_morx FT_VALIDATE_GX_BITFIELD( morx )")]
    public const int FT_VALIDATE_morx = (0x4000 << 2);

    [NativeTypeName("#define FT_VALIDATE_bsln FT_VALIDATE_GX_BITFIELD( bsln )")]
    public const int FT_VALIDATE_bsln = (0x4000 << 3);

    [NativeTypeName("#define FT_VALIDATE_just FT_VALIDATE_GX_BITFIELD( just )")]
    public const int FT_VALIDATE_just = (0x4000 << 4);

    [NativeTypeName("#define FT_VALIDATE_kern FT_VALIDATE_GX_BITFIELD( kern )")]
    public const int FT_VALIDATE_kern = (0x4000 << 5);

    [NativeTypeName("#define FT_VALIDATE_opbd FT_VALIDATE_GX_BITFIELD( opbd )")]
    public const int FT_VALIDATE_opbd = (0x4000 << 6);

    [NativeTypeName("#define FT_VALIDATE_trak FT_VALIDATE_GX_BITFIELD( trak )")]
    public const int FT_VALIDATE_trak = (0x4000 << 7);

    [NativeTypeName("#define FT_VALIDATE_prop FT_VALIDATE_GX_BITFIELD( prop )")]
    public const int FT_VALIDATE_prop = (0x4000 << 8);

    [NativeTypeName("#define FT_VALIDATE_lcar FT_VALIDATE_GX_BITFIELD( lcar )")]
    public const int FT_VALIDATE_lcar = (0x4000 << 9);

    [NativeTypeName("#define FT_VALIDATE_GX ( FT_VALIDATE_feat | \\\n                          FT_VALIDATE_mort | \\\n                          FT_VALIDATE_morx | \\\n                          FT_VALIDATE_bsln | \\\n                          FT_VALIDATE_just | \\\n                          FT_VALIDATE_kern | \\\n                          FT_VALIDATE_opbd | \\\n                          FT_VALIDATE_trak | \\\n                          FT_VALIDATE_prop | \\\n                          FT_VALIDATE_lcar )")]
    public const int FT_VALIDATE_GX = ((0x4000 << 0) | (0x4000 << 1) | (0x4000 << 2) | (0x4000 << 3) | (0x4000 << 4) | (0x4000 << 5) | (0x4000 << 6) | (0x4000 << 7) | (0x4000 << 8) | (0x4000 << 9));

    [NativeTypeName("#define FT_VALIDATE_MS ( FT_VALIDATE_GX_START << 0 )")]
    public const int FT_VALIDATE_MS = (0x4000 << 0);

    [NativeTypeName("#define FT_VALIDATE_APPLE ( FT_VALIDATE_GX_START << 1 )")]
    public const int FT_VALIDATE_APPLE = (0x4000 << 1);

    [NativeTypeName("#define FT_VALIDATE_CKERN ( FT_VALIDATE_MS | FT_VALIDATE_APPLE )")]
    public const int FT_VALIDATE_CKERN = ((0x4000 << 0) | (0x4000 << 1));

    [NativeTypeName("#define FT_LCD_FILTER_FIVE_TAPS 5")]
    public const int FT_LCD_FILTER_FIVE_TAPS = 5;

    [NativeTypeName("#define T1_MAX_MM_AXIS 4")]
    public const int T1_MAX_MM_AXIS = 4;

    [NativeTypeName("#define T1_MAX_MM_DESIGNS 16")]
    public const int T1_MAX_MM_DESIGNS = 16;

    [NativeTypeName("#define T1_MAX_MM_MAP_POINTS 20")]
    public const int T1_MAX_MM_MAP_POINTS = 20;

    [NativeTypeName("#define FT_VAR_AXIS_FLAG_HIDDEN 1")]
    public const int FT_VAR_AXIS_FLAG_HIDDEN = 1;

    [NativeTypeName("#define FT_MODULE_FONT_DRIVER 1")]
    public const int FT_MODULE_FONT_DRIVER = 1;

    [NativeTypeName("#define FT_MODULE_RENDERER 2")]
    public const int FT_MODULE_RENDERER = 2;

    [NativeTypeName("#define FT_MODULE_HINTER 4")]
    public const int FT_MODULE_HINTER = 4;

    [NativeTypeName("#define FT_MODULE_STYLER 8")]
    public const int FT_MODULE_STYLER = 8;

    [NativeTypeName("#define FT_MODULE_DRIVER_SCALABLE 0x100")]
    public const int FT_MODULE_DRIVER_SCALABLE = 0x100;

    [NativeTypeName("#define FT_MODULE_DRIVER_NO_OUTLINES 0x200")]
    public const int FT_MODULE_DRIVER_NO_OUTLINES = 0x200;

    [NativeTypeName("#define FT_MODULE_DRIVER_HAS_HINTER 0x400")]
    public const int FT_MODULE_DRIVER_HAS_HINTER = 0x400;

    [NativeTypeName("#define FT_MODULE_DRIVER_HINTS_LIGHTLY 0x800")]
    public const int FT_MODULE_DRIVER_HINTS_LIGHTLY = 0x800;

    [NativeTypeName("#define ft_module_font_driver FT_MODULE_FONT_DRIVER")]
    public const int ft_module_font_driver = 1;

    [NativeTypeName("#define ft_module_renderer FT_MODULE_RENDERER")]
    public const int ft_module_renderer = 2;

    [NativeTypeName("#define ft_module_hinter FT_MODULE_HINTER")]
    public const int ft_module_hinter = 4;

    [NativeTypeName("#define ft_module_styler FT_MODULE_STYLER")]
    public const int ft_module_styler = 8;

    [NativeTypeName("#define ft_module_driver_scalable FT_MODULE_DRIVER_SCALABLE")]
    public const int ft_module_driver_scalable = 0x100;

    [NativeTypeName("#define ft_module_driver_no_outlines FT_MODULE_DRIVER_NO_OUTLINES")]
    public const int ft_module_driver_no_outlines = 0x200;

    [NativeTypeName("#define ft_module_driver_has_hinter FT_MODULE_DRIVER_HAS_HINTER")]
    public const int ft_module_driver_has_hinter = 0x400;

    [NativeTypeName("#define ft_module_driver_hints_lightly FT_MODULE_DRIVER_HINTS_LIGHTLY")]
    public const int ft_module_driver_hints_lightly = 0x800;

    [NativeTypeName("#define FT_DEBUG_HOOK_TRUETYPE 0")]
    public const int FT_DEBUG_HOOK_TRUETYPE = 0;

    [NativeTypeName("#define FT_VALIDATE_BASE 0x0100")]
    public const int FT_VALIDATE_BASE = 0x0100;

    [NativeTypeName("#define FT_VALIDATE_GDEF 0x0200")]
    public const int FT_VALIDATE_GDEF = 0x0200;

    [NativeTypeName("#define FT_VALIDATE_GPOS 0x0400")]
    public const int FT_VALIDATE_GPOS = 0x0400;

    [NativeTypeName("#define FT_VALIDATE_GSUB 0x0800")]
    public const int FT_VALIDATE_GSUB = 0x0800;

    [NativeTypeName("#define FT_VALIDATE_JSTF 0x1000")]
    public const int FT_VALIDATE_JSTF = 0x1000;

    [NativeTypeName("#define FT_VALIDATE_MATH 0x2000")]
    public const int FT_VALIDATE_MATH = 0x2000;

    [NativeTypeName("#define FT_VALIDATE_OT ( FT_VALIDATE_BASE | \\\n                          FT_VALIDATE_GDEF | \\\n                          FT_VALIDATE_GPOS | \\\n                          FT_VALIDATE_GSUB | \\\n                          FT_VALIDATE_JSTF | \\\n                          FT_VALIDATE_MATH )")]
    public const int FT_VALIDATE_OT = (0x0100 | 0x0200 | 0x0400 | 0x0800 | 0x1000 | 0x2000);

    [NativeTypeName("#define FT_ANGLE_PI ( 180L << 16 )")]
    public const nint FT_ANGLE_PI = (180 << 16);

    [NativeTypeName("#define FT_ANGLE_2PI ( FT_ANGLE_PI * 2 )")]
    public const nint FT_ANGLE_2PI = ((180 << 16) * 2);

    [NativeTypeName("#define FT_ANGLE_PI2 ( FT_ANGLE_PI / 2 )")]
    public const nint FT_ANGLE_PI2 = ((180 << 16) / 2);

    [NativeTypeName("#define FT_ANGLE_PI4 ( FT_ANGLE_PI / 4 )")]
    public const nint FT_ANGLE_PI4 = ((180 << 16) / 4);

    [NativeTypeName("#define FT_WinFNT_ID_CP1252 0")]
    public const int FT_WinFNT_ID_CP1252 = 0;

    [NativeTypeName("#define FT_WinFNT_ID_DEFAULT 1")]
    public const int FT_WinFNT_ID_DEFAULT = 1;

    [NativeTypeName("#define FT_WinFNT_ID_SYMBOL 2")]
    public const int FT_WinFNT_ID_SYMBOL = 2;

    [NativeTypeName("#define FT_WinFNT_ID_MAC 77")]
    public const int FT_WinFNT_ID_MAC = 77;

    [NativeTypeName("#define FT_WinFNT_ID_CP932 128")]
    public const int FT_WinFNT_ID_CP932 = 128;

    [NativeTypeName("#define FT_WinFNT_ID_CP949 129")]
    public const int FT_WinFNT_ID_CP949 = 129;

    [NativeTypeName("#define FT_WinFNT_ID_CP1361 130")]
    public const int FT_WinFNT_ID_CP1361 = 130;

    [NativeTypeName("#define FT_WinFNT_ID_CP936 134")]
    public const int FT_WinFNT_ID_CP936 = 134;

    [NativeTypeName("#define FT_WinFNT_ID_CP950 136")]
    public const int FT_WinFNT_ID_CP950 = 136;

    [NativeTypeName("#define FT_WinFNT_ID_CP1253 161")]
    public const int FT_WinFNT_ID_CP1253 = 161;

    [NativeTypeName("#define FT_WinFNT_ID_CP1254 162")]
    public const int FT_WinFNT_ID_CP1254 = 162;

    [NativeTypeName("#define FT_WinFNT_ID_CP1258 163")]
    public const int FT_WinFNT_ID_CP1258 = 163;

    [NativeTypeName("#define FT_WinFNT_ID_CP1255 177")]
    public const int FT_WinFNT_ID_CP1255 = 177;

    [NativeTypeName("#define FT_WinFNT_ID_CP1256 178")]
    public const int FT_WinFNT_ID_CP1256 = 178;

    [NativeTypeName("#define FT_WinFNT_ID_CP1257 186")]
    public const int FT_WinFNT_ID_CP1257 = 186;

    [NativeTypeName("#define FT_WinFNT_ID_CP1251 204")]
    public const int FT_WinFNT_ID_CP1251 = 204;

    [NativeTypeName("#define FT_WinFNT_ID_CP874 222")]
    public const int FT_WinFNT_ID_CP874 = 222;

    [NativeTypeName("#define FT_WinFNT_ID_CP1250 238")]
    public const int FT_WinFNT_ID_CP1250 = 238;

    [NativeTypeName("#define FT_WinFNT_ID_OEM 255")]
    public const int FT_WinFNT_ID_OEM = 255;

    [NativeTypeName("#define t1_blend_underline_position T1_BLEND_UNDERLINE_POSITION")]
    public const T1_Blend_Flags t1_blend_underline_position = T1_BLEND_UNDERLINE_POSITION;

    [NativeTypeName("#define t1_blend_underline_thickness T1_BLEND_UNDERLINE_THICKNESS")]
    public const T1_Blend_Flags t1_blend_underline_thickness = T1_BLEND_UNDERLINE_THICKNESS;

    [NativeTypeName("#define t1_blend_italic_angle T1_BLEND_ITALIC_ANGLE")]
    public const T1_Blend_Flags t1_blend_italic_angle = T1_BLEND_ITALIC_ANGLE;

    [NativeTypeName("#define t1_blend_blue_values T1_BLEND_BLUE_VALUES")]
    public const T1_Blend_Flags t1_blend_blue_values = T1_BLEND_BLUE_VALUES;

    [NativeTypeName("#define t1_blend_other_blues T1_BLEND_OTHER_BLUES")]
    public const T1_Blend_Flags t1_blend_other_blues = T1_BLEND_OTHER_BLUES;

    [NativeTypeName("#define t1_blend_standard_widths T1_BLEND_STANDARD_WIDTH")]
    public const T1_Blend_Flags t1_blend_standard_widths = T1_BLEND_STANDARD_WIDTH;

    [NativeTypeName("#define t1_blend_standard_height T1_BLEND_STANDARD_HEIGHT")]
    public const T1_Blend_Flags t1_blend_standard_height = T1_BLEND_STANDARD_HEIGHT;

    [NativeTypeName("#define t1_blend_stem_snap_widths T1_BLEND_STEM_SNAP_WIDTHS")]
    public const T1_Blend_Flags t1_blend_stem_snap_widths = T1_BLEND_STEM_SNAP_WIDTHS;

    [NativeTypeName("#define t1_blend_stem_snap_heights T1_BLEND_STEM_SNAP_HEIGHTS")]
    public const T1_Blend_Flags t1_blend_stem_snap_heights = T1_BLEND_STEM_SNAP_HEIGHTS;

    [NativeTypeName("#define t1_blend_blue_scale T1_BLEND_BLUE_SCALE")]
    public const T1_Blend_Flags t1_blend_blue_scale = T1_BLEND_BLUE_SCALE;

    [NativeTypeName("#define t1_blend_blue_shift T1_BLEND_BLUE_SHIFT")]
    public const T1_Blend_Flags t1_blend_blue_shift = T1_BLEND_BLUE_SHIFT;

    [NativeTypeName("#define t1_blend_family_blues T1_BLEND_FAMILY_BLUES")]
    public const T1_Blend_Flags t1_blend_family_blues = T1_BLEND_FAMILY_BLUES;

    [NativeTypeName("#define t1_blend_family_other_blues T1_BLEND_FAMILY_OTHER_BLUES")]
    public const T1_Blend_Flags t1_blend_family_other_blues = T1_BLEND_FAMILY_OTHER_BLUES;

    [NativeTypeName("#define t1_blend_force_bold T1_BLEND_FORCE_BOLD")]
    public const T1_Blend_Flags t1_blend_force_bold = T1_BLEND_FORCE_BOLD;

    [NativeTypeName("#define t1_blend_max T1_BLEND_MAX")]
    public const T1_Blend_Flags t1_blend_max = T1_BLEND_MAX;

    [NativeTypeName("#define TT_PLATFORM_APPLE_UNICODE 0")]
    public const int TT_PLATFORM_APPLE_UNICODE = 0;

    [NativeTypeName("#define TT_PLATFORM_MACINTOSH 1")]
    public const int TT_PLATFORM_MACINTOSH = 1;

    [NativeTypeName("#define TT_PLATFORM_ISO 2")]
    public const int TT_PLATFORM_ISO = 2;

    [NativeTypeName("#define TT_PLATFORM_MICROSOFT 3")]
    public const int TT_PLATFORM_MICROSOFT = 3;

    [NativeTypeName("#define TT_PLATFORM_CUSTOM 4")]
    public const int TT_PLATFORM_CUSTOM = 4;

    [NativeTypeName("#define TT_PLATFORM_ADOBE 7")]
    public const int TT_PLATFORM_ADOBE = 7;

    [NativeTypeName("#define TT_APPLE_ID_DEFAULT 0")]
    public const int TT_APPLE_ID_DEFAULT = 0;

    [NativeTypeName("#define TT_APPLE_ID_UNICODE_1_1 1")]
    public const int TT_APPLE_ID_UNICODE_1_1 = 1;

    [NativeTypeName("#define TT_APPLE_ID_ISO_10646 2")]
    public const int TT_APPLE_ID_ISO_10646 = 2;

    [NativeTypeName("#define TT_APPLE_ID_UNICODE_2_0 3")]
    public const int TT_APPLE_ID_UNICODE_2_0 = 3;

    [NativeTypeName("#define TT_APPLE_ID_UNICODE_32 4")]
    public const int TT_APPLE_ID_UNICODE_32 = 4;

    [NativeTypeName("#define TT_APPLE_ID_VARIANT_SELECTOR 5")]
    public const int TT_APPLE_ID_VARIANT_SELECTOR = 5;

    [NativeTypeName("#define TT_APPLE_ID_FULL_UNICODE 6")]
    public const int TT_APPLE_ID_FULL_UNICODE = 6;

    [NativeTypeName("#define TT_MAC_ID_ROMAN 0")]
    public const int TT_MAC_ID_ROMAN = 0;

    [NativeTypeName("#define TT_MAC_ID_JAPANESE 1")]
    public const int TT_MAC_ID_JAPANESE = 1;

    [NativeTypeName("#define TT_MAC_ID_TRADITIONAL_CHINESE 2")]
    public const int TT_MAC_ID_TRADITIONAL_CHINESE = 2;

    [NativeTypeName("#define TT_MAC_ID_KOREAN 3")]
    public const int TT_MAC_ID_KOREAN = 3;

    [NativeTypeName("#define TT_MAC_ID_ARABIC 4")]
    public const int TT_MAC_ID_ARABIC = 4;

    [NativeTypeName("#define TT_MAC_ID_HEBREW 5")]
    public const int TT_MAC_ID_HEBREW = 5;

    [NativeTypeName("#define TT_MAC_ID_GREEK 6")]
    public const int TT_MAC_ID_GREEK = 6;

    [NativeTypeName("#define TT_MAC_ID_RUSSIAN 7")]
    public const int TT_MAC_ID_RUSSIAN = 7;

    [NativeTypeName("#define TT_MAC_ID_RSYMBOL 8")]
    public const int TT_MAC_ID_RSYMBOL = 8;

    [NativeTypeName("#define TT_MAC_ID_DEVANAGARI 9")]
    public const int TT_MAC_ID_DEVANAGARI = 9;

    [NativeTypeName("#define TT_MAC_ID_GURMUKHI 10")]
    public const int TT_MAC_ID_GURMUKHI = 10;

    [NativeTypeName("#define TT_MAC_ID_GUJARATI 11")]
    public const int TT_MAC_ID_GUJARATI = 11;

    [NativeTypeName("#define TT_MAC_ID_ORIYA 12")]
    public const int TT_MAC_ID_ORIYA = 12;

    [NativeTypeName("#define TT_MAC_ID_BENGALI 13")]
    public const int TT_MAC_ID_BENGALI = 13;

    [NativeTypeName("#define TT_MAC_ID_TAMIL 14")]
    public const int TT_MAC_ID_TAMIL = 14;

    [NativeTypeName("#define TT_MAC_ID_TELUGU 15")]
    public const int TT_MAC_ID_TELUGU = 15;

    [NativeTypeName("#define TT_MAC_ID_KANNADA 16")]
    public const int TT_MAC_ID_KANNADA = 16;

    [NativeTypeName("#define TT_MAC_ID_MALAYALAM 17")]
    public const int TT_MAC_ID_MALAYALAM = 17;

    [NativeTypeName("#define TT_MAC_ID_SINHALESE 18")]
    public const int TT_MAC_ID_SINHALESE = 18;

    [NativeTypeName("#define TT_MAC_ID_BURMESE 19")]
    public const int TT_MAC_ID_BURMESE = 19;

    [NativeTypeName("#define TT_MAC_ID_KHMER 20")]
    public const int TT_MAC_ID_KHMER = 20;

    [NativeTypeName("#define TT_MAC_ID_THAI 21")]
    public const int TT_MAC_ID_THAI = 21;

    [NativeTypeName("#define TT_MAC_ID_LAOTIAN 22")]
    public const int TT_MAC_ID_LAOTIAN = 22;

    [NativeTypeName("#define TT_MAC_ID_GEORGIAN 23")]
    public const int TT_MAC_ID_GEORGIAN = 23;

    [NativeTypeName("#define TT_MAC_ID_ARMENIAN 24")]
    public const int TT_MAC_ID_ARMENIAN = 24;

    [NativeTypeName("#define TT_MAC_ID_MALDIVIAN 25")]
    public const int TT_MAC_ID_MALDIVIAN = 25;

    [NativeTypeName("#define TT_MAC_ID_SIMPLIFIED_CHINESE 25")]
    public const int TT_MAC_ID_SIMPLIFIED_CHINESE = 25;

    [NativeTypeName("#define TT_MAC_ID_TIBETAN 26")]
    public const int TT_MAC_ID_TIBETAN = 26;

    [NativeTypeName("#define TT_MAC_ID_MONGOLIAN 27")]
    public const int TT_MAC_ID_MONGOLIAN = 27;

    [NativeTypeName("#define TT_MAC_ID_GEEZ 28")]
    public const int TT_MAC_ID_GEEZ = 28;

    [NativeTypeName("#define TT_MAC_ID_SLAVIC 29")]
    public const int TT_MAC_ID_SLAVIC = 29;

    [NativeTypeName("#define TT_MAC_ID_VIETNAMESE 30")]
    public const int TT_MAC_ID_VIETNAMESE = 30;

    [NativeTypeName("#define TT_MAC_ID_SINDHI 31")]
    public const int TT_MAC_ID_SINDHI = 31;

    [NativeTypeName("#define TT_MAC_ID_UNINTERP 32")]
    public const int TT_MAC_ID_UNINTERP = 32;

    [NativeTypeName("#define TT_ISO_ID_7BIT_ASCII 0")]
    public const int TT_ISO_ID_7BIT_ASCII = 0;

    [NativeTypeName("#define TT_ISO_ID_10646 1")]
    public const int TT_ISO_ID_10646 = 1;

    [NativeTypeName("#define TT_ISO_ID_8859_1 2")]
    public const int TT_ISO_ID_8859_1 = 2;

    [NativeTypeName("#define TT_MS_ID_SYMBOL_CS 0")]
    public const int TT_MS_ID_SYMBOL_CS = 0;

    [NativeTypeName("#define TT_MS_ID_UNICODE_CS 1")]
    public const int TT_MS_ID_UNICODE_CS = 1;

    [NativeTypeName("#define TT_MS_ID_SJIS 2")]
    public const int TT_MS_ID_SJIS = 2;

    [NativeTypeName("#define TT_MS_ID_PRC 3")]
    public const int TT_MS_ID_PRC = 3;

    [NativeTypeName("#define TT_MS_ID_BIG_5 4")]
    public const int TT_MS_ID_BIG_5 = 4;

    [NativeTypeName("#define TT_MS_ID_WANSUNG 5")]
    public const int TT_MS_ID_WANSUNG = 5;

    [NativeTypeName("#define TT_MS_ID_JOHAB 6")]
    public const int TT_MS_ID_JOHAB = 6;

    [NativeTypeName("#define TT_MS_ID_UCS_4 10")]
    public const int TT_MS_ID_UCS_4 = 10;

    [NativeTypeName("#define TT_MS_ID_GB2312 TT_MS_ID_PRC")]
    public const int TT_MS_ID_GB2312 = 3;

    [NativeTypeName("#define TT_ADOBE_ID_STANDARD 0")]
    public const int TT_ADOBE_ID_STANDARD = 0;

    [NativeTypeName("#define TT_ADOBE_ID_EXPERT 1")]
    public const int TT_ADOBE_ID_EXPERT = 1;

    [NativeTypeName("#define TT_ADOBE_ID_CUSTOM 2")]
    public const int TT_ADOBE_ID_CUSTOM = 2;

    [NativeTypeName("#define TT_ADOBE_ID_LATIN_1 3")]
    public const int TT_ADOBE_ID_LATIN_1 = 3;

    [NativeTypeName("#define TT_MAC_LANGID_ENGLISH 0")]
    public const int TT_MAC_LANGID_ENGLISH = 0;

    [NativeTypeName("#define TT_MAC_LANGID_FRENCH 1")]
    public const int TT_MAC_LANGID_FRENCH = 1;

    [NativeTypeName("#define TT_MAC_LANGID_GERMAN 2")]
    public const int TT_MAC_LANGID_GERMAN = 2;

    [NativeTypeName("#define TT_MAC_LANGID_ITALIAN 3")]
    public const int TT_MAC_LANGID_ITALIAN = 3;

    [NativeTypeName("#define TT_MAC_LANGID_DUTCH 4")]
    public const int TT_MAC_LANGID_DUTCH = 4;

    [NativeTypeName("#define TT_MAC_LANGID_SWEDISH 5")]
    public const int TT_MAC_LANGID_SWEDISH = 5;

    [NativeTypeName("#define TT_MAC_LANGID_SPANISH 6")]
    public const int TT_MAC_LANGID_SPANISH = 6;

    [NativeTypeName("#define TT_MAC_LANGID_DANISH 7")]
    public const int TT_MAC_LANGID_DANISH = 7;

    [NativeTypeName("#define TT_MAC_LANGID_PORTUGUESE 8")]
    public const int TT_MAC_LANGID_PORTUGUESE = 8;

    [NativeTypeName("#define TT_MAC_LANGID_NORWEGIAN 9")]
    public const int TT_MAC_LANGID_NORWEGIAN = 9;

    [NativeTypeName("#define TT_MAC_LANGID_HEBREW 10")]
    public const int TT_MAC_LANGID_HEBREW = 10;

    [NativeTypeName("#define TT_MAC_LANGID_JAPANESE 11")]
    public const int TT_MAC_LANGID_JAPANESE = 11;

    [NativeTypeName("#define TT_MAC_LANGID_ARABIC 12")]
    public const int TT_MAC_LANGID_ARABIC = 12;

    [NativeTypeName("#define TT_MAC_LANGID_FINNISH 13")]
    public const int TT_MAC_LANGID_FINNISH = 13;

    [NativeTypeName("#define TT_MAC_LANGID_GREEK 14")]
    public const int TT_MAC_LANGID_GREEK = 14;

    [NativeTypeName("#define TT_MAC_LANGID_ICELANDIC 15")]
    public const int TT_MAC_LANGID_ICELANDIC = 15;

    [NativeTypeName("#define TT_MAC_LANGID_MALTESE 16")]
    public const int TT_MAC_LANGID_MALTESE = 16;

    [NativeTypeName("#define TT_MAC_LANGID_TURKISH 17")]
    public const int TT_MAC_LANGID_TURKISH = 17;

    [NativeTypeName("#define TT_MAC_LANGID_CROATIAN 18")]
    public const int TT_MAC_LANGID_CROATIAN = 18;

    [NativeTypeName("#define TT_MAC_LANGID_CHINESE_TRADITIONAL 19")]
    public const int TT_MAC_LANGID_CHINESE_TRADITIONAL = 19;

    [NativeTypeName("#define TT_MAC_LANGID_URDU 20")]
    public const int TT_MAC_LANGID_URDU = 20;

    [NativeTypeName("#define TT_MAC_LANGID_HINDI 21")]
    public const int TT_MAC_LANGID_HINDI = 21;

    [NativeTypeName("#define TT_MAC_LANGID_THAI 22")]
    public const int TT_MAC_LANGID_THAI = 22;

    [NativeTypeName("#define TT_MAC_LANGID_KOREAN 23")]
    public const int TT_MAC_LANGID_KOREAN = 23;

    [NativeTypeName("#define TT_MAC_LANGID_LITHUANIAN 24")]
    public const int TT_MAC_LANGID_LITHUANIAN = 24;

    [NativeTypeName("#define TT_MAC_LANGID_POLISH 25")]
    public const int TT_MAC_LANGID_POLISH = 25;

    [NativeTypeName("#define TT_MAC_LANGID_HUNGARIAN 26")]
    public const int TT_MAC_LANGID_HUNGARIAN = 26;

    [NativeTypeName("#define TT_MAC_LANGID_ESTONIAN 27")]
    public const int TT_MAC_LANGID_ESTONIAN = 27;

    [NativeTypeName("#define TT_MAC_LANGID_LETTISH 28")]
    public const int TT_MAC_LANGID_LETTISH = 28;

    [NativeTypeName("#define TT_MAC_LANGID_SAAMISK 29")]
    public const int TT_MAC_LANGID_SAAMISK = 29;

    [NativeTypeName("#define TT_MAC_LANGID_FAEROESE 30")]
    public const int TT_MAC_LANGID_FAEROESE = 30;

    [NativeTypeName("#define TT_MAC_LANGID_FARSI 31")]
    public const int TT_MAC_LANGID_FARSI = 31;

    [NativeTypeName("#define TT_MAC_LANGID_RUSSIAN 32")]
    public const int TT_MAC_LANGID_RUSSIAN = 32;

    [NativeTypeName("#define TT_MAC_LANGID_CHINESE_SIMPLIFIED 33")]
    public const int TT_MAC_LANGID_CHINESE_SIMPLIFIED = 33;

    [NativeTypeName("#define TT_MAC_LANGID_FLEMISH 34")]
    public const int TT_MAC_LANGID_FLEMISH = 34;

    [NativeTypeName("#define TT_MAC_LANGID_IRISH 35")]
    public const int TT_MAC_LANGID_IRISH = 35;

    [NativeTypeName("#define TT_MAC_LANGID_ALBANIAN 36")]
    public const int TT_MAC_LANGID_ALBANIAN = 36;

    [NativeTypeName("#define TT_MAC_LANGID_ROMANIAN 37")]
    public const int TT_MAC_LANGID_ROMANIAN = 37;

    [NativeTypeName("#define TT_MAC_LANGID_CZECH 38")]
    public const int TT_MAC_LANGID_CZECH = 38;

    [NativeTypeName("#define TT_MAC_LANGID_SLOVAK 39")]
    public const int TT_MAC_LANGID_SLOVAK = 39;

    [NativeTypeName("#define TT_MAC_LANGID_SLOVENIAN 40")]
    public const int TT_MAC_LANGID_SLOVENIAN = 40;

    [NativeTypeName("#define TT_MAC_LANGID_YIDDISH 41")]
    public const int TT_MAC_LANGID_YIDDISH = 41;

    [NativeTypeName("#define TT_MAC_LANGID_SERBIAN 42")]
    public const int TT_MAC_LANGID_SERBIAN = 42;

    [NativeTypeName("#define TT_MAC_LANGID_MACEDONIAN 43")]
    public const int TT_MAC_LANGID_MACEDONIAN = 43;

    [NativeTypeName("#define TT_MAC_LANGID_BULGARIAN 44")]
    public const int TT_MAC_LANGID_BULGARIAN = 44;

    [NativeTypeName("#define TT_MAC_LANGID_UKRAINIAN 45")]
    public const int TT_MAC_LANGID_UKRAINIAN = 45;

    [NativeTypeName("#define TT_MAC_LANGID_BYELORUSSIAN 46")]
    public const int TT_MAC_LANGID_BYELORUSSIAN = 46;

    [NativeTypeName("#define TT_MAC_LANGID_UZBEK 47")]
    public const int TT_MAC_LANGID_UZBEK = 47;

    [NativeTypeName("#define TT_MAC_LANGID_KAZAKH 48")]
    public const int TT_MAC_LANGID_KAZAKH = 48;

    [NativeTypeName("#define TT_MAC_LANGID_AZERBAIJANI 49")]
    public const int TT_MAC_LANGID_AZERBAIJANI = 49;

    [NativeTypeName("#define TT_MAC_LANGID_AZERBAIJANI_CYRILLIC_SCRIPT 49")]
    public const int TT_MAC_LANGID_AZERBAIJANI_CYRILLIC_SCRIPT = 49;

    [NativeTypeName("#define TT_MAC_LANGID_AZERBAIJANI_ARABIC_SCRIPT 50")]
    public const int TT_MAC_LANGID_AZERBAIJANI_ARABIC_SCRIPT = 50;

    [NativeTypeName("#define TT_MAC_LANGID_ARMENIAN 51")]
    public const int TT_MAC_LANGID_ARMENIAN = 51;

    [NativeTypeName("#define TT_MAC_LANGID_GEORGIAN 52")]
    public const int TT_MAC_LANGID_GEORGIAN = 52;

    [NativeTypeName("#define TT_MAC_LANGID_MOLDAVIAN 53")]
    public const int TT_MAC_LANGID_MOLDAVIAN = 53;

    [NativeTypeName("#define TT_MAC_LANGID_KIRGHIZ 54")]
    public const int TT_MAC_LANGID_KIRGHIZ = 54;

    [NativeTypeName("#define TT_MAC_LANGID_TAJIKI 55")]
    public const int TT_MAC_LANGID_TAJIKI = 55;

    [NativeTypeName("#define TT_MAC_LANGID_TURKMEN 56")]
    public const int TT_MAC_LANGID_TURKMEN = 56;

    [NativeTypeName("#define TT_MAC_LANGID_MONGOLIAN 57")]
    public const int TT_MAC_LANGID_MONGOLIAN = 57;

    [NativeTypeName("#define TT_MAC_LANGID_MONGOLIAN_MONGOLIAN_SCRIPT 57")]
    public const int TT_MAC_LANGID_MONGOLIAN_MONGOLIAN_SCRIPT = 57;

    [NativeTypeName("#define TT_MAC_LANGID_MONGOLIAN_CYRILLIC_SCRIPT 58")]
    public const int TT_MAC_LANGID_MONGOLIAN_CYRILLIC_SCRIPT = 58;

    [NativeTypeName("#define TT_MAC_LANGID_PASHTO 59")]
    public const int TT_MAC_LANGID_PASHTO = 59;

    [NativeTypeName("#define TT_MAC_LANGID_KURDISH 60")]
    public const int TT_MAC_LANGID_KURDISH = 60;

    [NativeTypeName("#define TT_MAC_LANGID_KASHMIRI 61")]
    public const int TT_MAC_LANGID_KASHMIRI = 61;

    [NativeTypeName("#define TT_MAC_LANGID_SINDHI 62")]
    public const int TT_MAC_LANGID_SINDHI = 62;

    [NativeTypeName("#define TT_MAC_LANGID_TIBETAN 63")]
    public const int TT_MAC_LANGID_TIBETAN = 63;

    [NativeTypeName("#define TT_MAC_LANGID_NEPALI 64")]
    public const int TT_MAC_LANGID_NEPALI = 64;

    [NativeTypeName("#define TT_MAC_LANGID_SANSKRIT 65")]
    public const int TT_MAC_LANGID_SANSKRIT = 65;

    [NativeTypeName("#define TT_MAC_LANGID_MARATHI 66")]
    public const int TT_MAC_LANGID_MARATHI = 66;

    [NativeTypeName("#define TT_MAC_LANGID_BENGALI 67")]
    public const int TT_MAC_LANGID_BENGALI = 67;

    [NativeTypeName("#define TT_MAC_LANGID_ASSAMESE 68")]
    public const int TT_MAC_LANGID_ASSAMESE = 68;

    [NativeTypeName("#define TT_MAC_LANGID_GUJARATI 69")]
    public const int TT_MAC_LANGID_GUJARATI = 69;

    [NativeTypeName("#define TT_MAC_LANGID_PUNJABI 70")]
    public const int TT_MAC_LANGID_PUNJABI = 70;

    [NativeTypeName("#define TT_MAC_LANGID_ORIYA 71")]
    public const int TT_MAC_LANGID_ORIYA = 71;

    [NativeTypeName("#define TT_MAC_LANGID_MALAYALAM 72")]
    public const int TT_MAC_LANGID_MALAYALAM = 72;

    [NativeTypeName("#define TT_MAC_LANGID_KANNADA 73")]
    public const int TT_MAC_LANGID_KANNADA = 73;

    [NativeTypeName("#define TT_MAC_LANGID_TAMIL 74")]
    public const int TT_MAC_LANGID_TAMIL = 74;

    [NativeTypeName("#define TT_MAC_LANGID_TELUGU 75")]
    public const int TT_MAC_LANGID_TELUGU = 75;

    [NativeTypeName("#define TT_MAC_LANGID_SINHALESE 76")]
    public const int TT_MAC_LANGID_SINHALESE = 76;

    [NativeTypeName("#define TT_MAC_LANGID_BURMESE 77")]
    public const int TT_MAC_LANGID_BURMESE = 77;

    [NativeTypeName("#define TT_MAC_LANGID_KHMER 78")]
    public const int TT_MAC_LANGID_KHMER = 78;

    [NativeTypeName("#define TT_MAC_LANGID_LAO 79")]
    public const int TT_MAC_LANGID_LAO = 79;

    [NativeTypeName("#define TT_MAC_LANGID_VIETNAMESE 80")]
    public const int TT_MAC_LANGID_VIETNAMESE = 80;

    [NativeTypeName("#define TT_MAC_LANGID_INDONESIAN 81")]
    public const int TT_MAC_LANGID_INDONESIAN = 81;

    [NativeTypeName("#define TT_MAC_LANGID_TAGALOG 82")]
    public const int TT_MAC_LANGID_TAGALOG = 82;

    [NativeTypeName("#define TT_MAC_LANGID_MALAY_ROMAN_SCRIPT 83")]
    public const int TT_MAC_LANGID_MALAY_ROMAN_SCRIPT = 83;

    [NativeTypeName("#define TT_MAC_LANGID_MALAY_ARABIC_SCRIPT 84")]
    public const int TT_MAC_LANGID_MALAY_ARABIC_SCRIPT = 84;

    [NativeTypeName("#define TT_MAC_LANGID_AMHARIC 85")]
    public const int TT_MAC_LANGID_AMHARIC = 85;

    [NativeTypeName("#define TT_MAC_LANGID_TIGRINYA 86")]
    public const int TT_MAC_LANGID_TIGRINYA = 86;

    [NativeTypeName("#define TT_MAC_LANGID_GALLA 87")]
    public const int TT_MAC_LANGID_GALLA = 87;

    [NativeTypeName("#define TT_MAC_LANGID_SOMALI 88")]
    public const int TT_MAC_LANGID_SOMALI = 88;

    [NativeTypeName("#define TT_MAC_LANGID_SWAHILI 89")]
    public const int TT_MAC_LANGID_SWAHILI = 89;

    [NativeTypeName("#define TT_MAC_LANGID_RUANDA 90")]
    public const int TT_MAC_LANGID_RUANDA = 90;

    [NativeTypeName("#define TT_MAC_LANGID_RUNDI 91")]
    public const int TT_MAC_LANGID_RUNDI = 91;

    [NativeTypeName("#define TT_MAC_LANGID_CHEWA 92")]
    public const int TT_MAC_LANGID_CHEWA = 92;

    [NativeTypeName("#define TT_MAC_LANGID_MALAGASY 93")]
    public const int TT_MAC_LANGID_MALAGASY = 93;

    [NativeTypeName("#define TT_MAC_LANGID_ESPERANTO 94")]
    public const int TT_MAC_LANGID_ESPERANTO = 94;

    [NativeTypeName("#define TT_MAC_LANGID_WELSH 128")]
    public const int TT_MAC_LANGID_WELSH = 128;

    [NativeTypeName("#define TT_MAC_LANGID_BASQUE 129")]
    public const int TT_MAC_LANGID_BASQUE = 129;

    [NativeTypeName("#define TT_MAC_LANGID_CATALAN 130")]
    public const int TT_MAC_LANGID_CATALAN = 130;

    [NativeTypeName("#define TT_MAC_LANGID_LATIN 131")]
    public const int TT_MAC_LANGID_LATIN = 131;

    [NativeTypeName("#define TT_MAC_LANGID_QUECHUA 132")]
    public const int TT_MAC_LANGID_QUECHUA = 132;

    [NativeTypeName("#define TT_MAC_LANGID_GUARANI 133")]
    public const int TT_MAC_LANGID_GUARANI = 133;

    [NativeTypeName("#define TT_MAC_LANGID_AYMARA 134")]
    public const int TT_MAC_LANGID_AYMARA = 134;

    [NativeTypeName("#define TT_MAC_LANGID_TATAR 135")]
    public const int TT_MAC_LANGID_TATAR = 135;

    [NativeTypeName("#define TT_MAC_LANGID_UIGHUR 136")]
    public const int TT_MAC_LANGID_UIGHUR = 136;

    [NativeTypeName("#define TT_MAC_LANGID_DZONGKHA 137")]
    public const int TT_MAC_LANGID_DZONGKHA = 137;

    [NativeTypeName("#define TT_MAC_LANGID_JAVANESE 138")]
    public const int TT_MAC_LANGID_JAVANESE = 138;

    [NativeTypeName("#define TT_MAC_LANGID_SUNDANESE 139")]
    public const int TT_MAC_LANGID_SUNDANESE = 139;

    [NativeTypeName("#define TT_MAC_LANGID_GALICIAN 140")]
    public const int TT_MAC_LANGID_GALICIAN = 140;

    [NativeTypeName("#define TT_MAC_LANGID_AFRIKAANS 141")]
    public const int TT_MAC_LANGID_AFRIKAANS = 141;

    [NativeTypeName("#define TT_MAC_LANGID_BRETON 142")]
    public const int TT_MAC_LANGID_BRETON = 142;

    [NativeTypeName("#define TT_MAC_LANGID_INUKTITUT 143")]
    public const int TT_MAC_LANGID_INUKTITUT = 143;

    [NativeTypeName("#define TT_MAC_LANGID_SCOTTISH_GAELIC 144")]
    public const int TT_MAC_LANGID_SCOTTISH_GAELIC = 144;

    [NativeTypeName("#define TT_MAC_LANGID_MANX_GAELIC 145")]
    public const int TT_MAC_LANGID_MANX_GAELIC = 145;

    [NativeTypeName("#define TT_MAC_LANGID_IRISH_GAELIC 146")]
    public const int TT_MAC_LANGID_IRISH_GAELIC = 146;

    [NativeTypeName("#define TT_MAC_LANGID_TONGAN 147")]
    public const int TT_MAC_LANGID_TONGAN = 147;

    [NativeTypeName("#define TT_MAC_LANGID_GREEK_POLYTONIC 148")]
    public const int TT_MAC_LANGID_GREEK_POLYTONIC = 148;

    [NativeTypeName("#define TT_MAC_LANGID_GREELANDIC 149")]
    public const int TT_MAC_LANGID_GREELANDIC = 149;

    [NativeTypeName("#define TT_MAC_LANGID_AZERBAIJANI_ROMAN_SCRIPT 150")]
    public const int TT_MAC_LANGID_AZERBAIJANI_ROMAN_SCRIPT = 150;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_SAUDI_ARABIA 0x0401")]
    public const int TT_MS_LANGID_ARABIC_SAUDI_ARABIA = 0x0401;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_IRAQ 0x0801")]
    public const int TT_MS_LANGID_ARABIC_IRAQ = 0x0801;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_EGYPT 0x0C01")]
    public const int TT_MS_LANGID_ARABIC_EGYPT = 0x0C01;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_LIBYA 0x1001")]
    public const int TT_MS_LANGID_ARABIC_LIBYA = 0x1001;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_ALGERIA 0x1401")]
    public const int TT_MS_LANGID_ARABIC_ALGERIA = 0x1401;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_MOROCCO 0x1801")]
    public const int TT_MS_LANGID_ARABIC_MOROCCO = 0x1801;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_TUNISIA 0x1C01")]
    public const int TT_MS_LANGID_ARABIC_TUNISIA = 0x1C01;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_OMAN 0x2001")]
    public const int TT_MS_LANGID_ARABIC_OMAN = 0x2001;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_YEMEN 0x2401")]
    public const int TT_MS_LANGID_ARABIC_YEMEN = 0x2401;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_SYRIA 0x2801")]
    public const int TT_MS_LANGID_ARABIC_SYRIA = 0x2801;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_JORDAN 0x2C01")]
    public const int TT_MS_LANGID_ARABIC_JORDAN = 0x2C01;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_LEBANON 0x3001")]
    public const int TT_MS_LANGID_ARABIC_LEBANON = 0x3001;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_KUWAIT 0x3401")]
    public const int TT_MS_LANGID_ARABIC_KUWAIT = 0x3401;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_UAE 0x3801")]
    public const int TT_MS_LANGID_ARABIC_UAE = 0x3801;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_BAHRAIN 0x3C01")]
    public const int TT_MS_LANGID_ARABIC_BAHRAIN = 0x3C01;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_QATAR 0x4001")]
    public const int TT_MS_LANGID_ARABIC_QATAR = 0x4001;

    [NativeTypeName("#define TT_MS_LANGID_BULGARIAN_BULGARIA 0x0402")]
    public const int TT_MS_LANGID_BULGARIAN_BULGARIA = 0x0402;

    [NativeTypeName("#define TT_MS_LANGID_CATALAN_CATALAN 0x0403")]
    public const int TT_MS_LANGID_CATALAN_CATALAN = 0x0403;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_TAIWAN 0x0404")]
    public const int TT_MS_LANGID_CHINESE_TAIWAN = 0x0404;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_PRC 0x0804")]
    public const int TT_MS_LANGID_CHINESE_PRC = 0x0804;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_HONG_KONG 0x0C04")]
    public const int TT_MS_LANGID_CHINESE_HONG_KONG = 0x0C04;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_SINGAPORE 0x1004")]
    public const int TT_MS_LANGID_CHINESE_SINGAPORE = 0x1004;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_MACAO 0x1404")]
    public const int TT_MS_LANGID_CHINESE_MACAO = 0x1404;

    [NativeTypeName("#define TT_MS_LANGID_CZECH_CZECH_REPUBLIC 0x0405")]
    public const int TT_MS_LANGID_CZECH_CZECH_REPUBLIC = 0x0405;

    [NativeTypeName("#define TT_MS_LANGID_DANISH_DENMARK 0x0406")]
    public const int TT_MS_LANGID_DANISH_DENMARK = 0x0406;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_GERMANY 0x0407")]
    public const int TT_MS_LANGID_GERMAN_GERMANY = 0x0407;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_SWITZERLAND 0x0807")]
    public const int TT_MS_LANGID_GERMAN_SWITZERLAND = 0x0807;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_AUSTRIA 0x0C07")]
    public const int TT_MS_LANGID_GERMAN_AUSTRIA = 0x0C07;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_LUXEMBOURG 0x1007")]
    public const int TT_MS_LANGID_GERMAN_LUXEMBOURG = 0x1007;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_LIECHTENSTEIN 0x1407")]
    public const int TT_MS_LANGID_GERMAN_LIECHTENSTEIN = 0x1407;

    [NativeTypeName("#define TT_MS_LANGID_GREEK_GREECE 0x0408")]
    public const int TT_MS_LANGID_GREEK_GREECE = 0x0408;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_UNITED_STATES 0x0409")]
    public const int TT_MS_LANGID_ENGLISH_UNITED_STATES = 0x0409;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_UNITED_KINGDOM 0x0809")]
    public const int TT_MS_LANGID_ENGLISH_UNITED_KINGDOM = 0x0809;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_AUSTRALIA 0x0C09")]
    public const int TT_MS_LANGID_ENGLISH_AUSTRALIA = 0x0C09;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_CANADA 0x1009")]
    public const int TT_MS_LANGID_ENGLISH_CANADA = 0x1009;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_NEW_ZEALAND 0x1409")]
    public const int TT_MS_LANGID_ENGLISH_NEW_ZEALAND = 0x1409;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_IRELAND 0x1809")]
    public const int TT_MS_LANGID_ENGLISH_IRELAND = 0x1809;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_SOUTH_AFRICA 0x1C09")]
    public const int TT_MS_LANGID_ENGLISH_SOUTH_AFRICA = 0x1C09;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_JAMAICA 0x2009")]
    public const int TT_MS_LANGID_ENGLISH_JAMAICA = 0x2009;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_CARIBBEAN 0x2409")]
    public const int TT_MS_LANGID_ENGLISH_CARIBBEAN = 0x2409;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_BELIZE 0x2809")]
    public const int TT_MS_LANGID_ENGLISH_BELIZE = 0x2809;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_TRINIDAD 0x2C09")]
    public const int TT_MS_LANGID_ENGLISH_TRINIDAD = 0x2C09;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_ZIMBABWE 0x3009")]
    public const int TT_MS_LANGID_ENGLISH_ZIMBABWE = 0x3009;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_PHILIPPINES 0x3409")]
    public const int TT_MS_LANGID_ENGLISH_PHILIPPINES = 0x3409;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_INDIA 0x4009")]
    public const int TT_MS_LANGID_ENGLISH_INDIA = 0x4009;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_MALAYSIA 0x4409")]
    public const int TT_MS_LANGID_ENGLISH_MALAYSIA = 0x4409;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_SINGAPORE 0x4809")]
    public const int TT_MS_LANGID_ENGLISH_SINGAPORE = 0x4809;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_SPAIN_TRADITIONAL_SORT 0x040A")]
    public const int TT_MS_LANGID_SPANISH_SPAIN_TRADITIONAL_SORT = 0x040A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_MEXICO 0x080A")]
    public const int TT_MS_LANGID_SPANISH_MEXICO = 0x080A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_SPAIN_MODERN_SORT 0x0C0A")]
    public const int TT_MS_LANGID_SPANISH_SPAIN_MODERN_SORT = 0x0C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_GUATEMALA 0x100A")]
    public const int TT_MS_LANGID_SPANISH_GUATEMALA = 0x100A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_COSTA_RICA 0x140A")]
    public const int TT_MS_LANGID_SPANISH_COSTA_RICA = 0x140A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_PANAMA 0x180A")]
    public const int TT_MS_LANGID_SPANISH_PANAMA = 0x180A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_DOMINICAN_REPUBLIC 0x1C0A")]
    public const int TT_MS_LANGID_SPANISH_DOMINICAN_REPUBLIC = 0x1C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_VENEZUELA 0x200A")]
    public const int TT_MS_LANGID_SPANISH_VENEZUELA = 0x200A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_COLOMBIA 0x240A")]
    public const int TT_MS_LANGID_SPANISH_COLOMBIA = 0x240A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_PERU 0x280A")]
    public const int TT_MS_LANGID_SPANISH_PERU = 0x280A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_ARGENTINA 0x2C0A")]
    public const int TT_MS_LANGID_SPANISH_ARGENTINA = 0x2C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_ECUADOR 0x300A")]
    public const int TT_MS_LANGID_SPANISH_ECUADOR = 0x300A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_CHILE 0x340A")]
    public const int TT_MS_LANGID_SPANISH_CHILE = 0x340A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_URUGUAY 0x380A")]
    public const int TT_MS_LANGID_SPANISH_URUGUAY = 0x380A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_PARAGUAY 0x3C0A")]
    public const int TT_MS_LANGID_SPANISH_PARAGUAY = 0x3C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_BOLIVIA 0x400A")]
    public const int TT_MS_LANGID_SPANISH_BOLIVIA = 0x400A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_EL_SALVADOR 0x440A")]
    public const int TT_MS_LANGID_SPANISH_EL_SALVADOR = 0x440A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_HONDURAS 0x480A")]
    public const int TT_MS_LANGID_SPANISH_HONDURAS = 0x480A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_NICARAGUA 0x4C0A")]
    public const int TT_MS_LANGID_SPANISH_NICARAGUA = 0x4C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_PUERTO_RICO 0x500A")]
    public const int TT_MS_LANGID_SPANISH_PUERTO_RICO = 0x500A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_UNITED_STATES 0x540A")]
    public const int TT_MS_LANGID_SPANISH_UNITED_STATES = 0x540A;

    [NativeTypeName("#define TT_MS_LANGID_FINNISH_FINLAND 0x040B")]
    public const int TT_MS_LANGID_FINNISH_FINLAND = 0x040B;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_FRANCE 0x040C")]
    public const int TT_MS_LANGID_FRENCH_FRANCE = 0x040C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_BELGIUM 0x080C")]
    public const int TT_MS_LANGID_FRENCH_BELGIUM = 0x080C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_CANADA 0x0C0C")]
    public const int TT_MS_LANGID_FRENCH_CANADA = 0x0C0C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_SWITZERLAND 0x100C")]
    public const int TT_MS_LANGID_FRENCH_SWITZERLAND = 0x100C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_LUXEMBOURG 0x140C")]
    public const int TT_MS_LANGID_FRENCH_LUXEMBOURG = 0x140C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_MONACO 0x180C")]
    public const int TT_MS_LANGID_FRENCH_MONACO = 0x180C;

    [NativeTypeName("#define TT_MS_LANGID_HEBREW_ISRAEL 0x040D")]
    public const int TT_MS_LANGID_HEBREW_ISRAEL = 0x040D;

    [NativeTypeName("#define TT_MS_LANGID_HUNGARIAN_HUNGARY 0x040E")]
    public const int TT_MS_LANGID_HUNGARIAN_HUNGARY = 0x040E;

    [NativeTypeName("#define TT_MS_LANGID_ICELANDIC_ICELAND 0x040F")]
    public const int TT_MS_LANGID_ICELANDIC_ICELAND = 0x040F;

    [NativeTypeName("#define TT_MS_LANGID_ITALIAN_ITALY 0x0410")]
    public const int TT_MS_LANGID_ITALIAN_ITALY = 0x0410;

    [NativeTypeName("#define TT_MS_LANGID_ITALIAN_SWITZERLAND 0x0810")]
    public const int TT_MS_LANGID_ITALIAN_SWITZERLAND = 0x0810;

    [NativeTypeName("#define TT_MS_LANGID_JAPANESE_JAPAN 0x0411")]
    public const int TT_MS_LANGID_JAPANESE_JAPAN = 0x0411;

    [NativeTypeName("#define TT_MS_LANGID_KOREAN_KOREA 0x0412")]
    public const int TT_MS_LANGID_KOREAN_KOREA = 0x0412;

    [NativeTypeName("#define TT_MS_LANGID_DUTCH_NETHERLANDS 0x0413")]
    public const int TT_MS_LANGID_DUTCH_NETHERLANDS = 0x0413;

    [NativeTypeName("#define TT_MS_LANGID_DUTCH_BELGIUM 0x0813")]
    public const int TT_MS_LANGID_DUTCH_BELGIUM = 0x0813;

    [NativeTypeName("#define TT_MS_LANGID_NORWEGIAN_NORWAY_BOKMAL 0x0414")]
    public const int TT_MS_LANGID_NORWEGIAN_NORWAY_BOKMAL = 0x0414;

    [NativeTypeName("#define TT_MS_LANGID_NORWEGIAN_NORWAY_NYNORSK 0x0814")]
    public const int TT_MS_LANGID_NORWEGIAN_NORWAY_NYNORSK = 0x0814;

    [NativeTypeName("#define TT_MS_LANGID_POLISH_POLAND 0x0415")]
    public const int TT_MS_LANGID_POLISH_POLAND = 0x0415;

    [NativeTypeName("#define TT_MS_LANGID_PORTUGUESE_BRAZIL 0x0416")]
    public const int TT_MS_LANGID_PORTUGUESE_BRAZIL = 0x0416;

    [NativeTypeName("#define TT_MS_LANGID_PORTUGUESE_PORTUGAL 0x0816")]
    public const int TT_MS_LANGID_PORTUGUESE_PORTUGAL = 0x0816;

    [NativeTypeName("#define TT_MS_LANGID_ROMANSH_SWITZERLAND 0x0417")]
    public const int TT_MS_LANGID_ROMANSH_SWITZERLAND = 0x0417;

    [NativeTypeName("#define TT_MS_LANGID_ROMANIAN_ROMANIA 0x0418")]
    public const int TT_MS_LANGID_ROMANIAN_ROMANIA = 0x0418;

    [NativeTypeName("#define TT_MS_LANGID_RUSSIAN_RUSSIA 0x0419")]
    public const int TT_MS_LANGID_RUSSIAN_RUSSIA = 0x0419;

    [NativeTypeName("#define TT_MS_LANGID_CROATIAN_CROATIA 0x041A")]
    public const int TT_MS_LANGID_CROATIAN_CROATIA = 0x041A;

    [NativeTypeName("#define TT_MS_LANGID_SERBIAN_SERBIA_LATIN 0x081A")]
    public const int TT_MS_LANGID_SERBIAN_SERBIA_LATIN = 0x081A;

    [NativeTypeName("#define TT_MS_LANGID_SERBIAN_SERBIA_CYRILLIC 0x0C1A")]
    public const int TT_MS_LANGID_SERBIAN_SERBIA_CYRILLIC = 0x0C1A;

    [NativeTypeName("#define TT_MS_LANGID_CROATIAN_BOSNIA_HERZEGOVINA 0x101A")]
    public const int TT_MS_LANGID_CROATIAN_BOSNIA_HERZEGOVINA = 0x101A;

    [NativeTypeName("#define TT_MS_LANGID_BOSNIAN_BOSNIA_HERZEGOVINA 0x141A")]
    public const int TT_MS_LANGID_BOSNIAN_BOSNIA_HERZEGOVINA = 0x141A;

    [NativeTypeName("#define TT_MS_LANGID_SERBIAN_BOSNIA_HERZ_LATIN 0x181A")]
    public const int TT_MS_LANGID_SERBIAN_BOSNIA_HERZ_LATIN = 0x181A;

    [NativeTypeName("#define TT_MS_LANGID_SERBIAN_BOSNIA_HERZ_CYRILLIC 0x1C1A")]
    public const int TT_MS_LANGID_SERBIAN_BOSNIA_HERZ_CYRILLIC = 0x1C1A;

    [NativeTypeName("#define TT_MS_LANGID_BOSNIAN_BOSNIA_HERZ_CYRILLIC 0x201A")]
    public const int TT_MS_LANGID_BOSNIAN_BOSNIA_HERZ_CYRILLIC = 0x201A;

    [NativeTypeName("#define TT_MS_LANGID_SLOVAK_SLOVAKIA 0x041B")]
    public const int TT_MS_LANGID_SLOVAK_SLOVAKIA = 0x041B;

    [NativeTypeName("#define TT_MS_LANGID_ALBANIAN_ALBANIA 0x041C")]
    public const int TT_MS_LANGID_ALBANIAN_ALBANIA = 0x041C;

    [NativeTypeName("#define TT_MS_LANGID_SWEDISH_SWEDEN 0x041D")]
    public const int TT_MS_LANGID_SWEDISH_SWEDEN = 0x041D;

    [NativeTypeName("#define TT_MS_LANGID_SWEDISH_FINLAND 0x081D")]
    public const int TT_MS_LANGID_SWEDISH_FINLAND = 0x081D;

    [NativeTypeName("#define TT_MS_LANGID_THAI_THAILAND 0x041E")]
    public const int TT_MS_LANGID_THAI_THAILAND = 0x041E;

    [NativeTypeName("#define TT_MS_LANGID_TURKISH_TURKEY 0x041F")]
    public const int TT_MS_LANGID_TURKISH_TURKEY = 0x041F;

    [NativeTypeName("#define TT_MS_LANGID_URDU_PAKISTAN 0x0420")]
    public const int TT_MS_LANGID_URDU_PAKISTAN = 0x0420;

    [NativeTypeName("#define TT_MS_LANGID_INDONESIAN_INDONESIA 0x0421")]
    public const int TT_MS_LANGID_INDONESIAN_INDONESIA = 0x0421;

    [NativeTypeName("#define TT_MS_LANGID_UKRAINIAN_UKRAINE 0x0422")]
    public const int TT_MS_LANGID_UKRAINIAN_UKRAINE = 0x0422;

    [NativeTypeName("#define TT_MS_LANGID_BELARUSIAN_BELARUS 0x0423")]
    public const int TT_MS_LANGID_BELARUSIAN_BELARUS = 0x0423;

    [NativeTypeName("#define TT_MS_LANGID_SLOVENIAN_SLOVENIA 0x0424")]
    public const int TT_MS_LANGID_SLOVENIAN_SLOVENIA = 0x0424;

    [NativeTypeName("#define TT_MS_LANGID_ESTONIAN_ESTONIA 0x0425")]
    public const int TT_MS_LANGID_ESTONIAN_ESTONIA = 0x0425;

    [NativeTypeName("#define TT_MS_LANGID_LATVIAN_LATVIA 0x0426")]
    public const int TT_MS_LANGID_LATVIAN_LATVIA = 0x0426;

    [NativeTypeName("#define TT_MS_LANGID_LITHUANIAN_LITHUANIA 0x0427")]
    public const int TT_MS_LANGID_LITHUANIAN_LITHUANIA = 0x0427;

    [NativeTypeName("#define TT_MS_LANGID_TAJIK_TAJIKISTAN 0x0428")]
    public const int TT_MS_LANGID_TAJIK_TAJIKISTAN = 0x0428;

    [NativeTypeName("#define TT_MS_LANGID_VIETNAMESE_VIET_NAM 0x042A")]
    public const int TT_MS_LANGID_VIETNAMESE_VIET_NAM = 0x042A;

    [NativeTypeName("#define TT_MS_LANGID_ARMENIAN_ARMENIA 0x042B")]
    public const int TT_MS_LANGID_ARMENIAN_ARMENIA = 0x042B;

    [NativeTypeName("#define TT_MS_LANGID_AZERI_AZERBAIJAN_LATIN 0x042C")]
    public const int TT_MS_LANGID_AZERI_AZERBAIJAN_LATIN = 0x042C;

    [NativeTypeName("#define TT_MS_LANGID_AZERI_AZERBAIJAN_CYRILLIC 0x082C")]
    public const int TT_MS_LANGID_AZERI_AZERBAIJAN_CYRILLIC = 0x082C;

    [NativeTypeName("#define TT_MS_LANGID_BASQUE_BASQUE 0x042D")]
    public const int TT_MS_LANGID_BASQUE_BASQUE = 0x042D;

    [NativeTypeName("#define TT_MS_LANGID_UPPER_SORBIAN_GERMANY 0x042E")]
    public const int TT_MS_LANGID_UPPER_SORBIAN_GERMANY = 0x042E;

    [NativeTypeName("#define TT_MS_LANGID_LOWER_SORBIAN_GERMANY 0x082E")]
    public const int TT_MS_LANGID_LOWER_SORBIAN_GERMANY = 0x082E;

    [NativeTypeName("#define TT_MS_LANGID_MACEDONIAN_MACEDONIA 0x042F")]
    public const int TT_MS_LANGID_MACEDONIAN_MACEDONIA = 0x042F;

    [NativeTypeName("#define TT_MS_LANGID_SETSWANA_SOUTH_AFRICA 0x0432")]
    public const int TT_MS_LANGID_SETSWANA_SOUTH_AFRICA = 0x0432;

    [NativeTypeName("#define TT_MS_LANGID_ISIXHOSA_SOUTH_AFRICA 0x0434")]
    public const int TT_MS_LANGID_ISIXHOSA_SOUTH_AFRICA = 0x0434;

    [NativeTypeName("#define TT_MS_LANGID_ISIZULU_SOUTH_AFRICA 0x0435")]
    public const int TT_MS_LANGID_ISIZULU_SOUTH_AFRICA = 0x0435;

    [NativeTypeName("#define TT_MS_LANGID_AFRIKAANS_SOUTH_AFRICA 0x0436")]
    public const int TT_MS_LANGID_AFRIKAANS_SOUTH_AFRICA = 0x0436;

    [NativeTypeName("#define TT_MS_LANGID_GEORGIAN_GEORGIA 0x0437")]
    public const int TT_MS_LANGID_GEORGIAN_GEORGIA = 0x0437;

    [NativeTypeName("#define TT_MS_LANGID_FAEROESE_FAEROE_ISLANDS 0x0438")]
    public const int TT_MS_LANGID_FAEROESE_FAEROE_ISLANDS = 0x0438;

    [NativeTypeName("#define TT_MS_LANGID_HINDI_INDIA 0x0439")]
    public const int TT_MS_LANGID_HINDI_INDIA = 0x0439;

    [NativeTypeName("#define TT_MS_LANGID_MALTESE_MALTA 0x043A")]
    public const int TT_MS_LANGID_MALTESE_MALTA = 0x043A;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_NORTHERN_NORWAY 0x043B")]
    public const int TT_MS_LANGID_SAMI_NORTHERN_NORWAY = 0x043B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_NORTHERN_SWEDEN 0x083B")]
    public const int TT_MS_LANGID_SAMI_NORTHERN_SWEDEN = 0x083B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_NORTHERN_FINLAND 0x0C3B")]
    public const int TT_MS_LANGID_SAMI_NORTHERN_FINLAND = 0x0C3B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_LULE_NORWAY 0x103B")]
    public const int TT_MS_LANGID_SAMI_LULE_NORWAY = 0x103B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_LULE_SWEDEN 0x143B")]
    public const int TT_MS_LANGID_SAMI_LULE_SWEDEN = 0x143B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_SOUTHERN_NORWAY 0x183B")]
    public const int TT_MS_LANGID_SAMI_SOUTHERN_NORWAY = 0x183B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_SOUTHERN_SWEDEN 0x1C3B")]
    public const int TT_MS_LANGID_SAMI_SOUTHERN_SWEDEN = 0x1C3B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_SKOLT_FINLAND 0x203B")]
    public const int TT_MS_LANGID_SAMI_SKOLT_FINLAND = 0x203B;

    [NativeTypeName("#define TT_MS_LANGID_SAMI_INARI_FINLAND 0x243B")]
    public const int TT_MS_LANGID_SAMI_INARI_FINLAND = 0x243B;

    [NativeTypeName("#define TT_MS_LANGID_IRISH_IRELAND 0x083C")]
    public const int TT_MS_LANGID_IRISH_IRELAND = 0x083C;

    [NativeTypeName("#define TT_MS_LANGID_MALAY_MALAYSIA 0x043E")]
    public const int TT_MS_LANGID_MALAY_MALAYSIA = 0x043E;

    [NativeTypeName("#define TT_MS_LANGID_MALAY_BRUNEI_DARUSSALAM 0x083E")]
    public const int TT_MS_LANGID_MALAY_BRUNEI_DARUSSALAM = 0x083E;

    [NativeTypeName("#define TT_MS_LANGID_KAZAKH_KAZAKHSTAN 0x043F")]
    public const int TT_MS_LANGID_KAZAKH_KAZAKHSTAN = 0x043F;

    [NativeTypeName("#define TT_MS_LANGID_KYRGYZ_KYRGYZSTAN 0x0440")]
    public const int TT_MS_LANGID_KYRGYZ_KYRGYZSTAN = 0x0440;

    [NativeTypeName("#define TT_MS_LANGID_KISWAHILI_KENYA 0x0441")]
    public const int TT_MS_LANGID_KISWAHILI_KENYA = 0x0441;

    [NativeTypeName("#define TT_MS_LANGID_TURKMEN_TURKMENISTAN 0x0442")]
    public const int TT_MS_LANGID_TURKMEN_TURKMENISTAN = 0x0442;

    [NativeTypeName("#define TT_MS_LANGID_UZBEK_UZBEKISTAN_LATIN 0x0443")]
    public const int TT_MS_LANGID_UZBEK_UZBEKISTAN_LATIN = 0x0443;

    [NativeTypeName("#define TT_MS_LANGID_UZBEK_UZBEKISTAN_CYRILLIC 0x0843")]
    public const int TT_MS_LANGID_UZBEK_UZBEKISTAN_CYRILLIC = 0x0843;

    [NativeTypeName("#define TT_MS_LANGID_TATAR_RUSSIA 0x0444")]
    public const int TT_MS_LANGID_TATAR_RUSSIA = 0x0444;

    [NativeTypeName("#define TT_MS_LANGID_BENGALI_INDIA 0x0445")]
    public const int TT_MS_LANGID_BENGALI_INDIA = 0x0445;

    [NativeTypeName("#define TT_MS_LANGID_BENGALI_BANGLADESH 0x0845")]
    public const int TT_MS_LANGID_BENGALI_BANGLADESH = 0x0845;

    [NativeTypeName("#define TT_MS_LANGID_PUNJABI_INDIA 0x0446")]
    public const int TT_MS_LANGID_PUNJABI_INDIA = 0x0446;

    [NativeTypeName("#define TT_MS_LANGID_GUJARATI_INDIA 0x0447")]
    public const int TT_MS_LANGID_GUJARATI_INDIA = 0x0447;

    [NativeTypeName("#define TT_MS_LANGID_ODIA_INDIA 0x0448")]
    public const int TT_MS_LANGID_ODIA_INDIA = 0x0448;

    [NativeTypeName("#define TT_MS_LANGID_TAMIL_INDIA 0x0449")]
    public const int TT_MS_LANGID_TAMIL_INDIA = 0x0449;

    [NativeTypeName("#define TT_MS_LANGID_TELUGU_INDIA 0x044A")]
    public const int TT_MS_LANGID_TELUGU_INDIA = 0x044A;

    [NativeTypeName("#define TT_MS_LANGID_KANNADA_INDIA 0x044B")]
    public const int TT_MS_LANGID_KANNADA_INDIA = 0x044B;

    [NativeTypeName("#define TT_MS_LANGID_MALAYALAM_INDIA 0x044C")]
    public const int TT_MS_LANGID_MALAYALAM_INDIA = 0x044C;

    [NativeTypeName("#define TT_MS_LANGID_ASSAMESE_INDIA 0x044D")]
    public const int TT_MS_LANGID_ASSAMESE_INDIA = 0x044D;

    [NativeTypeName("#define TT_MS_LANGID_MARATHI_INDIA 0x044E")]
    public const int TT_MS_LANGID_MARATHI_INDIA = 0x044E;

    [NativeTypeName("#define TT_MS_LANGID_SANSKRIT_INDIA 0x044F")]
    public const int TT_MS_LANGID_SANSKRIT_INDIA = 0x044F;

    [NativeTypeName("#define TT_MS_LANGID_MONGOLIAN_MONGOLIA 0x0450")]
    public const int TT_MS_LANGID_MONGOLIAN_MONGOLIA = 0x0450;

    [NativeTypeName("#define TT_MS_LANGID_MONGOLIAN_PRC 0x0850")]
    public const int TT_MS_LANGID_MONGOLIAN_PRC = 0x0850;

    [NativeTypeName("#define TT_MS_LANGID_TIBETAN_PRC 0x0451")]
    public const int TT_MS_LANGID_TIBETAN_PRC = 0x0451;

    [NativeTypeName("#define TT_MS_LANGID_WELSH_UNITED_KINGDOM 0x0452")]
    public const int TT_MS_LANGID_WELSH_UNITED_KINGDOM = 0x0452;

    [NativeTypeName("#define TT_MS_LANGID_KHMER_CAMBODIA 0x0453")]
    public const int TT_MS_LANGID_KHMER_CAMBODIA = 0x0453;

    [NativeTypeName("#define TT_MS_LANGID_LAO_LAOS 0x0454")]
    public const int TT_MS_LANGID_LAO_LAOS = 0x0454;

    [NativeTypeName("#define TT_MS_LANGID_GALICIAN_GALICIAN 0x0456")]
    public const int TT_MS_LANGID_GALICIAN_GALICIAN = 0x0456;

    [NativeTypeName("#define TT_MS_LANGID_KONKANI_INDIA 0x0457")]
    public const int TT_MS_LANGID_KONKANI_INDIA = 0x0457;

    [NativeTypeName("#define TT_MS_LANGID_SYRIAC_SYRIA 0x045A")]
    public const int TT_MS_LANGID_SYRIAC_SYRIA = 0x045A;

    [NativeTypeName("#define TT_MS_LANGID_SINHALA_SRI_LANKA 0x045B")]
    public const int TT_MS_LANGID_SINHALA_SRI_LANKA = 0x045B;

    [NativeTypeName("#define TT_MS_LANGID_INUKTITUT_CANADA 0x045D")]
    public const int TT_MS_LANGID_INUKTITUT_CANADA = 0x045D;

    [NativeTypeName("#define TT_MS_LANGID_INUKTITUT_CANADA_LATIN 0x085D")]
    public const int TT_MS_LANGID_INUKTITUT_CANADA_LATIN = 0x085D;

    [NativeTypeName("#define TT_MS_LANGID_AMHARIC_ETHIOPIA 0x045E")]
    public const int TT_MS_LANGID_AMHARIC_ETHIOPIA = 0x045E;

    [NativeTypeName("#define TT_MS_LANGID_TAMAZIGHT_ALGERIA 0x085F")]
    public const int TT_MS_LANGID_TAMAZIGHT_ALGERIA = 0x085F;

    [NativeTypeName("#define TT_MS_LANGID_NEPALI_NEPAL 0x0461")]
    public const int TT_MS_LANGID_NEPALI_NEPAL = 0x0461;

    [NativeTypeName("#define TT_MS_LANGID_FRISIAN_NETHERLANDS 0x0462")]
    public const int TT_MS_LANGID_FRISIAN_NETHERLANDS = 0x0462;

    [NativeTypeName("#define TT_MS_LANGID_PASHTO_AFGHANISTAN 0x0463")]
    public const int TT_MS_LANGID_PASHTO_AFGHANISTAN = 0x0463;

    [NativeTypeName("#define TT_MS_LANGID_FILIPINO_PHILIPPINES 0x0464")]
    public const int TT_MS_LANGID_FILIPINO_PHILIPPINES = 0x0464;

    [NativeTypeName("#define TT_MS_LANGID_DHIVEHI_MALDIVES 0x0465")]
    public const int TT_MS_LANGID_DHIVEHI_MALDIVES = 0x0465;

    [NativeTypeName("#define TT_MS_LANGID_HAUSA_NIGERIA 0x0468")]
    public const int TT_MS_LANGID_HAUSA_NIGERIA = 0x0468;

    [NativeTypeName("#define TT_MS_LANGID_YORUBA_NIGERIA 0x046A")]
    public const int TT_MS_LANGID_YORUBA_NIGERIA = 0x046A;

    [NativeTypeName("#define TT_MS_LANGID_QUECHUA_BOLIVIA 0x046B")]
    public const int TT_MS_LANGID_QUECHUA_BOLIVIA = 0x046B;

    [NativeTypeName("#define TT_MS_LANGID_QUECHUA_ECUADOR 0x086B")]
    public const int TT_MS_LANGID_QUECHUA_ECUADOR = 0x086B;

    [NativeTypeName("#define TT_MS_LANGID_QUECHUA_PERU 0x0C6B")]
    public const int TT_MS_LANGID_QUECHUA_PERU = 0x0C6B;

    [NativeTypeName("#define TT_MS_LANGID_SESOTHO_SA_LEBOA_SOUTH_AFRICA 0x046C")]
    public const int TT_MS_LANGID_SESOTHO_SA_LEBOA_SOUTH_AFRICA = 0x046C;

    [NativeTypeName("#define TT_MS_LANGID_BASHKIR_RUSSIA 0x046D")]
    public const int TT_MS_LANGID_BASHKIR_RUSSIA = 0x046D;

    [NativeTypeName("#define TT_MS_LANGID_LUXEMBOURGISH_LUXEMBOURG 0x046E")]
    public const int TT_MS_LANGID_LUXEMBOURGISH_LUXEMBOURG = 0x046E;

    [NativeTypeName("#define TT_MS_LANGID_GREENLANDIC_GREENLAND 0x046F")]
    public const int TT_MS_LANGID_GREENLANDIC_GREENLAND = 0x046F;

    [NativeTypeName("#define TT_MS_LANGID_IGBO_NIGERIA 0x0470")]
    public const int TT_MS_LANGID_IGBO_NIGERIA = 0x0470;

    [NativeTypeName("#define TT_MS_LANGID_YI_PRC 0x0478")]
    public const int TT_MS_LANGID_YI_PRC = 0x0478;

    [NativeTypeName("#define TT_MS_LANGID_MAPUDUNGUN_CHILE 0x047A")]
    public const int TT_MS_LANGID_MAPUDUNGUN_CHILE = 0x047A;

    [NativeTypeName("#define TT_MS_LANGID_MOHAWK_MOHAWK 0x047C")]
    public const int TT_MS_LANGID_MOHAWK_MOHAWK = 0x047C;

    [NativeTypeName("#define TT_MS_LANGID_BRETON_FRANCE 0x047E")]
    public const int TT_MS_LANGID_BRETON_FRANCE = 0x047E;

    [NativeTypeName("#define TT_MS_LANGID_UIGHUR_PRC 0x0480")]
    public const int TT_MS_LANGID_UIGHUR_PRC = 0x0480;

    [NativeTypeName("#define TT_MS_LANGID_MAORI_NEW_ZEALAND 0x0481")]
    public const int TT_MS_LANGID_MAORI_NEW_ZEALAND = 0x0481;

    [NativeTypeName("#define TT_MS_LANGID_OCCITAN_FRANCE 0x0482")]
    public const int TT_MS_LANGID_OCCITAN_FRANCE = 0x0482;

    [NativeTypeName("#define TT_MS_LANGID_CORSICAN_FRANCE 0x0483")]
    public const int TT_MS_LANGID_CORSICAN_FRANCE = 0x0483;

    [NativeTypeName("#define TT_MS_LANGID_ALSATIAN_FRANCE 0x0484")]
    public const int TT_MS_LANGID_ALSATIAN_FRANCE = 0x0484;

    [NativeTypeName("#define TT_MS_LANGID_YAKUT_RUSSIA 0x0485")]
    public const int TT_MS_LANGID_YAKUT_RUSSIA = 0x0485;

    [NativeTypeName("#define TT_MS_LANGID_KICHE_GUATEMALA 0x0486")]
    public const int TT_MS_LANGID_KICHE_GUATEMALA = 0x0486;

    [NativeTypeName("#define TT_MS_LANGID_KINYARWANDA_RWANDA 0x0487")]
    public const int TT_MS_LANGID_KINYARWANDA_RWANDA = 0x0487;

    [NativeTypeName("#define TT_MS_LANGID_WOLOF_SENEGAL 0x0488")]
    public const int TT_MS_LANGID_WOLOF_SENEGAL = 0x0488;

    [NativeTypeName("#define TT_MS_LANGID_DARI_AFGHANISTAN 0x048C")]
    public const int TT_MS_LANGID_DARI_AFGHANISTAN = 0x048C;

    [NativeTypeName("#define TT_MS_LANGID_ARABIC_GENERAL 0x0001")]
    public const int TT_MS_LANGID_ARABIC_GENERAL = 0x0001;

    [NativeTypeName("#define TT_MS_LANGID_CATALAN_SPAIN TT_MS_LANGID_CATALAN_CATALAN")]
    public const int TT_MS_LANGID_CATALAN_SPAIN = 0x0403;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_GENERAL 0x0004")]
    public const int TT_MS_LANGID_CHINESE_GENERAL = 0x0004;

    [NativeTypeName("#define TT_MS_LANGID_CHINESE_MACAU TT_MS_LANGID_CHINESE_MACAO")]
    public const int TT_MS_LANGID_CHINESE_MACAU = 0x1404;

    [NativeTypeName("#define TT_MS_LANGID_GERMAN_LIECHTENSTEI TT_MS_LANGID_GERMAN_LIECHTENSTEIN")]
    public const int TT_MS_LANGID_GERMAN_LIECHTENSTEI = 0x1407;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_GENERAL 0x0009")]
    public const int TT_MS_LANGID_ENGLISH_GENERAL = 0x0009;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_INDONESIA 0x3809")]
    public const int TT_MS_LANGID_ENGLISH_INDONESIA = 0x3809;

    [NativeTypeName("#define TT_MS_LANGID_ENGLISH_HONG_KONG 0x3C09")]
    public const int TT_MS_LANGID_ENGLISH_HONG_KONG = 0x3C09;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_SPAIN_INTERNATIONAL_SORT TT_MS_LANGID_SPANISH_SPAIN_MODERN_SORT")]
    public const int TT_MS_LANGID_SPANISH_SPAIN_INTERNATIONAL_SORT = 0x0C0A;

    [NativeTypeName("#define TT_MS_LANGID_SPANISH_LATIN_AMERICA 0xE40AU")]
    public const uint TT_MS_LANGID_SPANISH_LATIN_AMERICA = 0xE40AU;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_WEST_INDIES 0x1C0C")]
    public const int TT_MS_LANGID_FRENCH_WEST_INDIES = 0x1C0C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_REUNION 0x200C")]
    public const int TT_MS_LANGID_FRENCH_REUNION = 0x200C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_CONGO 0x240C")]
    public const int TT_MS_LANGID_FRENCH_CONGO = 0x240C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_ZAIRE TT_MS_LANGID_FRENCH_CONGO")]
    public const int TT_MS_LANGID_FRENCH_ZAIRE = 0x240C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_SENEGAL 0x280C")]
    public const int TT_MS_LANGID_FRENCH_SENEGAL = 0x280C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_CAMEROON 0x2C0C")]
    public const int TT_MS_LANGID_FRENCH_CAMEROON = 0x2C0C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_COTE_D_IVOIRE 0x300C")]
    public const int TT_MS_LANGID_FRENCH_COTE_D_IVOIRE = 0x300C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_MALI 0x340C")]
    public const int TT_MS_LANGID_FRENCH_MALI = 0x340C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_MOROCCO 0x380C")]
    public const int TT_MS_LANGID_FRENCH_MOROCCO = 0x380C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_HAITI 0x3C0C")]
    public const int TT_MS_LANGID_FRENCH_HAITI = 0x3C0C;

    [NativeTypeName("#define TT_MS_LANGID_FRENCH_NORTH_AFRICA 0xE40CU")]
    public const uint TT_MS_LANGID_FRENCH_NORTH_AFRICA = 0xE40CU;

    [NativeTypeName("#define TT_MS_LANGID_KOREAN_EXTENDED_WANSUNG_KOREA TT_MS_LANGID_KOREAN_KOREA")]
    public const int TT_MS_LANGID_KOREAN_EXTENDED_WANSUNG_KOREA = 0x0412;

    [NativeTypeName("#define TT_MS_LANGID_KOREAN_JOHAB_KOREA 0x0812")]
    public const int TT_MS_LANGID_KOREAN_JOHAB_KOREA = 0x0812;

    [NativeTypeName("#define TT_MS_LANGID_RHAETO_ROMANIC_SWITZERLAND TT_MS_LANGID_ROMANSH_SWITZERLAND")]
    public const int TT_MS_LANGID_RHAETO_ROMANIC_SWITZERLAND = 0x0417;

    [NativeTypeName("#define TT_MS_LANGID_MOLDAVIAN_MOLDAVIA 0x0818")]
    public const int TT_MS_LANGID_MOLDAVIAN_MOLDAVIA = 0x0818;

    [NativeTypeName("#define TT_MS_LANGID_RUSSIAN_MOLDAVIA 0x0819")]
    public const int TT_MS_LANGID_RUSSIAN_MOLDAVIA = 0x0819;

    [NativeTypeName("#define TT_MS_LANGID_URDU_INDIA 0x0820")]
    public const int TT_MS_LANGID_URDU_INDIA = 0x0820;

    [NativeTypeName("#define TT_MS_LANGID_CLASSIC_LITHUANIAN_LITHUANIA 0x0827")]
    public const int TT_MS_LANGID_CLASSIC_LITHUANIAN_LITHUANIA = 0x0827;

    [NativeTypeName("#define TT_MS_LANGID_SLOVENE_SLOVENIA TT_MS_LANGID_SLOVENIAN_SLOVENIA")]
    public const int TT_MS_LANGID_SLOVENE_SLOVENIA = 0x0424;

    [NativeTypeName("#define TT_MS_LANGID_FARSI_IRAN 0x0429")]
    public const int TT_MS_LANGID_FARSI_IRAN = 0x0429;

    [NativeTypeName("#define TT_MS_LANGID_BASQUE_SPAIN TT_MS_LANGID_BASQUE_BASQUE")]
    public const int TT_MS_LANGID_BASQUE_SPAIN = 0x042D;

    [NativeTypeName("#define TT_MS_LANGID_SORBIAN_GERMANY TT_MS_LANGID_UPPER_SORBIAN_GERMANY")]
    public const int TT_MS_LANGID_SORBIAN_GERMANY = 0x042E;

    [NativeTypeName("#define TT_MS_LANGID_SUTU_SOUTH_AFRICA 0x0430")]
    public const int TT_MS_LANGID_SUTU_SOUTH_AFRICA = 0x0430;

    [NativeTypeName("#define TT_MS_LANGID_TSONGA_SOUTH_AFRICA 0x0431")]
    public const int TT_MS_LANGID_TSONGA_SOUTH_AFRICA = 0x0431;

    [NativeTypeName("#define TT_MS_LANGID_TSWANA_SOUTH_AFRICA TT_MS_LANGID_SETSWANA_SOUTH_AFRICA")]
    public const int TT_MS_LANGID_TSWANA_SOUTH_AFRICA = 0x0432;

    [NativeTypeName("#define TT_MS_LANGID_VENDA_SOUTH_AFRICA 0x0433")]
    public const int TT_MS_LANGID_VENDA_SOUTH_AFRICA = 0x0433;

    [NativeTypeName("#define TT_MS_LANGID_XHOSA_SOUTH_AFRICA TT_MS_LANGID_ISIXHOSA_SOUTH_AFRICA")]
    public const int TT_MS_LANGID_XHOSA_SOUTH_AFRICA = 0x0434;

    [NativeTypeName("#define TT_MS_LANGID_ZULU_SOUTH_AFRICA TT_MS_LANGID_ISIZULU_SOUTH_AFRICA")]
    public const int TT_MS_LANGID_ZULU_SOUTH_AFRICA = 0x0435;

    [NativeTypeName("#define TT_MS_LANGID_SAAMI_LAPONIA 0x043B")]
    public const int TT_MS_LANGID_SAAMI_LAPONIA = 0x043B;

    [NativeTypeName("#define TT_MS_LANGID_IRISH_GAELIC_IRELAND 0x043C")]
    public const int TT_MS_LANGID_IRISH_GAELIC_IRELAND = 0x043C;

    [NativeTypeName("#define TT_MS_LANGID_SCOTTISH_GAELIC_UNITED_KINGDOM 0x083C")]
    public const int TT_MS_LANGID_SCOTTISH_GAELIC_UNITED_KINGDOM = 0x083C;

    [NativeTypeName("#define TT_MS_LANGID_YIDDISH_GERMANY 0x043D")]
    public const int TT_MS_LANGID_YIDDISH_GERMANY = 0x043D;

    [NativeTypeName("#define TT_MS_LANGID_KAZAK_KAZAKSTAN TT_MS_LANGID_KAZAKH_KAZAKHSTAN")]
    public const int TT_MS_LANGID_KAZAK_KAZAKSTAN = 0x043F;

    [NativeTypeName("#define TT_MS_LANGID_KIRGHIZ_KIRGHIZ_REPUBLIC TT_MS_LANGID_KYRGYZ_KYRGYZSTAN")]
    public const int TT_MS_LANGID_KIRGHIZ_KIRGHIZ_REPUBLIC = 0x0440;

    [NativeTypeName("#define TT_MS_LANGID_KIRGHIZ_KIRGHIZSTAN TT_MS_LANGID_KYRGYZ_KYRGYZSTAN")]
    public const int TT_MS_LANGID_KIRGHIZ_KIRGHIZSTAN = 0x0440;

    [NativeTypeName("#define TT_MS_LANGID_SWAHILI_KENYA TT_MS_LANGID_KISWAHILI_KENYA")]
    public const int TT_MS_LANGID_SWAHILI_KENYA = 0x0441;

    [NativeTypeName("#define TT_MS_LANGID_TATAR_TATARSTAN TT_MS_LANGID_TATAR_RUSSIA")]
    public const int TT_MS_LANGID_TATAR_TATARSTAN = 0x0444;

    [NativeTypeName("#define TT_MS_LANGID_PUNJABI_ARABIC_PAKISTAN 0x0846")]
    public const int TT_MS_LANGID_PUNJABI_ARABIC_PAKISTAN = 0x0846;

    [NativeTypeName("#define TT_MS_LANGID_ORIYA_INDIA TT_MS_LANGID_ODIA_INDIA")]
    public const int TT_MS_LANGID_ORIYA_INDIA = 0x0448;

    [NativeTypeName("#define TT_MS_LANGID_MONGOLIAN_MONGOLIA_MONGOLIAN TT_MS_LANGID_MONGOLIAN_PRC")]
    public const int TT_MS_LANGID_MONGOLIAN_MONGOLIA_MONGOLIAN = 0x0850;

    [NativeTypeName("#define TT_MS_LANGID_TIBETAN_CHINA TT_MS_LANGID_TIBETAN_PRC")]
    public const int TT_MS_LANGID_TIBETAN_CHINA = 0x0451;

    [NativeTypeName("#define TT_MS_LANGID_DZONGHKA_BHUTAN 0x0851")]
    public const int TT_MS_LANGID_DZONGHKA_BHUTAN = 0x0851;

    [NativeTypeName("#define TT_MS_LANGID_TIBETAN_BHUTAN TT_MS_LANGID_DZONGHKA_BHUTAN")]
    public const int TT_MS_LANGID_TIBETAN_BHUTAN = 0x0851;

    [NativeTypeName("#define TT_MS_LANGID_WELSH_WALES TT_MS_LANGID_WELSH_UNITED_KINGDOM")]
    public const int TT_MS_LANGID_WELSH_WALES = 0x0452;

    [NativeTypeName("#define TT_MS_LANGID_BURMESE_MYANMAR 0x0455")]
    public const int TT_MS_LANGID_BURMESE_MYANMAR = 0x0455;

    [NativeTypeName("#define TT_MS_LANGID_GALICIAN_SPAIN TT_MS_LANGID_GALICIAN_GALICIAN")]
    public const int TT_MS_LANGID_GALICIAN_SPAIN = 0x0456;

    [NativeTypeName("#define TT_MS_LANGID_MANIPURI_INDIA 0x0458")]
    public const int TT_MS_LANGID_MANIPURI_INDIA = 0x0458;

    [NativeTypeName("#define TT_MS_LANGID_SINDHI_INDIA 0x0459")]
    public const int TT_MS_LANGID_SINDHI_INDIA = 0x0459;

    [NativeTypeName("#define TT_MS_LANGID_SINDHI_PAKISTAN 0x0859")]
    public const int TT_MS_LANGID_SINDHI_PAKISTAN = 0x0859;

    [NativeTypeName("#define TT_MS_LANGID_SINHALESE_SRI_LANKA TT_MS_LANGID_SINHALA_SRI_LANKA")]
    public const int TT_MS_LANGID_SINHALESE_SRI_LANKA = 0x045B;

    [NativeTypeName("#define TT_MS_LANGID_CHEROKEE_UNITED_STATES 0x045C")]
    public const int TT_MS_LANGID_CHEROKEE_UNITED_STATES = 0x045C;

    [NativeTypeName("#define TT_MS_LANGID_TAMAZIGHT_MOROCCO 0x045F")]
    public const int TT_MS_LANGID_TAMAZIGHT_MOROCCO = 0x045F;

    [NativeTypeName("#define TT_MS_LANGID_TAMAZIGHT_MOROCCO_LATIN TT_MS_LANGID_TAMAZIGHT_ALGERIA")]
    public const int TT_MS_LANGID_TAMAZIGHT_MOROCCO_LATIN = 0x085F;

    [NativeTypeName("#define TT_MS_LANGID_KASHMIRI_PAKISTAN 0x0460")]
    public const int TT_MS_LANGID_KASHMIRI_PAKISTAN = 0x0460;

    [NativeTypeName("#define TT_MS_LANGID_KASHMIRI_SASIA 0x0860")]
    public const int TT_MS_LANGID_KASHMIRI_SASIA = 0x0860;

    [NativeTypeName("#define TT_MS_LANGID_KASHMIRI_INDIA TT_MS_LANGID_KASHMIRI_SASIA")]
    public const int TT_MS_LANGID_KASHMIRI_INDIA = 0x0860;

    [NativeTypeName("#define TT_MS_LANGID_NEPALI_INDIA 0x0861")]
    public const int TT_MS_LANGID_NEPALI_INDIA = 0x0861;

    [NativeTypeName("#define TT_MS_LANGID_DIVEHI_MALDIVES TT_MS_LANGID_DHIVEHI_MALDIVES")]
    public const int TT_MS_LANGID_DIVEHI_MALDIVES = 0x0465;

    [NativeTypeName("#define TT_MS_LANGID_EDO_NIGERIA 0x0466")]
    public const int TT_MS_LANGID_EDO_NIGERIA = 0x0466;

    [NativeTypeName("#define TT_MS_LANGID_FULFULDE_NIGERIA 0x0467")]
    public const int TT_MS_LANGID_FULFULDE_NIGERIA = 0x0467;

    [NativeTypeName("#define TT_MS_LANGID_IBIBIO_NIGERIA 0x0469")]
    public const int TT_MS_LANGID_IBIBIO_NIGERIA = 0x0469;

    [NativeTypeName("#define TT_MS_LANGID_SEPEDI_SOUTH_AFRICA TT_MS_LANGID_SESOTHO_SA_LEBOA_SOUTH_AFRICA")]
    public const int TT_MS_LANGID_SEPEDI_SOUTH_AFRICA = 0x046C;

    [NativeTypeName("#define TT_MS_LANGID_SOTHO_SOUTHERN_SOUTH_AFRICA TT_MS_LANGID_SESOTHO_SA_LEBOA_SOUTH_AFRICA")]
    public const int TT_MS_LANGID_SOTHO_SOUTHERN_SOUTH_AFRICA = 0x046C;

    [NativeTypeName("#define TT_MS_LANGID_KANURI_NIGERIA 0x0471")]
    public const int TT_MS_LANGID_KANURI_NIGERIA = 0x0471;

    [NativeTypeName("#define TT_MS_LANGID_OROMO_ETHIOPIA 0x0472")]
    public const int TT_MS_LANGID_OROMO_ETHIOPIA = 0x0472;

    [NativeTypeName("#define TT_MS_LANGID_TIGRIGNA_ETHIOPIA 0x0473")]
    public const int TT_MS_LANGID_TIGRIGNA_ETHIOPIA = 0x0473;

    [NativeTypeName("#define TT_MS_LANGID_TIGRIGNA_ERYTHREA 0x0873")]
    public const int TT_MS_LANGID_TIGRIGNA_ERYTHREA = 0x0873;

    [NativeTypeName("#define TT_MS_LANGID_TIGRIGNA_ERYTREA TT_MS_LANGID_TIGRIGNA_ERYTHREA")]
    public const int TT_MS_LANGID_TIGRIGNA_ERYTREA = 0x0873;

    [NativeTypeName("#define TT_MS_LANGID_GUARANI_PARAGUAY 0x0474")]
    public const int TT_MS_LANGID_GUARANI_PARAGUAY = 0x0474;

    [NativeTypeName("#define TT_MS_LANGID_HAWAIIAN_UNITED_STATES 0x0475")]
    public const int TT_MS_LANGID_HAWAIIAN_UNITED_STATES = 0x0475;

    [NativeTypeName("#define TT_MS_LANGID_LATIN 0x0476")]
    public const int TT_MS_LANGID_LATIN = 0x0476;

    [NativeTypeName("#define TT_MS_LANGID_SOMALI_SOMALIA 0x0477")]
    public const int TT_MS_LANGID_SOMALI_SOMALIA = 0x0477;

    [NativeTypeName("#define TT_MS_LANGID_YI_CHINA TT_MS_LANGID_YI_PRC")]
    public const int TT_MS_LANGID_YI_CHINA = 0x0478;

    [NativeTypeName("#define TT_MS_LANGID_PAPIAMENTU_NETHERLANDS_ANTILLES 0x0479")]
    public const int TT_MS_LANGID_PAPIAMENTU_NETHERLANDS_ANTILLES = 0x0479;

    [NativeTypeName("#define TT_MS_LANGID_UIGHUR_CHINA TT_MS_LANGID_UIGHUR_PRC")]
    public const int TT_MS_LANGID_UIGHUR_CHINA = 0x0480;

    [NativeTypeName("#define TT_NAME_ID_COPYRIGHT 0")]
    public const int TT_NAME_ID_COPYRIGHT = 0;

    [NativeTypeName("#define TT_NAME_ID_FONT_FAMILY 1")]
    public const int TT_NAME_ID_FONT_FAMILY = 1;

    [NativeTypeName("#define TT_NAME_ID_FONT_SUBFAMILY 2")]
    public const int TT_NAME_ID_FONT_SUBFAMILY = 2;

    [NativeTypeName("#define TT_NAME_ID_UNIQUE_ID 3")]
    public const int TT_NAME_ID_UNIQUE_ID = 3;

    [NativeTypeName("#define TT_NAME_ID_FULL_NAME 4")]
    public const int TT_NAME_ID_FULL_NAME = 4;

    [NativeTypeName("#define TT_NAME_ID_VERSION_STRING 5")]
    public const int TT_NAME_ID_VERSION_STRING = 5;

    [NativeTypeName("#define TT_NAME_ID_PS_NAME 6")]
    public const int TT_NAME_ID_PS_NAME = 6;

    [NativeTypeName("#define TT_NAME_ID_TRADEMARK 7")]
    public const int TT_NAME_ID_TRADEMARK = 7;

    [NativeTypeName("#define TT_NAME_ID_MANUFACTURER 8")]
    public const int TT_NAME_ID_MANUFACTURER = 8;

    [NativeTypeName("#define TT_NAME_ID_DESIGNER 9")]
    public const int TT_NAME_ID_DESIGNER = 9;

    [NativeTypeName("#define TT_NAME_ID_DESCRIPTION 10")]
    public const int TT_NAME_ID_DESCRIPTION = 10;

    [NativeTypeName("#define TT_NAME_ID_VENDOR_URL 11")]
    public const int TT_NAME_ID_VENDOR_URL = 11;

    [NativeTypeName("#define TT_NAME_ID_DESIGNER_URL 12")]
    public const int TT_NAME_ID_DESIGNER_URL = 12;

    [NativeTypeName("#define TT_NAME_ID_LICENSE 13")]
    public const int TT_NAME_ID_LICENSE = 13;

    [NativeTypeName("#define TT_NAME_ID_LICENSE_URL 14")]
    public const int TT_NAME_ID_LICENSE_URL = 14;

    [NativeTypeName("#define TT_NAME_ID_TYPOGRAPHIC_FAMILY 16")]
    public const int TT_NAME_ID_TYPOGRAPHIC_FAMILY = 16;

    [NativeTypeName("#define TT_NAME_ID_TYPOGRAPHIC_SUBFAMILY 17")]
    public const int TT_NAME_ID_TYPOGRAPHIC_SUBFAMILY = 17;

    [NativeTypeName("#define TT_NAME_ID_MAC_FULL_NAME 18")]
    public const int TT_NAME_ID_MAC_FULL_NAME = 18;

    [NativeTypeName("#define TT_NAME_ID_SAMPLE_TEXT 19")]
    public const int TT_NAME_ID_SAMPLE_TEXT = 19;

    [NativeTypeName("#define TT_NAME_ID_CID_FINDFONT_NAME 20")]
    public const int TT_NAME_ID_CID_FINDFONT_NAME = 20;

    [NativeTypeName("#define TT_NAME_ID_WWS_FAMILY 21")]
    public const int TT_NAME_ID_WWS_FAMILY = 21;

    [NativeTypeName("#define TT_NAME_ID_WWS_SUBFAMILY 22")]
    public const int TT_NAME_ID_WWS_SUBFAMILY = 22;

    [NativeTypeName("#define TT_NAME_ID_LIGHT_BACKGROUND 23")]
    public const int TT_NAME_ID_LIGHT_BACKGROUND = 23;

    [NativeTypeName("#define TT_NAME_ID_DARK_BACKGROUND 24")]
    public const int TT_NAME_ID_DARK_BACKGROUND = 24;

    [NativeTypeName("#define TT_NAME_ID_VARIATIONS_PREFIX 25")]
    public const int TT_NAME_ID_VARIATIONS_PREFIX = 25;

    [NativeTypeName("#define TT_NAME_ID_PREFERRED_FAMILY TT_NAME_ID_TYPOGRAPHIC_FAMILY")]
    public const int TT_NAME_ID_PREFERRED_FAMILY = 16;

    [NativeTypeName("#define TT_NAME_ID_PREFERRED_SUBFAMILY TT_NAME_ID_TYPOGRAPHIC_SUBFAMILY")]
    public const int TT_NAME_ID_PREFERRED_SUBFAMILY = 17;

    [NativeTypeName("#define TT_UCR_BASIC_LATIN (1UL <<  0)")]
    public const nuint TT_UCR_BASIC_LATIN = (1U << 0);

    [NativeTypeName("#define TT_UCR_LATIN1_SUPPLEMENT (1UL <<  1)")]
    public const nuint TT_UCR_LATIN1_SUPPLEMENT = (1U << 1);

    [NativeTypeName("#define TT_UCR_LATIN_EXTENDED_A (1UL <<  2)")]
    public const nuint TT_UCR_LATIN_EXTENDED_A = (1U << 2);

    [NativeTypeName("#define TT_UCR_LATIN_EXTENDED_B (1UL <<  3)")]
    public const nuint TT_UCR_LATIN_EXTENDED_B = (1U << 3);

    [NativeTypeName("#define TT_UCR_IPA_EXTENSIONS (1UL <<  4)")]
    public const nuint TT_UCR_IPA_EXTENSIONS = (1U << 4);

    [NativeTypeName("#define TT_UCR_SPACING_MODIFIER (1UL <<  5)")]
    public const nuint TT_UCR_SPACING_MODIFIER = (1U << 5);

    [NativeTypeName("#define TT_UCR_COMBINING_DIACRITICAL_MARKS (1UL <<  6)")]
    public const nuint TT_UCR_COMBINING_DIACRITICAL_MARKS = (1U << 6);

    [NativeTypeName("#define TT_UCR_GREEK (1UL <<  7)")]
    public const nuint TT_UCR_GREEK = (1U << 7);

    [NativeTypeName("#define TT_UCR_COPTIC (1UL <<  8)")]
    public const nuint TT_UCR_COPTIC = (1U << 8);

    [NativeTypeName("#define TT_UCR_CYRILLIC (1UL <<  9)")]
    public const nuint TT_UCR_CYRILLIC = (1U << 9);

    [NativeTypeName("#define TT_UCR_ARMENIAN (1UL << 10)")]
    public const nuint TT_UCR_ARMENIAN = (1U << 10);

    [NativeTypeName("#define TT_UCR_HEBREW (1UL << 11)")]
    public const nuint TT_UCR_HEBREW = (1U << 11);

    [NativeTypeName("#define TT_UCR_VAI (1UL << 12)")]
    public const nuint TT_UCR_VAI = (1U << 12);

    [NativeTypeName("#define TT_UCR_ARABIC (1UL << 13)")]
    public const nuint TT_UCR_ARABIC = (1U << 13);

    [NativeTypeName("#define TT_UCR_NKO (1UL << 14)")]
    public const nuint TT_UCR_NKO = (1U << 14);

    [NativeTypeName("#define TT_UCR_DEVANAGARI (1UL << 15)")]
    public const nuint TT_UCR_DEVANAGARI = (1U << 15);

    [NativeTypeName("#define TT_UCR_BENGALI (1UL << 16)")]
    public const nuint TT_UCR_BENGALI = (1U << 16);

    [NativeTypeName("#define TT_UCR_GURMUKHI (1UL << 17)")]
    public const nuint TT_UCR_GURMUKHI = (1U << 17);

    [NativeTypeName("#define TT_UCR_GUJARATI (1UL << 18)")]
    public const nuint TT_UCR_GUJARATI = (1U << 18);

    [NativeTypeName("#define TT_UCR_ORIYA (1UL << 19)")]
    public const nuint TT_UCR_ORIYA = (1U << 19);

    [NativeTypeName("#define TT_UCR_TAMIL (1UL << 20)")]
    public const nuint TT_UCR_TAMIL = (1U << 20);

    [NativeTypeName("#define TT_UCR_TELUGU (1UL << 21)")]
    public const nuint TT_UCR_TELUGU = (1U << 21);

    [NativeTypeName("#define TT_UCR_KANNADA (1UL << 22)")]
    public const nuint TT_UCR_KANNADA = (1U << 22);

    [NativeTypeName("#define TT_UCR_MALAYALAM (1UL << 23)")]
    public const nuint TT_UCR_MALAYALAM = (1U << 23);

    [NativeTypeName("#define TT_UCR_THAI (1UL << 24)")]
    public const nuint TT_UCR_THAI = (1U << 24);

    [NativeTypeName("#define TT_UCR_LAO (1UL << 25)")]
    public const nuint TT_UCR_LAO = (1U << 25);

    [NativeTypeName("#define TT_UCR_GEORGIAN (1UL << 26)")]
    public const nuint TT_UCR_GEORGIAN = (1U << 26);

    [NativeTypeName("#define TT_UCR_BALINESE (1UL << 27)")]
    public const nuint TT_UCR_BALINESE = (1U << 27);

    [NativeTypeName("#define TT_UCR_HANGUL_JAMO (1UL << 28)")]
    public const nuint TT_UCR_HANGUL_JAMO = (1U << 28);

    [NativeTypeName("#define TT_UCR_LATIN_EXTENDED_ADDITIONAL (1UL << 29)")]
    public const nuint TT_UCR_LATIN_EXTENDED_ADDITIONAL = (1U << 29);

    [NativeTypeName("#define TT_UCR_GREEK_EXTENDED (1UL << 30)")]
    public const nuint TT_UCR_GREEK_EXTENDED = (1U << 30);

    [NativeTypeName("#define TT_UCR_GENERAL_PUNCTUATION (1UL << 31)")]
    public const nuint TT_UCR_GENERAL_PUNCTUATION = (1U << 31);

    [NativeTypeName("#define TT_UCR_SUPERSCRIPTS_SUBSCRIPTS (1UL <<  0)")]
    public const nuint TT_UCR_SUPERSCRIPTS_SUBSCRIPTS = (1U << 0);

    [NativeTypeName("#define TT_UCR_CURRENCY_SYMBOLS (1UL <<  1)")]
    public const nuint TT_UCR_CURRENCY_SYMBOLS = (1U << 1);

    [NativeTypeName("#define TT_UCR_COMBINING_DIACRITICAL_MARKS_SYMB (1UL <<  2)")]
    public const nuint TT_UCR_COMBINING_DIACRITICAL_MARKS_SYMB = (1U << 2);

    [NativeTypeName("#define TT_UCR_LETTERLIKE_SYMBOLS (1UL <<  3)")]
    public const nuint TT_UCR_LETTERLIKE_SYMBOLS = (1U << 3);

    [NativeTypeName("#define TT_UCR_NUMBER_FORMS (1UL <<  4)")]
    public const nuint TT_UCR_NUMBER_FORMS = (1U << 4);

    [NativeTypeName("#define TT_UCR_ARROWS (1UL <<  5)")]
    public const nuint TT_UCR_ARROWS = (1U << 5);

    [NativeTypeName("#define TT_UCR_MATHEMATICAL_OPERATORS (1UL <<  6)")]
    public const nuint TT_UCR_MATHEMATICAL_OPERATORS = (1U << 6);

    [NativeTypeName("#define TT_UCR_MISCELLANEOUS_TECHNICAL (1UL <<  7)")]
    public const nuint TT_UCR_MISCELLANEOUS_TECHNICAL = (1U << 7);

    [NativeTypeName("#define TT_UCR_CONTROL_PICTURES (1UL <<  8)")]
    public const nuint TT_UCR_CONTROL_PICTURES = (1U << 8);

    [NativeTypeName("#define TT_UCR_OCR (1UL <<  9)")]
    public const nuint TT_UCR_OCR = (1U << 9);

    [NativeTypeName("#define TT_UCR_ENCLOSED_ALPHANUMERICS (1UL << 10)")]
    public const nuint TT_UCR_ENCLOSED_ALPHANUMERICS = (1U << 10);

    [NativeTypeName("#define TT_UCR_BOX_DRAWING (1UL << 11)")]
    public const nuint TT_UCR_BOX_DRAWING = (1U << 11);

    [NativeTypeName("#define TT_UCR_BLOCK_ELEMENTS (1UL << 12)")]
    public const nuint TT_UCR_BLOCK_ELEMENTS = (1U << 12);

    [NativeTypeName("#define TT_UCR_GEOMETRIC_SHAPES (1UL << 13)")]
    public const nuint TT_UCR_GEOMETRIC_SHAPES = (1U << 13);

    [NativeTypeName("#define TT_UCR_MISCELLANEOUS_SYMBOLS (1UL << 14)")]
    public const nuint TT_UCR_MISCELLANEOUS_SYMBOLS = (1U << 14);

    [NativeTypeName("#define TT_UCR_DINGBATS (1UL << 15)")]
    public const nuint TT_UCR_DINGBATS = (1U << 15);

    [NativeTypeName("#define TT_UCR_CJK_SYMBOLS (1UL << 16)")]
    public const nuint TT_UCR_CJK_SYMBOLS = (1U << 16);

    [NativeTypeName("#define TT_UCR_HIRAGANA (1UL << 17)")]
    public const nuint TT_UCR_HIRAGANA = (1U << 17);

    [NativeTypeName("#define TT_UCR_KATAKANA (1UL << 18)")]
    public const nuint TT_UCR_KATAKANA = (1U << 18);

    [NativeTypeName("#define TT_UCR_BOPOMOFO (1UL << 19)")]
    public const nuint TT_UCR_BOPOMOFO = (1U << 19);

    [NativeTypeName("#define TT_UCR_HANGUL_COMPATIBILITY_JAMO (1UL << 20)")]
    public const nuint TT_UCR_HANGUL_COMPATIBILITY_JAMO = (1U << 20);

    [NativeTypeName("#define TT_UCR_PHAGSPA (1UL << 21)")]
    public const nuint TT_UCR_PHAGSPA = (1U << 21);

    [NativeTypeName("#define TT_UCR_KANBUN TT_UCR_PHAGSPA")]
    public const nuint TT_UCR_KANBUN = (1U << 21);

    [NativeTypeName("#define TT_UCR_CJK_MISC TT_UCR_PHAGSPA")]
    public const nuint TT_UCR_CJK_MISC = (1U << 21);

    [NativeTypeName("#define TT_UCR_ENCLOSED_CJK_LETTERS_MONTHS (1UL << 22)")]
    public const nuint TT_UCR_ENCLOSED_CJK_LETTERS_MONTHS = (1U << 22);

    [NativeTypeName("#define TT_UCR_CJK_COMPATIBILITY (1UL << 23)")]
    public const nuint TT_UCR_CJK_COMPATIBILITY = (1U << 23);

    [NativeTypeName("#define TT_UCR_HANGUL (1UL << 24)")]
    public const nuint TT_UCR_HANGUL = (1U << 24);

    [NativeTypeName("#define TT_UCR_SURROGATES (1UL << 25)")]
    public const nuint TT_UCR_SURROGATES = (1U << 25);

    [NativeTypeName("#define TT_UCR_NON_PLANE_0 TT_UCR_SURROGATES")]
    public const nuint TT_UCR_NON_PLANE_0 = (1U << 25);

    [NativeTypeName("#define TT_UCR_PHOENICIAN (1UL << 26)")]
    public const nuint TT_UCR_PHOENICIAN = (1U << 26);

    [NativeTypeName("#define TT_UCR_CJK_UNIFIED_IDEOGRAPHS (1UL << 27)")]
    public const nuint TT_UCR_CJK_UNIFIED_IDEOGRAPHS = (1U << 27);

    [NativeTypeName("#define TT_UCR_PRIVATE_USE (1UL << 28)")]
    public const nuint TT_UCR_PRIVATE_USE = (1U << 28);

    [NativeTypeName("#define TT_UCR_CJK_COMPATIBILITY_IDEOGRAPHS (1UL << 29)")]
    public const nuint TT_UCR_CJK_COMPATIBILITY_IDEOGRAPHS = (1U << 29);

    [NativeTypeName("#define TT_UCR_ALPHABETIC_PRESENTATION_FORMS (1UL << 30)")]
    public const nuint TT_UCR_ALPHABETIC_PRESENTATION_FORMS = (1U << 30);

    [NativeTypeName("#define TT_UCR_ARABIC_PRESENTATION_FORMS_A (1UL << 31)")]
    public const nuint TT_UCR_ARABIC_PRESENTATION_FORMS_A = (1U << 31);

    [NativeTypeName("#define TT_UCR_COMBINING_HALF_MARKS (1UL <<  0)")]
    public const nuint TT_UCR_COMBINING_HALF_MARKS = (1U << 0);

    [NativeTypeName("#define TT_UCR_CJK_COMPATIBILITY_FORMS (1UL <<  1)")]
    public const nuint TT_UCR_CJK_COMPATIBILITY_FORMS = (1U << 1);

    [NativeTypeName("#define TT_UCR_SMALL_FORM_VARIANTS (1UL <<  2)")]
    public const nuint TT_UCR_SMALL_FORM_VARIANTS = (1U << 2);

    [NativeTypeName("#define TT_UCR_ARABIC_PRESENTATION_FORMS_B (1UL <<  3)")]
    public const nuint TT_UCR_ARABIC_PRESENTATION_FORMS_B = (1U << 3);

    [NativeTypeName("#define TT_UCR_HALFWIDTH_FULLWIDTH_FORMS (1UL <<  4)")]
    public const nuint TT_UCR_HALFWIDTH_FULLWIDTH_FORMS = (1U << 4);

    [NativeTypeName("#define TT_UCR_SPECIALS (1UL <<  5)")]
    public const nuint TT_UCR_SPECIALS = (1U << 5);

    [NativeTypeName("#define TT_UCR_TIBETAN (1UL <<  6)")]
    public const nuint TT_UCR_TIBETAN = (1U << 6);

    [NativeTypeName("#define TT_UCR_SYRIAC (1UL <<  7)")]
    public const nuint TT_UCR_SYRIAC = (1U << 7);

    [NativeTypeName("#define TT_UCR_THAANA (1UL <<  8)")]
    public const nuint TT_UCR_THAANA = (1U << 8);

    [NativeTypeName("#define TT_UCR_SINHALA (1UL <<  9)")]
    public const nuint TT_UCR_SINHALA = (1U << 9);

    [NativeTypeName("#define TT_UCR_MYANMAR (1UL << 10)")]
    public const nuint TT_UCR_MYANMAR = (1U << 10);

    [NativeTypeName("#define TT_UCR_ETHIOPIC (1UL << 11)")]
    public const nuint TT_UCR_ETHIOPIC = (1U << 11);

    [NativeTypeName("#define TT_UCR_CHEROKEE (1UL << 12)")]
    public const nuint TT_UCR_CHEROKEE = (1U << 12);

    [NativeTypeName("#define TT_UCR_CANADIAN_ABORIGINAL_SYLLABICS (1UL << 13)")]
    public const nuint TT_UCR_CANADIAN_ABORIGINAL_SYLLABICS = (1U << 13);

    [NativeTypeName("#define TT_UCR_OGHAM (1UL << 14)")]
    public const nuint TT_UCR_OGHAM = (1U << 14);

    [NativeTypeName("#define TT_UCR_RUNIC (1UL << 15)")]
    public const nuint TT_UCR_RUNIC = (1U << 15);

    [NativeTypeName("#define TT_UCR_KHMER (1UL << 16)")]
    public const nuint TT_UCR_KHMER = (1U << 16);

    [NativeTypeName("#define TT_UCR_MONGOLIAN (1UL << 17)")]
    public const nuint TT_UCR_MONGOLIAN = (1U << 17);

    [NativeTypeName("#define TT_UCR_BRAILLE (1UL << 18)")]
    public const nuint TT_UCR_BRAILLE = (1U << 18);

    [NativeTypeName("#define TT_UCR_YI (1UL << 19)")]
    public const nuint TT_UCR_YI = (1U << 19);

    [NativeTypeName("#define TT_UCR_PHILIPPINE (1UL << 20)")]
    public const nuint TT_UCR_PHILIPPINE = (1U << 20);

    [NativeTypeName("#define TT_UCR_OLD_ITALIC (1UL << 21)")]
    public const nuint TT_UCR_OLD_ITALIC = (1U << 21);

    [NativeTypeName("#define TT_UCR_GOTHIC (1UL << 22)")]
    public const nuint TT_UCR_GOTHIC = (1U << 22);

    [NativeTypeName("#define TT_UCR_DESERET (1UL << 23)")]
    public const nuint TT_UCR_DESERET = (1U << 23);

    [NativeTypeName("#define TT_UCR_MUSICAL_SYMBOLS (1UL << 24)")]
    public const nuint TT_UCR_MUSICAL_SYMBOLS = (1U << 24);

    [NativeTypeName("#define TT_UCR_MATH_ALPHANUMERIC_SYMBOLS (1UL << 25)")]
    public const nuint TT_UCR_MATH_ALPHANUMERIC_SYMBOLS = (1U << 25);

    [NativeTypeName("#define TT_UCR_PRIVATE_USE_SUPPLEMENTARY (1UL << 26)")]
    public const nuint TT_UCR_PRIVATE_USE_SUPPLEMENTARY = (1U << 26);

    [NativeTypeName("#define TT_UCR_VARIATION_SELECTORS (1UL << 27)")]
    public const nuint TT_UCR_VARIATION_SELECTORS = (1U << 27);

    [NativeTypeName("#define TT_UCR_TAGS (1UL << 28)")]
    public const nuint TT_UCR_TAGS = (1U << 28);

    [NativeTypeName("#define TT_UCR_LIMBU (1UL << 29)")]
    public const nuint TT_UCR_LIMBU = (1U << 29);

    [NativeTypeName("#define TT_UCR_TAI_LE (1UL << 30)")]
    public const nuint TT_UCR_TAI_LE = (1U << 30);

    [NativeTypeName("#define TT_UCR_NEW_TAI_LUE (1UL << 31)")]
    public const nuint TT_UCR_NEW_TAI_LUE = (1U << 31);

    [NativeTypeName("#define TT_UCR_BUGINESE (1UL <<  0)")]
    public const nuint TT_UCR_BUGINESE = (1U << 0);

    [NativeTypeName("#define TT_UCR_GLAGOLITIC (1UL <<  1)")]
    public const nuint TT_UCR_GLAGOLITIC = (1U << 1);

    [NativeTypeName("#define TT_UCR_TIFINAGH (1UL <<  2)")]
    public const nuint TT_UCR_TIFINAGH = (1U << 2);

    [NativeTypeName("#define TT_UCR_YIJING (1UL <<  3)")]
    public const nuint TT_UCR_YIJING = (1U << 3);

    [NativeTypeName("#define TT_UCR_SYLOTI_NAGRI (1UL <<  4)")]
    public const nuint TT_UCR_SYLOTI_NAGRI = (1U << 4);

    [NativeTypeName("#define TT_UCR_LINEAR_B (1UL <<  5)")]
    public const nuint TT_UCR_LINEAR_B = (1U << 5);

    [NativeTypeName("#define TT_UCR_ANCIENT_GREEK_NUMBERS (1UL <<  6)")]
    public const nuint TT_UCR_ANCIENT_GREEK_NUMBERS = (1U << 6);

    [NativeTypeName("#define TT_UCR_UGARITIC (1UL <<  7)")]
    public const nuint TT_UCR_UGARITIC = (1U << 7);

    [NativeTypeName("#define TT_UCR_OLD_PERSIAN (1UL <<  8)")]
    public const nuint TT_UCR_OLD_PERSIAN = (1U << 8);

    [NativeTypeName("#define TT_UCR_SHAVIAN (1UL <<  9)")]
    public const nuint TT_UCR_SHAVIAN = (1U << 9);

    [NativeTypeName("#define TT_UCR_OSMANYA (1UL << 10)")]
    public const nuint TT_UCR_OSMANYA = (1U << 10);

    [NativeTypeName("#define TT_UCR_CYPRIOT_SYLLABARY (1UL << 11)")]
    public const nuint TT_UCR_CYPRIOT_SYLLABARY = (1U << 11);

    [NativeTypeName("#define TT_UCR_KHAROSHTHI (1UL << 12)")]
    public const nuint TT_UCR_KHAROSHTHI = (1U << 12);

    [NativeTypeName("#define TT_UCR_TAI_XUAN_JING (1UL << 13)")]
    public const nuint TT_UCR_TAI_XUAN_JING = (1U << 13);

    [NativeTypeName("#define TT_UCR_CUNEIFORM (1UL << 14)")]
    public const nuint TT_UCR_CUNEIFORM = (1U << 14);

    [NativeTypeName("#define TT_UCR_COUNTING_ROD_NUMERALS (1UL << 15)")]
    public const nuint TT_UCR_COUNTING_ROD_NUMERALS = (1U << 15);

    [NativeTypeName("#define TT_UCR_SUNDANESE (1UL << 16)")]
    public const nuint TT_UCR_SUNDANESE = (1U << 16);

    [NativeTypeName("#define TT_UCR_LEPCHA (1UL << 17)")]
    public const nuint TT_UCR_LEPCHA = (1U << 17);

    [NativeTypeName("#define TT_UCR_OL_CHIKI (1UL << 18)")]
    public const nuint TT_UCR_OL_CHIKI = (1U << 18);

    [NativeTypeName("#define TT_UCR_SAURASHTRA (1UL << 19)")]
    public const nuint TT_UCR_SAURASHTRA = (1U << 19);

    [NativeTypeName("#define TT_UCR_KAYAH_LI (1UL << 20)")]
    public const nuint TT_UCR_KAYAH_LI = (1U << 20);

    [NativeTypeName("#define TT_UCR_REJANG (1UL << 21)")]
    public const nuint TT_UCR_REJANG = (1U << 21);

    [NativeTypeName("#define TT_UCR_CHAM (1UL << 22)")]
    public const nuint TT_UCR_CHAM = (1U << 22);

    [NativeTypeName("#define TT_UCR_ANCIENT_SYMBOLS (1UL << 23)")]
    public const nuint TT_UCR_ANCIENT_SYMBOLS = (1U << 23);

    [NativeTypeName("#define TT_UCR_PHAISTOS_DISC (1UL << 24)")]
    public const nuint TT_UCR_PHAISTOS_DISC = (1U << 24);

    [NativeTypeName("#define TT_UCR_OLD_ANATOLIAN (1UL << 25)")]
    public const nuint TT_UCR_OLD_ANATOLIAN = (1U << 25);

    [NativeTypeName("#define TT_UCR_GAME_TILES (1UL << 26)")]
    public const nuint TT_UCR_GAME_TILES = (1U << 26);

    [NativeTypeName("#define TT_UCR_ARABIC_PRESENTATION_A TT_UCR_ARABIC_PRESENTATION_FORMS_A")]
    public const nuint TT_UCR_ARABIC_PRESENTATION_A = (1U << 31);

    [NativeTypeName("#define TT_UCR_ARABIC_PRESENTATION_B TT_UCR_ARABIC_PRESENTATION_FORMS_B")]
    public const nuint TT_UCR_ARABIC_PRESENTATION_B = (1U << 3);

    [NativeTypeName("#define TT_UCR_COMBINING_DIACRITICS TT_UCR_COMBINING_DIACRITICAL_MARKS")]
    public const nuint TT_UCR_COMBINING_DIACRITICS = (1U << 6);

    [NativeTypeName("#define TT_UCR_COMBINING_DIACRITICS_SYMB TT_UCR_COMBINING_DIACRITICAL_MARKS_SYMB")]
    public const nuint TT_UCR_COMBINING_DIACRITICS_SYMB = (1U << 2);

    [NativeTypeName("#define ft_sfnt_head FT_SFNT_HEAD")]
    public const FT_Sfnt_Tag ft_sfnt_head = FT_Sfnt_Tag.HEAD;

    [NativeTypeName("#define ft_sfnt_maxp FT_SFNT_MAXP")]
    public const FT_Sfnt_Tag ft_sfnt_maxp = FT_Sfnt_Tag.MAXP;

    [NativeTypeName("#define ft_sfnt_os2 FT_SFNT_OS2")]
    public const FT_Sfnt_Tag ft_sfnt_os2 = FT_Sfnt_Tag.OS2;

    [NativeTypeName("#define ft_sfnt_hhea FT_SFNT_HHEA")]
    public const FT_Sfnt_Tag ft_sfnt_hhea = FT_Sfnt_Tag.HHEA;

    [NativeTypeName("#define ft_sfnt_vhea FT_SFNT_VHEA")]
    public const FT_Sfnt_Tag ft_sfnt_vhea = FT_Sfnt_Tag.VHEA;

    [NativeTypeName("#define ft_sfnt_post FT_SFNT_POST")]
    public const FT_Sfnt_Tag ft_sfnt_post = FT_Sfnt_Tag.POST;

    [NativeTypeName("#define ft_sfnt_pclt FT_SFNT_PCLT")]
    public const FT_Sfnt_Tag ft_sfnt_pclt = FT_Sfnt_Tag.PCLT;

    [NativeTypeName("#define TTAG_avar FT_MAKE_TAG( 'a', 'v', 'a', 'r' )")]
    public const uint TTAG_avar = (((uint)((byte)('a')) << 24) | ((uint)((byte)('v')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define TTAG_BASE FT_MAKE_TAG( 'B', 'A', 'S', 'E' )")]
    public const uint TTAG_BASE = (((uint)((byte)('B')) << 24) | ((uint)((byte)('A')) << 16) | ((uint)((byte)('S')) << 8) | (uint)((byte)('E')));

    [NativeTypeName("#define TTAG_bdat FT_MAKE_TAG( 'b', 'd', 'a', 't' )")]
    public const uint TTAG_bdat = (((uint)((byte)('b')) << 24) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_BDF FT_MAKE_TAG( 'B', 'D', 'F', ' ' )")]
    public const uint TTAG_BDF = (((uint)((byte)('B')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_bhed FT_MAKE_TAG( 'b', 'h', 'e', 'd' )")]
    public const uint TTAG_bhed = (((uint)((byte)('b')) << 24) | ((uint)((byte)('h')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('d')));

    [NativeTypeName("#define TTAG_bloc FT_MAKE_TAG( 'b', 'l', 'o', 'c' )")]
    public const uint TTAG_bloc = (((uint)((byte)('b')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('o')) << 8) | (uint)((byte)('c')));

    [NativeTypeName("#define TTAG_bsln FT_MAKE_TAG( 'b', 's', 'l', 'n' )")]
    public const uint TTAG_bsln = (((uint)((byte)('b')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('n')));

    [NativeTypeName("#define TTAG_CBDT FT_MAKE_TAG( 'C', 'B', 'D', 'T' )")]
    public const uint TTAG_CBDT = (((uint)((byte)('C')) << 24) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('D')) << 8) | (uint)((byte)('T')));

    [NativeTypeName("#define TTAG_CBLC FT_MAKE_TAG( 'C', 'B', 'L', 'C' )")]
    public const uint TTAG_CBLC = (((uint)((byte)('C')) << 24) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('L')) << 8) | (uint)((byte)('C')));

    [NativeTypeName("#define TTAG_CFF FT_MAKE_TAG( 'C', 'F', 'F', ' ' )")]
    public const uint TTAG_CFF = (((uint)((byte)('C')) << 24) | ((uint)((byte)('F')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_CFF2 FT_MAKE_TAG( 'C', 'F', 'F', '2' )")]
    public const uint TTAG_CFF2 = (((uint)((byte)('C')) << 24) | ((uint)((byte)('F')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)('2')));

    [NativeTypeName("#define TTAG_CID FT_MAKE_TAG( 'C', 'I', 'D', ' ' )")]
    public const uint TTAG_CID = (((uint)((byte)('C')) << 24) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('D')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_cmap FT_MAKE_TAG( 'c', 'm', 'a', 'p' )")]
    public const uint TTAG_cmap = (((uint)((byte)('c')) << 24) | ((uint)((byte)('m')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('p')));

    [NativeTypeName("#define TTAG_COLR FT_MAKE_TAG( 'C', 'O', 'L', 'R' )")]
    public const uint TTAG_COLR = (((uint)((byte)('C')) << 24) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('L')) << 8) | (uint)((byte)('R')));

    [NativeTypeName("#define TTAG_CPAL FT_MAKE_TAG( 'C', 'P', 'A', 'L' )")]
    public const uint TTAG_CPAL = (((uint)((byte)('C')) << 24) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('A')) << 8) | (uint)((byte)('L')));

    [NativeTypeName("#define TTAG_cvar FT_MAKE_TAG( 'c', 'v', 'a', 'r' )")]
    public const uint TTAG_cvar = (((uint)((byte)('c')) << 24) | ((uint)((byte)('v')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define TTAG_cvt FT_MAKE_TAG( 'c', 'v', 't', ' ' )")]
    public const uint TTAG_cvt = (((uint)((byte)('c')) << 24) | ((uint)((byte)('v')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_DSIG FT_MAKE_TAG( 'D', 'S', 'I', 'G' )")]
    public const uint TTAG_DSIG = (((uint)((byte)('D')) << 24) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('I')) << 8) | (uint)((byte)('G')));

    [NativeTypeName("#define TTAG_EBDT FT_MAKE_TAG( 'E', 'B', 'D', 'T' )")]
    public const uint TTAG_EBDT = (((uint)((byte)('E')) << 24) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('D')) << 8) | (uint)((byte)('T')));

    [NativeTypeName("#define TTAG_EBLC FT_MAKE_TAG( 'E', 'B', 'L', 'C' )")]
    public const uint TTAG_EBLC = (((uint)((byte)('E')) << 24) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('L')) << 8) | (uint)((byte)('C')));

    [NativeTypeName("#define TTAG_EBSC FT_MAKE_TAG( 'E', 'B', 'S', 'C' )")]
    public const uint TTAG_EBSC = (((uint)((byte)('E')) << 24) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('S')) << 8) | (uint)((byte)('C')));

    [NativeTypeName("#define TTAG_feat FT_MAKE_TAG( 'f', 'e', 'a', 't' )")]
    public const uint TTAG_feat = (((uint)((byte)('f')) << 24) | ((uint)((byte)('e')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_FOND FT_MAKE_TAG( 'F', 'O', 'N', 'D' )")]
    public const uint TTAG_FOND = (((uint)((byte)('F')) << 24) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('N')) << 8) | (uint)((byte)('D')));

    [NativeTypeName("#define TTAG_fpgm FT_MAKE_TAG( 'f', 'p', 'g', 'm' )")]
    public const uint TTAG_fpgm = (((uint)((byte)('f')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('g')) << 8) | (uint)((byte)('m')));

    [NativeTypeName("#define TTAG_fvar FT_MAKE_TAG( 'f', 'v', 'a', 'r' )")]
    public const uint TTAG_fvar = (((uint)((byte)('f')) << 24) | ((uint)((byte)('v')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define TTAG_gasp FT_MAKE_TAG( 'g', 'a', 's', 'p' )")]
    public const uint TTAG_gasp = (((uint)((byte)('g')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('p')));

    [NativeTypeName("#define TTAG_GDEF FT_MAKE_TAG( 'G', 'D', 'E', 'F' )")]
    public const uint TTAG_GDEF = (((uint)((byte)('G')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('E')) << 8) | (uint)((byte)('F')));

    [NativeTypeName("#define TTAG_glyf FT_MAKE_TAG( 'g', 'l', 'y', 'f' )")]
    public const uint TTAG_glyf = (((uint)((byte)('g')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('y')) << 8) | (uint)((byte)('f')));

    [NativeTypeName("#define TTAG_GPOS FT_MAKE_TAG( 'G', 'P', 'O', 'S' )")]
    public const uint TTAG_GPOS = (((uint)((byte)('G')) << 24) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('O')) << 8) | (uint)((byte)('S')));

    [NativeTypeName("#define TTAG_GSUB FT_MAKE_TAG( 'G', 'S', 'U', 'B' )")]
    public const uint TTAG_GSUB = (((uint)((byte)('G')) << 24) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('U')) << 8) | (uint)((byte)('B')));

    [NativeTypeName("#define TTAG_gvar FT_MAKE_TAG( 'g', 'v', 'a', 'r' )")]
    public const uint TTAG_gvar = (((uint)((byte)('g')) << 24) | ((uint)((byte)('v')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define TTAG_HVAR FT_MAKE_TAG( 'H', 'V', 'A', 'R' )")]
    public const uint TTAG_HVAR = (((uint)((byte)('H')) << 24) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('A')) << 8) | (uint)((byte)('R')));

    [NativeTypeName("#define TTAG_hdmx FT_MAKE_TAG( 'h', 'd', 'm', 'x' )")]
    public const uint TTAG_hdmx = (((uint)((byte)('h')) << 24) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define TTAG_head FT_MAKE_TAG( 'h', 'e', 'a', 'd' )")]
    public const uint TTAG_head = (((uint)((byte)('h')) << 24) | ((uint)((byte)('e')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('d')));

    [NativeTypeName("#define TTAG_hhea FT_MAKE_TAG( 'h', 'h', 'e', 'a' )")]
    public const uint TTAG_hhea = (((uint)((byte)('h')) << 24) | ((uint)((byte)('h')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('a')));

    [NativeTypeName("#define TTAG_hmtx FT_MAKE_TAG( 'h', 'm', 't', 'x' )")]
    public const uint TTAG_hmtx = (((uint)((byte)('h')) << 24) | ((uint)((byte)('m')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define TTAG_JSTF FT_MAKE_TAG( 'J', 'S', 'T', 'F' )")]
    public const uint TTAG_JSTF = (((uint)((byte)('J')) << 24) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('T')) << 8) | (uint)((byte)('F')));

    [NativeTypeName("#define TTAG_just FT_MAKE_TAG( 'j', 'u', 's', 't' )")]
    public const uint TTAG_just = (((uint)((byte)('j')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_kern FT_MAKE_TAG( 'k', 'e', 'r', 'n' )")]
    public const uint TTAG_kern = (((uint)((byte)('k')) << 24) | ((uint)((byte)('e')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('n')));

    [NativeTypeName("#define TTAG_lcar FT_MAKE_TAG( 'l', 'c', 'a', 'r' )")]
    public const uint TTAG_lcar = (((uint)((byte)('l')) << 24) | ((uint)((byte)('c')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('r')));

    [NativeTypeName("#define TTAG_loca FT_MAKE_TAG( 'l', 'o', 'c', 'a' )")]
    public const uint TTAG_loca = (((uint)((byte)('l')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)('a')));

    [NativeTypeName("#define TTAG_LTSH FT_MAKE_TAG( 'L', 'T', 'S', 'H' )")]
    public const uint TTAG_LTSH = (((uint)((byte)('L')) << 24) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('S')) << 8) | (uint)((byte)('H')));

    [NativeTypeName("#define TTAG_LWFN FT_MAKE_TAG( 'L', 'W', 'F', 'N' )")]
    public const uint TTAG_LWFN = (((uint)((byte)('L')) << 24) | ((uint)((byte)('W')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)('N')));

    [NativeTypeName("#define TTAG_MATH FT_MAKE_TAG( 'M', 'A', 'T', 'H' )")]
    public const uint TTAG_MATH = (((uint)((byte)('M')) << 24) | ((uint)((byte)('A')) << 16) | ((uint)((byte)('T')) << 8) | (uint)((byte)('H')));

    [NativeTypeName("#define TTAG_maxp FT_MAKE_TAG( 'm', 'a', 'x', 'p' )")]
    public const uint TTAG_maxp = (((uint)((byte)('m')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('x')) << 8) | (uint)((byte)('p')));

    [NativeTypeName("#define TTAG_META FT_MAKE_TAG( 'M', 'E', 'T', 'A' )")]
    public const uint TTAG_META = (((uint)((byte)('M')) << 24) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('T')) << 8) | (uint)((byte)('A')));

    [NativeTypeName("#define TTAG_MMFX FT_MAKE_TAG( 'M', 'M', 'F', 'X' )")]
    public const uint TTAG_MMFX = (((uint)((byte)('M')) << 24) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)('X')));

    [NativeTypeName("#define TTAG_MMSD FT_MAKE_TAG( 'M', 'M', 'S', 'D' )")]
    public const uint TTAG_MMSD = (((uint)((byte)('M')) << 24) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('S')) << 8) | (uint)((byte)('D')));

    [NativeTypeName("#define TTAG_mort FT_MAKE_TAG( 'm', 'o', 'r', 't' )")]
    public const uint TTAG_mort = (((uint)((byte)('m')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_morx FT_MAKE_TAG( 'm', 'o', 'r', 'x' )")]
    public const uint TTAG_morx = (((uint)((byte)('m')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define TTAG_MVAR FT_MAKE_TAG( 'M', 'V', 'A', 'R' )")]
    public const uint TTAG_MVAR = (((uint)((byte)('M')) << 24) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('A')) << 8) | (uint)((byte)('R')));

    [NativeTypeName("#define TTAG_name FT_MAKE_TAG( 'n', 'a', 'm', 'e' )")]
    public const uint TTAG_name = (((uint)((byte)('n')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('e')));

    [NativeTypeName("#define TTAG_opbd FT_MAKE_TAG( 'o', 'p', 'b', 'd' )")]
    public const uint TTAG_opbd = (((uint)((byte)('o')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('b')) << 8) | (uint)((byte)('d')));

    [NativeTypeName("#define TTAG_OS2 FT_MAKE_TAG( 'O', 'S', '/', '2' )")]
    public const uint TTAG_OS2 = (((uint)((byte)('O')) << 24) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('/')) << 8) | (uint)((byte)('2')));

    [NativeTypeName("#define TTAG_OTTO FT_MAKE_TAG( 'O', 'T', 'T', 'O' )")]
    public const uint TTAG_OTTO = (((uint)((byte)('O')) << 24) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('T')) << 8) | (uint)((byte)('O')));

    [NativeTypeName("#define TTAG_PCLT FT_MAKE_TAG( 'P', 'C', 'L', 'T' )")]
    public const uint TTAG_PCLT = (((uint)((byte)('P')) << 24) | ((uint)((byte)('C')) << 16) | ((uint)((byte)('L')) << 8) | (uint)((byte)('T')));

    [NativeTypeName("#define TTAG_POST FT_MAKE_TAG( 'P', 'O', 'S', 'T' )")]
    public const uint TTAG_POST = (((uint)((byte)('P')) << 24) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('S')) << 8) | (uint)((byte)('T')));

    [NativeTypeName("#define TTAG_post FT_MAKE_TAG( 'p', 'o', 's', 't' )")]
    public const uint TTAG_post = (((uint)((byte)('p')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_prep FT_MAKE_TAG( 'p', 'r', 'e', 'p' )")]
    public const uint TTAG_prep = (((uint)((byte)('p')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('p')));

    [NativeTypeName("#define TTAG_prop FT_MAKE_TAG( 'p', 'r', 'o', 'p' )")]
    public const uint TTAG_prop = (((uint)((byte)('p')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('o')) << 8) | (uint)((byte)('p')));

    [NativeTypeName("#define TTAG_sbix FT_MAKE_TAG( 's', 'b', 'i', 'x' )")]
    public const uint TTAG_sbix = (((uint)((byte)('s')) << 24) | ((uint)((byte)('b')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define TTAG_sfnt FT_MAKE_TAG( 's', 'f', 'n', 't' )")]
    public const uint TTAG_sfnt = (((uint)((byte)('s')) << 24) | ((uint)((byte)('f')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('t')));

    [NativeTypeName("#define TTAG_SING FT_MAKE_TAG( 'S', 'I', 'N', 'G' )")]
    public const uint TTAG_SING = (((uint)((byte)('S')) << 24) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('N')) << 8) | (uint)((byte)('G')));

    [NativeTypeName("#define TTAG_SVG FT_MAKE_TAG( 'S', 'V', 'G', ' ' )")]
    public const uint TTAG_SVG = (((uint)((byte)('S')) << 24) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('G')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_trak FT_MAKE_TAG( 't', 'r', 'a', 'k' )")]
    public const uint TTAG_trak = (((uint)((byte)('t')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('k')));

    [NativeTypeName("#define TTAG_true FT_MAKE_TAG( 't', 'r', 'u', 'e' )")]
    public const uint TTAG_true = (((uint)((byte)('t')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('u')) << 8) | (uint)((byte)('e')));

    [NativeTypeName("#define TTAG_ttc FT_MAKE_TAG( 't', 't', 'c', ' ' )")]
    public const uint TTAG_ttc = (((uint)((byte)('t')) << 24) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)(' ')));

    [NativeTypeName("#define TTAG_ttcf FT_MAKE_TAG( 't', 't', 'c', 'f' )")]
    public const uint TTAG_ttcf = (((uint)((byte)('t')) << 24) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)('f')));

    [NativeTypeName("#define TTAG_TYP1 FT_MAKE_TAG( 'T', 'Y', 'P', '1' )")]
    public const uint TTAG_TYP1 = (((uint)((byte)('T')) << 24) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('P')) << 8) | (uint)((byte)('1')));

    [NativeTypeName("#define TTAG_typ1 FT_MAKE_TAG( 't', 'y', 'p', '1' )")]
    public const uint TTAG_typ1 = (((uint)((byte)('t')) << 24) | ((uint)((byte)('y')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('1')));

    [NativeTypeName("#define TTAG_VDMX FT_MAKE_TAG( 'V', 'D', 'M', 'X' )")]
    public const uint TTAG_VDMX = (((uint)((byte)('V')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('M')) << 8) | (uint)((byte)('X')));

    [NativeTypeName("#define TTAG_vhea FT_MAKE_TAG( 'v', 'h', 'e', 'a' )")]
    public const uint TTAG_vhea = (((uint)((byte)('v')) << 24) | ((uint)((byte)('h')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('a')));

    [NativeTypeName("#define TTAG_vmtx FT_MAKE_TAG( 'v', 'm', 't', 'x' )")]
    public const uint TTAG_vmtx = (((uint)((byte)('v')) << 24) | ((uint)((byte)('m')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)('x')));

    [NativeTypeName("#define TTAG_VVAR FT_MAKE_TAG( 'V', 'V', 'A', 'R' )")]
    public const uint TTAG_VVAR = (((uint)((byte)('V')) << 24) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('A')) << 8) | (uint)((byte)('R')));

    [NativeTypeName("#define TTAG_wOFF FT_MAKE_TAG( 'w', 'O', 'F', 'F' )")]
    public const uint TTAG_wOFF = (((uint)((byte)('w')) << 24) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)('F')));

    [NativeTypeName("#define TTAG_wOF2 FT_MAKE_TAG( 'w', 'O', 'F', '2' )")]
    public const uint TTAG_wOF2 = (((uint)((byte)('w')) << 24) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('F')) << 8) | (uint)((byte)('2')));

    [NativeTypeName("#define TTAG_0xA5kbd FT_MAKE_TAG( 0xA5, 'k', 'b', 'd' )")]
    public const uint TTAG_0xA5kbd = (((uint)((byte)(0xA5)) << 24) | ((uint)((byte)('k')) << 16) | ((uint)((byte)('b')) << 8) | (uint)((byte)('d')));

    [NativeTypeName("#define TTAG_0xA5lst FT_MAKE_TAG( 0xA5, 'l', 's', 't' )")]
    public const uint TTAG_0xA5lst = (((uint)((byte)(0xA5)) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('t')));
}
