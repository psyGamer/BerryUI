namespace BerryUI.FNA.FreeType;

public partial struct FT_Span
{
    [NativeTypeName("unsigned short")]
    public ushort x;

    [NativeTypeName("unsigned short")]
    public ushort len;

    [NativeTypeName("unsigned char")]
    public byte coverage;
}
