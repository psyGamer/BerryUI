using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Size_RequestRec
{
    public unsafe FT_Size_Request_Type type;

    [NativeTypeName("FT_Long")]
    public nint width;

    [NativeTypeName("FT_Long")]
    public nint height;

    [NativeTypeName("FT_UInt")]
    public uint horiResolution;

    [NativeTypeName("FT_UInt")]
    public uint vertResolution;
}
