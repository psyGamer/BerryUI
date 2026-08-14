using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Incremental_InterfaceRec
{
    [NativeTypeName("const FT_Incremental_FuncsRec *")]
    public unsafe FT_Incremental_FuncsRec* funcs;

    [NativeTypeName("FT_Incremental")]
    public unsafe FT_IncrementalRec_* @object;
}
