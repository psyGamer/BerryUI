namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Data
{
    [NativeTypeName("const FT_Byte *")]
    public byte* pointer;

    [NativeTypeName("FT_UInt")]
    public uint length;
}
