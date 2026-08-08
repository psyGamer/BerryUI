namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_StreamRec
{
    [NativeTypeName("unsigned char *")]
    public byte* @base;

    [NativeTypeName("unsigned long")]
    public nuint size;

    [NativeTypeName("unsigned long")]
    public nuint pos;

    public FT_StreamDesc descriptor;

    public FT_StreamDesc pathname;

    [NativeTypeName("FT_Stream_IoFunc")]
    public delegate* unmanaged[Cdecl]<FT_StreamRec*, nuint, byte*, nuint, nuint> read;

    [NativeTypeName("FT_Stream_CloseFunc")]
    public delegate* unmanaged[Cdecl]<FT_StreamRec*, void> close;

    public unsafe FT_Memory memory;

    [NativeTypeName("unsigned char *")]
    public byte* cursor;

    [NativeTypeName("unsigned char *")]
    public byte* limit;
}
