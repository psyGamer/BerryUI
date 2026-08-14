using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FTC_ScalerRec
{
    [NativeTypeName("FTC_FaceID")]
    public void* face_id;

    [NativeTypeName("FT_UInt")]
    public uint width;

    [NativeTypeName("FT_UInt")]
    public uint height;

    [NativeTypeName("FT_Int")]
    public int pixel;

    [NativeTypeName("FT_UInt")]
    public uint x_res;

    [NativeTypeName("FT_UInt")]
    public uint y_res;
}
