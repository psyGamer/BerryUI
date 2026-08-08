namespace BerryUI.FNA.FreeType;

public partial struct FT_CharMapRec
{
    public unsafe FT_Face face;

    public FT_Encoding encoding;

    [NativeTypeName("FT_UShort")]
    public ushort platform_id;

    [NativeTypeName("FT_UShort")]
    public ushort encoding_id;
}
