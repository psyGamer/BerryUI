using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

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
    public static extern int FT_Set_Char_Size(FT_Face face, [NativeTypeName("FT_F26Dot6")] nint char_width, [NativeTypeName("FT_F26Dot6")] nint char_height, [NativeTypeName("FT_UInt")] uint horz_resolution, [NativeTypeName("FT_UInt")] uint vert_resolution);

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
}
