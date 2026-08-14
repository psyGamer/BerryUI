using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

[StructLayout(LayoutKind.Explicit)]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_StreamDesc
{
    [FieldOffset(0)]
    [NativeTypeName("long")]
    public nint value;

    [FieldOffset(0)]
    public void* pointer;
}
