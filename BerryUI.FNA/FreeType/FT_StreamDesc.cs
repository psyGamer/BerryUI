using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FT_StreamDesc
{
    [FieldOffset(0)]
    [NativeTypeName("long")]
    public nint value;

    [FieldOffset(0)]
    public void* pointer;
}
