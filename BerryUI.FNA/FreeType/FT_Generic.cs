namespace BerryUI.FNA.FreeType;

public unsafe partial struct FT_Generic
{
    public void* data;

    [NativeTypeName("FT_Generic_Finalizer")]
    public delegate* unmanaged[Cdecl]<void*, void> finalizer;
}
