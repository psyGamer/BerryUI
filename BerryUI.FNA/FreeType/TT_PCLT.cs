using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct TT_PCLT
{
    [NativeTypeName("FT_Fixed")]
    public nint Version;

    [NativeTypeName("FT_ULong")]
    public nuint FontNumber;

    [NativeTypeName("FT_UShort")]
    public ushort Pitch;

    [NativeTypeName("FT_UShort")]
    public ushort xHeight;

    [NativeTypeName("FT_UShort")]
    public ushort Style;

    [NativeTypeName("FT_UShort")]
    public ushort TypeFamily;

    [NativeTypeName("FT_UShort")]
    public ushort CapHeight;

    [NativeTypeName("FT_UShort")]
    public ushort SymbolSet;

    [NativeTypeName("FT_Char[16]")]
    public _TypeFace_e__FixedBuffer TypeFace;

    [NativeTypeName("FT_Char[8]")]
    public _CharacterComplement_e__FixedBuffer CharacterComplement;

    [NativeTypeName("FT_Char[6]")]
    public _FileName_e__FixedBuffer FileName;

    [NativeTypeName("FT_Char")]
    public sbyte StrokeWeight;

    [NativeTypeName("FT_Char")]
    public sbyte WidthType;

    [NativeTypeName("FT_Byte")]
    public byte SerifStyle;

    [NativeTypeName("FT_Byte")]
    public byte Reserved;

    [InlineArray(16)]
    public partial struct _TypeFace_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(8)]
    public partial struct _CharacterComplement_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(6)]
    public partial struct _FileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
