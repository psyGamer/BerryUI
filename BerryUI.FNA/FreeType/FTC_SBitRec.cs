using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FTC_SBitRec
{
    [NativeTypeName("FT_Byte")]
    public byte width;

    [NativeTypeName("FT_Byte")]
    public byte height;

    [NativeTypeName("FT_Char")]
    public sbyte left;

    [NativeTypeName("FT_Char")]
    public sbyte top;

    [NativeTypeName("FT_Byte")]
    public byte format;

    [NativeTypeName("FT_Byte")]
    public byte max_grays;

    [NativeTypeName("FT_Short")]
    public short pitch;

    [NativeTypeName("FT_Char")]
    public sbyte xadvance;

    [NativeTypeName("FT_Char")]
    public sbyte yadvance;

    [NativeTypeName("FT_Byte *")]
    public byte* buffer;
}
