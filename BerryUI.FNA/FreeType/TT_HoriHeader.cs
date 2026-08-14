using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct TT_HoriHeader
{
    [NativeTypeName("FT_Fixed")]
    public nint Version;

    [NativeTypeName("FT_Short")]
    public short Ascender;

    [NativeTypeName("FT_Short")]
    public short Descender;

    [NativeTypeName("FT_Short")]
    public short Line_Gap;

    [NativeTypeName("FT_UShort")]
    public ushort advance_Width_Max;

    [NativeTypeName("FT_Short")]
    public short min_Left_Side_Bearing;

    [NativeTypeName("FT_Short")]
    public short min_Right_Side_Bearing;

    [NativeTypeName("FT_Short")]
    public short xMax_Extent;

    [NativeTypeName("FT_Short")]
    public short caret_Slope_Rise;

    [NativeTypeName("FT_Short")]
    public short caret_Slope_Run;

    [NativeTypeName("FT_Short")]
    public short caret_Offset;

    [NativeTypeName("FT_Short[4]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("FT_Short")]
    public short metric_Data_Format;

    [NativeTypeName("FT_UShort")]
    public ushort number_Of_HMetrics;

    public void* long_metrics;

    public void* short_metrics;

    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public short e0;
    }
}
