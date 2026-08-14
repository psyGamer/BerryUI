using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_MemoryRec_
{
    public void* user;

    [NativeTypeName("FT_Alloc_Func")]
    public delegate* unmanaged[Cdecl]<FT_Memory, nint, void*> alloc;

    [NativeTypeName("FT_Free_Func")]
    public delegate* unmanaged[Cdecl]<FT_Memory, void*, void> free;

    [NativeTypeName("FT_Realloc_Func")]
    public delegate* unmanaged[Cdecl]<FT_Memory, nint, nint, void*, void*> realloc;
}
