using BerryUI.FNA.FreeType;
using BerryUI.Render;
using BerryUI.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BerryTexture = BerryUI.Render.Texture;
using BerryFontFamily = BerryUI.Render.FontFamily;
using BerryFontFace = BerryUI.Render.FontFace;
using FNAColor = Microsoft.Xna.Framework.Color;
using static BerryUI.FNA.FreeType.FreeType;

namespace BerryUI.FNA;

file class FreeTypeException(int err) : Exception {
    public override unsafe string Message => Marshal.PtrToStringUTF8((IntPtr)FT_Error_String(err)) ?? base.Message;
}

file ref struct CodepointEnumerator(ReadOnlySpan<char> text) : IEnumerator<int> {
    private readonly ReadOnlySpan<char> text = text;
    private int index;
    private int codepoint;

    public int Current => codepoint;
    object IEnumerator.Current => Current;

    public bool MoveNext() {
        if (index >= text.Length) {
            return false;
        }

        if (index + 1 < text.Length) {
            char high = text[index];
            char low = text[index + 1];

            bool surrogate = char.IsSurrogatePair(high, low);
            index += surrogate ? 2 : 1;

            codepoint = surrogate ? char.ConvertToUtf32(high, low) : high;
        } else {
            codepoint = text[index];
            index += 1;
        }

        return true;
    }

    public void Reset() {
        index = 0;
    }

    public void Dispose() { }
}

public unsafe class FNAFontFamily : IBackend.IFontFamily, IDisposable {
    public ResourceHandle<BerryFontFamily> Handle { get; set; }

    internal static FT_Library Library;

    private GCHandle faceDataHandle;
    internal readonly FT_Face Face;

    public FNAFontFamily(byte[] data) {
        if (Library == null) {
            FT_Library libraryRef;
            Check(FT_Init_FreeType(&libraryRef));
            Library = libraryRef;
        }

        faceDataHandle = GCHandle.Alloc(data, GCHandleType.Pinned);

        FT_Face faceRef;
        Check(FT_New_Memory_Face(Library, (byte*)faceDataHandle.AddrOfPinnedObject(), data.Length, 0, &faceRef));
        Face = faceRef;
    }

    public void Dispose() {
        if (Face != null) {
            FT_Done_Face(Face);
        }

        if (faceDataHandle.IsAllocated) {
            faceDataHandle.Free();
        }
    }

    private static void Check(int err) {
        if (err != FT_Err_Ok) {
            throw new FreeTypeException(err);
        }
    }
}

public unsafe class FNAFontFace(FNAFontFamily family, float size) : IBackend.IFontFace, IDisposable {
    private readonly record struct Glyph(
        ResourceHandle<Atlas.Entry> AtlasEntry,
        URect Source,
        uint Advance
    );

    private const uint FontAtlasSize = 256;
    private const uint FontAtlasPadding = 8;

    public ResourceHandle<BerryFontFace> Handle { get; set; }

    private readonly Atlas atlas = new(FontAtlasSize, FontAtlasPadding);
    private readonly Dictionary<int, Glyph> glyphMap = new();
    private readonly List<int> pendingGlyphs = new();
    private byte[] uploadBuffer = [];

    /// Renders a previously registered text into the sprite batch.
    public void RenderText(ReadOnlySpan<char> text, SpriteBatch batch, Vector2 position, ResourcePool<BerryTexture, FNATexture> texturePool) {
        var face = family.Face;

        // TODO: DPI-awareness
        FT_Set_Pixel_Sizes(face, 0, (uint)size);

        uint ascend = (uint)(face->size->metrics.ascender >> 6);
        position.Y += ascend;

        var iter = new CodepointEnumerator(text);
        while (iter.MoveNext()) {
            int codepoint = iter.Current;
            if (!glyphMap.TryGetValue(codepoint, out var glyph)) {
                // The font doesn't contain a glyph
                continue;
            }

            var glyphTexture = atlas.GetTexture(glyph.AtlasEntry);
            var atlasTexture = texturePool[glyphTexture.Handle];

            batch.Draw(
                texture: atlasTexture.Texture,
                position: new Vector2(position.X + glyph.Source.X, position.Y - glyph.Source.Y),
                sourceRectangle: glyphTexture.Source.ToFNA(),
                color: FNAColor.White,
                rotation: 0.0f,
                origin: Vector2.Zero,
                scale: Vector2.One,
                effects: SpriteEffects.None,
                layerDepth: 0.0f);

            position.X += glyph.Advance;
        }
    }

    /// Ensures all glyphs of the text have been placed into the atlas.
    public void RegisterText(ReadOnlySpan<char> text) {
        var face = family.Face;

        // TODO: DPI-awareness
        FT_Set_Pixel_Sizes(face, 0, (uint)size);

        var iter = new CodepointEnumerator(text);
        while (iter.MoveNext()) {
            int codepoint = iter.Current;
            if (glyphMap.ContainsKey(codepoint)) {
                continue;
            }

            uint glyphIndex = FT_Get_Char_Index(face, (nuint)codepoint);
            if (glyphIndex == 0) {
                continue;
            }

            // Measure glyph to place it into the atlas
            Check(FT_Load_Glyph(face, glyphIndex, FT_LOAD_DEFAULT | (int)FT_LOAD_COLOR));
            Check(FT_Render_Glyph(face->glyph, FT_Render_Mode.NORMAL));

            // All units are in 1/64th, so the shift converts them to pixels
            var metrics = face->glyph->metrics;
            uint x = (uint)(metrics.horiBearingX >> 6);
            uint y = (uint)(metrics.horiBearingY >> 6);
            uint w = (uint)(metrics.width >> 6);
            uint h = (uint)(metrics.height >> 6);
            uint advance = (uint)(metrics.horiAdvance >> 6);

            var entry = atlas.Add(new USize(w, h));
            var glyph = new Glyph(entry, new URect(x, y, w, h), advance);

            glyphMap[codepoint] = glyph;
            pendingGlyphs.Add(codepoint);
        }
    }

    /// Stores the newly added glyphs into the atlas.
    public void StoreNew(ResourcePool<BerryTexture, FNATexture> texturePool) {
        atlas.PackAdded();

        long bufferSize = 0;
        foreach (int codepoint in pendingGlyphs) {
            var glyph = glyphMap[codepoint];
            bufferSize = Math.Max(bufferSize, glyph.Source.Width * glyph.Source.Height * Unsafe.SizeOf<FNAColor>());
        }

        if (uploadBuffer.Length < bufferSize) {
            uploadBuffer = new byte[bufferSize];
        }

        var face = family.Face;

        // TODO: DPI-awareness
        FT_Set_Pixel_Sizes(face, 0, (uint)size);

        foreach (int codepoint in pendingGlyphs) {
            var glyph = glyphMap[codepoint];

            // Render glyph into buffer
            uint glyphIndex = FT_Get_Char_Index(face, (nuint)codepoint);
            Check(FT_Load_Glyph(face, glyphIndex, FT_LOAD_DEFAULT | (int)FT_LOAD_COLOR));
            Check(FT_Render_Glyph(face->glyph, FT_Render_Mode.LCD));

            var glyphTexture = atlas.GetTexture(glyph.AtlasEntry);
            var atlasTexture = texturePool[glyphTexture.Handle];
            uint width = glyphTexture.Source.Width;
            uint height = glyphTexture.Source.Height;
            uint bufferLength = (uint)(width * height * Unsafe.SizeOf<FNAColor>());


            var bmp = face->glyph->bitmap;
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
                                byte r = *dst++ = *src++;
                                byte g = *dst++ = *src++;
                                byte b = *dst++ = *src++;
                                *dst++ = (byte)((r + g + b) / (3 * byte.MaxValue));
                            }
                            break;

                        default:
                            throw new Exception($"Unhandled pixel mode: {(FT_Pixel_Mode)bmp.pixel_mode}");
                    }
                }

                atlasTexture.Texture.SetDataPointerEXT(0, glyphTexture.Source.ToFNA(), (IntPtr)bufferPtr, (int)bufferLength);
            }
        }

        pendingGlyphs.Clear();
    }

    public void Dispose() { }

    private static void Check(int err) {
        if (err != FT_Err_Ok) {
            throw new FreeTypeException(err);
        }
    }
}
