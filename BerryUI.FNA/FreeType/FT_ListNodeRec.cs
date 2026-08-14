using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_ListNodeRec
{
    [NativeTypeName("FT_ListNode")]
    public unsafe FT_ListNodeRec* prev;

    [NativeTypeName("FT_ListNode")]
    public unsafe FT_ListNodeRec* next;

    public void* data;
}
