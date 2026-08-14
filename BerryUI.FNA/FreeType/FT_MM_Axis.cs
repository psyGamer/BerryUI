using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_MM_Axis
{
    [NativeTypeName("FT_String *")]
    public sbyte* name;

    [NativeTypeName("FT_Long")]
    public nint minimum;

    [NativeTypeName("FT_Long")]
    public nint maximum;
}
