using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_LayerIterator
{
    [NativeTypeName("FT_UInt")]
    public uint num_layers;

    [NativeTypeName("FT_UInt")]
    public uint layer;

    [NativeTypeName("FT_Byte *")]
    public byte* p;
}
