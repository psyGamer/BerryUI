using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_ListRec
{
    [NativeTypeName("FT_ListNode")]
    public unsafe FT_ListNodeRec* head;

    [NativeTypeName("FT_ListNode")]
    public unsafe FT_ListNodeRec* tail;
}
