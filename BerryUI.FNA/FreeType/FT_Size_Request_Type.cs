namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
public enum FT_Size_Request_Type : uint
{
    NOMINAL,
    REAL_DIM,
    BBOX,
    CELL,
    SCALES,
    MAX,
}
