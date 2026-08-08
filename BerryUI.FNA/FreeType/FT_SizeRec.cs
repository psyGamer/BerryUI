namespace BerryUI.FNA.FreeType;

public partial struct FT_SizeRec
{
    public unsafe FT_Face face;

    public FT_Generic generic;

    public FT_Size_Metrics metrics;

    public unsafe FT_Size_Internal @internal;
}
