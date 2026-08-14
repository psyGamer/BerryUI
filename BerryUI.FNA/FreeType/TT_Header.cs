using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct TT_Header
{
    [NativeTypeName("FT_Fixed")]
    public nint Table_Version;

    [NativeTypeName("FT_Fixed")]
    public nint Font_Revision;

    [NativeTypeName("FT_Long")]
    public nint CheckSum_Adjust;

    [NativeTypeName("FT_Long")]
    public nint Magic_Number;

    [NativeTypeName("FT_UShort")]
    public ushort Flags;

    [NativeTypeName("FT_UShort")]
    public ushort Units_Per_EM;

    [NativeTypeName("FT_ULong[2]")]
    public _Created_e__FixedBuffer Created;

    [NativeTypeName("FT_ULong[2]")]
    public _Modified_e__FixedBuffer Modified;

    [NativeTypeName("FT_Short")]
    public short xMin;

    [NativeTypeName("FT_Short")]
    public short yMin;

    [NativeTypeName("FT_Short")]
    public short xMax;

    [NativeTypeName("FT_Short")]
    public short yMax;

    [NativeTypeName("FT_UShort")]
    public ushort Mac_Style;

    [NativeTypeName("FT_UShort")]
    public ushort Lowest_Rec_PPEM;

    [NativeTypeName("FT_Short")]
    public short Font_Direction;

    [NativeTypeName("FT_Short")]
    public short Index_To_Loc_Format;

    [NativeTypeName("FT_Short")]
    public short Glyph_Data_Format;

    [InlineArray(2)]
    public partial struct _Created_e__FixedBuffer
    {
        public nuint e0;
    }

    [InlineArray(2)]
    public partial struct _Modified_e__FixedBuffer
    {
        public nuint e0;
    }
}
