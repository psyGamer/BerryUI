using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct FT_COLR_Paint
{
    public FT_PaintFormat format;

    [NativeTypeName("__AnonymousRecord_ftcolor_L1322_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    [GeneratedCode("ClangSharp", "22.1.8.0")]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        public FT_PaintColrLayers colr_layers;

        [FieldOffset(0)]
        public FT_PaintGlyph glyph;

        [FieldOffset(0)]
        public FT_PaintSolid solid;

        [FieldOffset(0)]
        public FT_PaintLinearGradient linear_gradient;

        [FieldOffset(0)]
        public FT_PaintRadialGradient radial_gradient;

        [FieldOffset(0)]
        public FT_PaintSweepGradient sweep_gradient;

        [FieldOffset(0)]
        public FT_PaintTransform transform;

        [FieldOffset(0)]
        public FT_PaintTranslate translate;

        [FieldOffset(0)]
        public FT_PaintScale scale;

        [FieldOffset(0)]
        public FT_PaintRotate rotate;

        [FieldOffset(0)]
        public FT_PaintSkew skew;

        [FieldOffset(0)]
        public FT_PaintComposite composite;

        [FieldOffset(0)]
        public FT_PaintColrGlyph colr_glyph;
    }
}
