using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Outline
{
    [NativeTypeName("unsigned short")]
    public ushort n_contours;

    [NativeTypeName("unsigned short")]
    public ushort n_points;

    public FT_Vector* points;

    [NativeTypeName("unsigned char *")]
    public byte* tags;

    [NativeTypeName("unsigned short *")]
    public ushort* contours;

    public int flags;
}
