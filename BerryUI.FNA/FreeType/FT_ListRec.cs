namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_ListRec
{
    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec* head;

    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec* tail;
}
