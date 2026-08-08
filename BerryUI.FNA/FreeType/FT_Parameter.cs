namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Parameter
{
    [NativeTypeName("FT_ULong")]
    public nuint tag;

    [NativeTypeName("FT_Pointer")]
    public void* data;
}
