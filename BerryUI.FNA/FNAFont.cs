using BerryUI.FNA.FreeType;
using BerryUI.Render;
using BerryUI.SourceGen;
using BerryUI.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using BerryTexture = BerryUI.Render.Texture;
using BerryFont = BerryUI.Render.Font;
using BerryTextBlob = BerryUI.Render.TextBlob;
using FNAColor = Microsoft.Xna.Framework.Color;
using static BerryUI.FNA.FreeType.FreeType;
using static BerryUI.FNA.KbTextShape;

namespace BerryUI.FNA;

file class FreeTypeException(int err) : Exception {
    public override unsafe string Message => Marshal.PtrToStringUTF8((IntPtr)FT_Error_String(err)) ?? base.Message;
}

public sealed unsafe partial class FNAFont : IBackend.IFont, IDisposable {
    public record struct Glyph(
        ResourceHandle<Atlas.Entry> AtlasEntry,
        IPoint Offset,
        USize Size
    );

    [Bitpacked(bitSize: 32)]
    public readonly partial struct GlyphId {
        [BitfieldSize(bitSize: 20)] public partial uint GlyphIndex { get; }
        [BitfieldSize(bitSize: 10)] public partial uint AtlasIndex { get; }
        [BitfieldSize(bitSize: 2)] public partial uint SubpixelDivision { get; }
    }

    public const uint FontSubpixelDivisions = 4;
    public const uint FontMaximumPixelSize = 1023;

    private const uint FontAtlasSize = 256;
    private const uint FontAtlasPadding = 1;
    private const float FT_UnitSize = 64.0f;

    private static FT_Library Library;

    public readonly FT_Face FtFace;
    public readonly kbts_font KbFont;
    private GCHandle faceDataHandle;

    private Atlas?[] atlases = [];
    private readonly Dictionary<GlyphId, Glyph> glyphMap = new();
    private readonly List<(GlyphId ID, nint FtGlyph)> pendingGlyphs = new();

    public readonly ushort UnitsPerEm;
    public readonly short Ascent;
    public readonly short LineHeight;

    public ResourceHandle<BerryFont> Handle { get; set; }

    public FNAFont(byte[] data) {
        if (Library == null) {
            FT_Library libraryRef;
            Check(FT_Init_FreeType(&libraryRef));
            Library = libraryRef;
        }

        faceDataHandle = GCHandle.Alloc(data, GCHandleType.Pinned);

        FT_Face ftFace;
        Check(FT_New_Memory_Face(Library, (byte*)faceDataHandle.AddrOfPinnedObject(), data.Length, 0, &ftFace));

        var kbFont = kbts_FontFromMemory((byte*)faceDataHandle.AddrOfPinnedObject(), data.Length, 0, null, null);
        if (kbts_FontIsValid(&kbFont) == 0) {
            throw new Exception("Invalid font");
        }

        kbts_font_info2_2 info = default;
        info.Base.Size = (uint)sizeof(kbts_font_info2_1);
        kbts_GetFontInfo2(&kbFont, (kbts_font_info2*)&info);
        if (info.UnitsPerEm == 0) {
            throw new Exception("Invalid font");
        }

        FtFace = ftFace;
        KbFont = kbFont;
        UnitsPerEm = info.UnitsPerEm;
        Ascent = info.Ascent;
        LineHeight = (short)(info.Ascent - info.Descent + info.LineGap);
    }

    public void ApplySize(uint pixelSize) {
        float pointSize = pixelSize * BerryFont.PixelsToPoints;
        long pointSizeFrac = (long)(pointSize * FT_UnitSize);
        Check(FT_Set_Char_Size(FtFace, pointSizeFrac, pointSizeFrac, 0, 0));
    }

    /// Group multiple font sizes into the same atlas, based on some educated guesses
    public static uint GetAtlasIndex(uint pixelSize) {
        // Assume that we'll most likely won't render more than ~500 glyphs.
        // For latin languages this should be more than enough,
        // and for chinese/japanese it appears to cover about 80% of written text.
        // Other script probably compare similarly.
        // If the app isn't using many font sizes, the consequences of a too low estimate should be minimal.

        // C# is too stupid for compile-time square roots, so do the inverse instead...
        const uint expectedGlyphCountSqrt = 23;
        const uint expectedGlyphCount = expectedGlyphCountSqrt * expectedGlyphCountSqrt;

        // Account for padding
        uint glyphSize = pixelSize + FontAtlasPadding;

        // Once each font size would occupy more than a single atlas, limit the index to 1 atlas per size
        const uint maxFontSize = FontAtlasSize / expectedGlyphCountSqrt;
        if (glyphSize > maxFontSize) {
            const uint lastSharedIndex = (uint)(expectedGlyphCount / (float)(3 * FontAtlasSize * FontAtlasSize) * (maxFontSize * maxFontSize * maxFontSize));
            return glyphSize - (maxFontSize - lastSharedIndex);
        }

        // Contiguous solution for: \int_0^b{(s^2 * expectedGlyphCount)dx} = atlasIndex * FontAtlasSize^2
        // Should in theory be a discrete algorithm, but this is easier to compute and close enough
        return (uint)(expectedGlyphCount / (float)(3 * FontAtlasSize * FontAtlasSize) * (glyphSize * glyphSize * glyphSize));
    }

    public bool TryGetGlyph(GlyphId id, out Glyph glyph, out Atlas atlas) {
        atlas = atlases[id.AtlasIndex]!;
        return glyphMap.TryGetValue(id, out glyph);
    }

    public (GlyphId ID, Glyph Glyph) RegisterGlyph(uint glyphIndex, uint pixelSize, float frac) {
        uint subpxIndex = (uint)MathF.Round(frac * FontSubpixelDivisions) % FontSubpixelDivisions;
        uint atlasIndex = GetAtlasIndex(pixelSize);
        var id = new GlyphId(glyphIndex, atlasIndex, subpxIndex);

        if (glyphMap.TryGetValue(id, out var glyph)) {
            return (id, glyph);
        }

        ApplySize(pixelSize);
        Check(FT_Load_Glyph(FtFace, glyphIndex, FT_LOAD_DEFAULT | (int)FT_LOAD_COLOR | FT_LOAD_TARGET_LCD));

        FT_Glyph ftGlyph;
        Check(FT_Get_Glyph(FtFace->glyph, &ftGlyph));

        FT_Vector delta = new() {
            x = (long)(subpxIndex * (1.0f / FontSubpixelDivisions * FT_UnitSize)),
            y = 0
        };
        //Check(FT_Glyph_Transform(ftGlyph, null, &delta));

        FT_BBox boundingBox = default;
        FT_Glyph_Get_CBox(ftGlyph, (uint)FT_Glyph_BBox_Mode.GRIDFIT, &boundingBox);

        uint w = (uint)MathF.Ceiling((boundingBox.xMax - boundingBox.xMin) / FT_UnitSize);
        uint h = (uint)MathF.Ceiling((boundingBox.yMax - boundingBox.yMin) / FT_UnitSize);

        if (atlasIndex >= atlases.Length) {
            // Super-linear scaling by factor 1.5x
            Array.Resize(ref atlases, (int)(atlasIndex + atlasIndex / 2));
        }

        atlases[atlasIndex] ??= new Atlas(FontAtlasSize, FontAtlasPadding);

        glyphMap[id] = glyph = new Glyph(
            AtlasEntry: atlases[atlasIndex]!.Add(new USize(w, h)),
            Offset: new IPoint(FtFace->glyph->bitmap_left, -FtFace->glyph->bitmap_top),
            Size: new USize(w, h));
        pendingGlyphs.Add((id, (nint)ftGlyph));

        return (id, glyph);
    }

    /// Stores the newly added glyphs into the atlas.
    public void StoreNew(ResourcePool<BerryTexture, FNATexture> texturePool) {
        foreach (var atlas in atlases) {
            atlas?.PackAdded();
        }

        int bufferSize = 0;
        foreach ((var id, nint _) in pendingGlyphs) {
            var glyph = glyphMap[id];
            bufferSize = Math.Max(bufferSize, (int)(glyph.Size.Width * glyph.Size.Height * Unsafe.SizeOf<FNAColor>()));
        }

        Span<byte> uploadBuffer = stackalloc byte[bufferSize];

        foreach ((var id, nint ftGlyphPtr) in pendingGlyphs) {
            var glyph = glyphMap[id];
            var atlas = atlases[id.AtlasIndex]!;

            var ftGlyph = (FT_Glyph)ftGlyphPtr;

            // Render glyph into buffer
            Check(FT_Glyph_To_Bitmap(&ftGlyph, FT_Render_Mode.LCD, null, 1));

            var glyphTexture = atlas.GetTexture(glyph.AtlasEntry);
            var atlasTexture = texturePool[glyphTexture.Handle];
            uint width = glyphTexture.Source.Width;
            uint height = glyphTexture.Source.Height;
            uint bufferLength = (uint)(width * height * Unsafe.SizeOf<FNAColor>());

            if (bufferLength > 0) {
                var bmpGlyph = (FT_BitmapGlyph)ftGlyph;
                var bmp = bmpGlyph->bitmap;

                fixed (byte* bufferPtr = uploadBuffer) {
                    Unsafe.InitBlock(bufferPtr, 0x00, bufferLength);

                    for (uint y = 0; y < height; y++) {
                        byte* src = bmp.buffer + (y * bmp.pitch);
                        byte* dst = bufferPtr + (y * width * Unsafe.SizeOf<FNAColor>());

                        switch ((FT_Pixel_Mode)bmp.pixel_mode) {
                            case FT_Pixel_Mode.GRAY:
                                for (uint x = 0; x < width; x++) {
                                    byte val = *src++;
                                    *dst++ = val;
                                    *dst++ = val;
                                    *dst++ = val;
                                    *dst++ = val;
                                }

                                break;
                            case FT_Pixel_Mode.LCD:
                                for (uint x = 0; x < width; x++) {
                                    *dst++ = *src++;
                                    *dst++ = *src++;
                                    *dst++ = *src++;
                                    *dst++ = 0xFF;
                                }

                                break;

                            default:
                                throw new Exception($"Unhandled pixel mode: {(FT_Pixel_Mode)bmp.pixel_mode}");
                        }
                    }

                    atlasTexture.Texture.SetDataPointerEXT(0, glyphTexture.Source.ToFNA(), (IntPtr)bufferPtr, (int)bufferLength);
                }
            }

            // Free the glyph
            FT_Done_Glyph(ftGlyph);
        }

        pendingGlyphs.Clear();
    }

    public void Dispose() {
        foreach (var atlas in atlases) {
            atlas?.Dispose();
        }

        fixed (kbts_font* kbFont = &KbFont) {
            kbts_FreeFont(kbFont);
        }

        FT_Done_Face(FtFace);
        faceDataHandle.Free();
    }

    private static void Check(int err) {
        if (err != FT_Err_Ok) {
            throw new FreeTypeException(err);
        }
    }
}

public sealed unsafe class FNATextBlob(FNAFont font, uint pixelSize, USize bounds, FNATextBlob.GlyphEntry[] entries) : IBackend.ITextBlob, IDisposable {
    public readonly record struct GlyphEntry(FNAFont.GlyphId ID, Point<ushort> Offset);

    public ResourceHandle<BerryTextBlob> Handle { get; set; }
    public USize Bounds => bounds;

    public readonly FNAFont Font = font;
    public readonly uint PixelSize = pixelSize;
    public readonly GlyphEntry[] Entries = entries;

    public static FNATextBlob ShapeSimple(FNAFont font, uint pixelSize, ReadOnlySpan<char> text, float maxWidth) {
        int byteCount = Encoding.UTF8.GetByteCount(text);
        Span<byte> byteBuffer = stackalloc byte[byteCount];
        int encodedBytes = Encoding.UTF8.GetBytes(text, byteBuffer);

        int entryIdx = 0;
        Span<GlyphEntry> entries = stackalloc GlyphEntry[encodedBytes];

        float scale = (pixelSize * BerryFont.PixelsToPoints) / font.UnitsPerEm;
        var currPos = new Vector2(0.0f, font.Ascent * scale);

        var bounds = FSize.Zero;

        var context = kbts_CreateShapeContext(null, null);
        try {
            fixed (kbts_font* kbFont = &font.KbFont)
            fixed (byte* data = byteBuffer) {
                kbts_ShapePushFont(context, kbFont);

                kbts_ShapeBegin(context, kbts_direction.DONT_KNOW, kbts_language.DONT_KNOW);
                kbts_ShapePushFeature(context, (uint)kbts_feature_tag.kern, 1);
                kbts_ShapeUtf8(context, (sbyte*)data, encodedBytes, kbts_user_id_generation_mode.CODEPOINT_INDEX);
                kbts_ShapeEnd(context);

                kbts_run run = default;
                while (kbts_ShapeRun(context, &run) != 0) {
                    if ((run.Flags & kbts_break_flags.LINE_HARD) != 0) {
                        currPos.X = 0.0f;
                        currPos.Y += font.LineHeight * scale;
                    }

                    kbts_glyph* kbGlyph = null;
                    while (kbts_GlyphIteratorNext(&run.Glyphs, &kbGlyph) != 0) {
                        if (kbGlyph->Codepoint == '\n') {
                            // Avoid rendering newline
                            continue;
                        }

                        float advance = MathF.Round(kbGlyph->AdvanceX * scale);
                        float nextX = currPos.X + advance;
                        // TODO: Use a soft line break
                        if (nextX > maxWidth) {
                            currPos.X = 0.0f;
                            currPos.Y += font.LineHeight * scale;
                        }

                        var renderPos = currPos + new Vector2(kbGlyph->OffsetX * scale, kbGlyph->OffsetY * scale);
                        var (id, glyph) = font.RegisterGlyph(
                            glyphIndex: kbGlyph->Id,
                            pixelSize,
                            frac: renderPos.X - MathF.Truncate(renderPos.X));

                        bounds.Width = MathF.Max(bounds.Width, currPos.X + glyph.Offset.X + glyph.Size.Width);
                        bounds.Height = MathF.Max(bounds.Height, currPos.Y + glyph.Offset.Y + glyph.Size.Height);

                        entries[entryIdx++] = new GlyphEntry(id, new Point<ushort>((ushort)renderPos.X, (ushort)renderPos.Y));

                        currPos.X += advance;
                    }
                }

                kbts_ShapePopFont(context);
            }

            return new FNATextBlob(font, pixelSize, new USize((uint)bounds.Width, (uint)bounds.Height), entries.ToArray());
        } finally {
            kbts_DestroyShapeContext(context);
        }
    }

    public void Render(SpriteBatch batch, UPoint position, ResourcePool<BerryTexture, FNATexture> texturePool) {
        // Rendering assumes pixel origin, so enforce that constraint
        foreach (var entry in Entries) {
            if (!Font.TryGetGlyph(entry.ID, out var glyph, out var atlas)) {
                // The font doesn't contain the glyph
                continue;
            }

            var glyphTexture = atlas.GetTexture(glyph.AtlasEntry);
            var atlasTexture = texturePool[glyphTexture.Handle];

            // batch.Draw(
            //     texture: atlasTexture.Texture,
            //     position: new Vector2(
            //         x: position.X + entry.Offset.X + glyph.Offset.X,
            //         y: position.Y + entry.Offset.Y + glyph.Offset.Y),
            //     sourceRectangle: glyphTexture.Source.ToFNA(),
            //     color: FNAColor.Red,
            //     rotation: 0.0f,
            //     origin: Vector2.Zero,
            //     scale: Vector2.One,
            //     effects: SpriteEffects.None,
            //     layerDepth: 0.0f);

            // batch.Draw(
            //     texture: atlasTexture.Texture,
            //     position: new Vector2(
            //         x: position.X + entry.Offset.X + glyph.Offset.X,
            //         y: position.Y + entry.Offset.Y + glyph.Offset.Y),
            //     sourceRectangle: glyphTexture.Source.ToFNA(),
            //     color: FNAColor.Blue,
            //     rotation: 0.0f,
            //     origin: Vector2.Zero,
            //     scale: Vector2.One,
            //     effects: SpriteEffects.None,
            //     layerDepth: 0.0f);

            batch.Draw(
                texture: atlasTexture.Texture,
                position: new Vector2(
                    x: position.X + entry.Offset.X + glyph.Offset.X,
                    y: position.Y + entry.Offset.Y + glyph.Offset.Y),
                sourceRectangle: glyphTexture.Source.ToFNA(),
                color: FNAColor.White,
                rotation: 0.0f,
                origin: Vector2.Zero,
                scale: Vector2.One,
                effects: SpriteEffects.None,
                layerDepth: 0.0f);
        }
    }

    public void Dispose() { }
}
