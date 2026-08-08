namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Outline_Funcs
{
    [NativeTypeName("FT_Outline_MoveToFunc")]
    public delegate* unmanaged[Cdecl]<FT_Vector*, void*, int> move_to;

    [NativeTypeName("FT_Outline_LineToFunc")]
    public delegate* unmanaged[Cdecl]<FT_Vector*, void*, int> line_to;

    [NativeTypeName("FT_Outline_ConicToFunc")]
    public delegate* unmanaged[Cdecl]<FT_Vector*, FT_Vector*, void*, int> conic_to;

    [NativeTypeName("FT_Outline_CubicToFunc")]
    public delegate* unmanaged[Cdecl]<FT_Vector*, FT_Vector*, FT_Vector*, void*, int> cubic_to;

    public int shift;

    [NativeTypeName("FT_Pos")]
    public nint delta;
}
