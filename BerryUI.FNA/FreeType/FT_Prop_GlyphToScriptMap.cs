using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct FT_Prop_GlyphToScriptMap
{
    public unsafe FT_Face face;

    [NativeTypeName("FT_UShort *")]
    public ushort* map;
}
