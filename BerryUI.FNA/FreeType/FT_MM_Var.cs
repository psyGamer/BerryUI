using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_MM_Var
{
    [NativeTypeName("FT_UInt")]
    public uint num_axis;

    [NativeTypeName("FT_UInt")]
    public uint num_designs;

    [NativeTypeName("FT_UInt")]
    public uint num_namedstyles;

    public FT_Var_Axis* axis;

    public FT_Var_Named_Style* namedstyle;
}
