using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FTC_ImageTypeRec
{
    [NativeTypeName("FTC_FaceID")]
    public void* face_id;

    [NativeTypeName("FT_UInt")]
    public uint width;

    [NativeTypeName("FT_UInt")]
    public uint height;

    [NativeTypeName("FT_Int32")]
    public int flags;
}
