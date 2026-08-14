using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Size_Request_Type : uint
{
    NOMINAL,
    REAL_DIM,
    BBOX,
    CELL,
    SCALES,
    MAX,
}
