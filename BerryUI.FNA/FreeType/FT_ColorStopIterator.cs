using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_ColorStopIterator
{
    [NativeTypeName("FT_UInt")]
    public uint num_color_stops;

    [NativeTypeName("FT_UInt")]
    public uint current_color_stop;

    [NativeTypeName("FT_Byte *")]
    public byte* p;

    [NativeTypeName("FT_Bool")]
    public byte read_variable;
}
