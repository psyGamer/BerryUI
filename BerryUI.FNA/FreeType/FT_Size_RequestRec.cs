namespace BerryUI.FNA.FreeType;

public partial struct FT_Size_RequestRec
{
    public FT_Size_Request_Type type;

    [NativeTypeName("FT_Long")]
    public nint width;

    [NativeTypeName("FT_Long")]
    public nint height;

    [NativeTypeName("FT_UInt")]
    public uint horiResolution;

    [NativeTypeName("FT_UInt")]
    public uint vertResolution;
}
