namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Open_Args
{
    [NativeTypeName("FT_UInt")]
    public uint flags;

    [NativeTypeName("const FT_Byte *")]
    public byte* memory_base;

    [NativeTypeName("FT_Long")]
    public nint memory_size;

    [NativeTypeName("FT_String *")]
    public sbyte* pathname;

    [NativeTypeName("FT_Stream")]
    public FT_StreamRec* stream;

    public unsafe FT_Module driver;

    [NativeTypeName("FT_Int")]
    public int num_params;

    public FT_Parameter* @params;
}
