using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Var_Axis
{
    [NativeTypeName("FT_String *")]
    public sbyte* name;

    [NativeTypeName("FT_Fixed")]
    public nint minimum;

    [NativeTypeName("FT_Fixed")]
    public nint def;

    [NativeTypeName("FT_Fixed")]
    public nint maximum;

    [NativeTypeName("FT_ULong")]
    public nuint tag;

    [NativeTypeName("FT_UInt")]
    public uint strid;
}
