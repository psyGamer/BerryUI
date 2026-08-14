using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct CID_FaceDictRec
{
    public unsafe PS_PrivateRec private_dict;

    [NativeTypeName("FT_UInt")]
    public uint len_buildchar;

    [NativeTypeName("FT_Fixed")]
    public nint forcebold_threshold;

    [NativeTypeName("FT_Pos")]
    public long stroke_width;

    [NativeTypeName("FT_Fixed")]
    public nint expansion_factor;

    [NativeTypeName("FT_Byte")]
    public byte paint_type;

    [NativeTypeName("FT_Byte")]
    public byte font_type;

    public FT_Matrix font_matrix;

    public FT_Vector font_offset;

    [NativeTypeName("FT_UInt")]
    public uint num_subrs;

    [NativeTypeName("FT_ULong")]
    public nuint subrmap_offset;

    [NativeTypeName("FT_UInt")]
    public uint sd_bytes;
}
