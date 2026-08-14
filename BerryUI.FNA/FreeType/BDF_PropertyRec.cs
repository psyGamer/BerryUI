using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct BDF_PropertyRec
{
    public unsafe BDF_PropertyType type;

    [NativeTypeName("__AnonymousRecord_ftbdf_L121_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    [GeneratedCode("ClangSharp", "22.1.8.0")]
    public unsafe partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const char *")]
        public sbyte* atom;

        [FieldOffset(0)]
        [NativeTypeName("FT_Int32")]
        public int integer;

        [FieldOffset(0)]
        [NativeTypeName("FT_UInt32")]
        public uint cardinal;
    }
}
