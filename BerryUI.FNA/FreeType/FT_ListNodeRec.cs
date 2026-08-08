namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_ListNodeRec
{
    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec* prev;

    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec* next;

    public void* data;
}
