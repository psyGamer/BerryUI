using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_CharMapRec
{
    public unsafe FT_Face face;

    public FT_Encoding encoding;

    [NativeTypeName("FT_UShort")]
    public ushort platform_id;

    [NativeTypeName("FT_UShort")]
    public ushort encoding_id;
}
