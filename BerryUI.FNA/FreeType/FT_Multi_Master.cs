using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_Multi_Master
{
    [NativeTypeName("FT_UInt")]
    public uint num_axis;

    [NativeTypeName("FT_UInt")]
    public uint num_designs;

    [NativeTypeName("FT_MM_Axis[4]")]
    public _axis_e__FixedBuffer axis;

    [InlineArray(4)]
    public partial struct _axis_e__FixedBuffer
    {
        public FT_MM_Axis e0;
    }
}
