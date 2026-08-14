using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct CID_FaceInfoRec
{
    [NativeTypeName("FT_String *")]
    public sbyte* cid_font_name;

    [NativeTypeName("FT_Fixed")]
    public nint cid_version;

    [NativeTypeName("FT_Int")]
    public int cid_font_type;

    [NativeTypeName("FT_String *")]
    public sbyte* registry;

    [NativeTypeName("FT_String *")]
    public sbyte* ordering;

    [NativeTypeName("FT_Int")]
    public int supplement;

    public unsafe PS_FontInfoRec font_info;

    public FT_BBox font_bbox;

    [NativeTypeName("FT_ULong")]
    public nuint uid_base;

    [NativeTypeName("FT_Int")]
    public int num_xuid;

    [NativeTypeName("FT_ULong[16]")]
    public _xuid_e__FixedBuffer xuid;

    [NativeTypeName("FT_ULong")]
    public nuint cidmap_offset;

    [NativeTypeName("FT_UInt")]
    public uint fd_bytes;

    [NativeTypeName("FT_UInt")]
    public uint gd_bytes;

    [NativeTypeName("FT_ULong")]
    public nuint cid_count;

    [NativeTypeName("FT_UInt")]
    public uint num_dicts;

    [NativeTypeName("CID_FaceDict")]
    public unsafe CID_FaceDictRec* font_dicts;

    [NativeTypeName("FT_ULong")]
    public nuint data_offset;

    [InlineArray(16)]
    public partial struct _xuid_e__FixedBuffer
    {
        public nuint e0;
    }
}
