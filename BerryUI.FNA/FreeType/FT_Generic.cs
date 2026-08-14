using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Generic
{
    public void* data;

    [NativeTypeName("FT_Generic_Finalizer")]
    public delegate* unmanaged[Cdecl]<void*, void> finalizer;
}
