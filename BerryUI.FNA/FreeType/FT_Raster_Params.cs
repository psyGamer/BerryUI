namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Raster_Params
{
    [NativeTypeName("const FT_Bitmap *")]
    public FT_Bitmap* target;

    [NativeTypeName("const void *")]
    public void* source;

    public int flags;

    [NativeTypeName("FT_SpanFunc")]
    public delegate* unmanaged[Cdecl]<int, int, FT_Span*, void*, void> gray_spans;

    [NativeTypeName("FT_SpanFunc")]
    public delegate* unmanaged[Cdecl]<int, int, FT_Span*, void*, void> black_spans;

    [NativeTypeName("FT_Raster_BitTest_Func")]
    public delegate* unmanaged[Cdecl]<int, int, void*, int> bit_test;

    [NativeTypeName("FT_Raster_BitSet_Func")]
    public delegate* unmanaged[Cdecl]<int, int, void*, void> bit_set;

    public void* user;

    public FT_BBox clip_box;
}
