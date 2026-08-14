using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Var_Named_Style
{
    [NativeTypeName("FT_Fixed *")]
    public nint* coords;

    [NativeTypeName("FT_UInt")]
    public uint strid;

    [NativeTypeName("FT_UInt")]
    public uint psid;
}
