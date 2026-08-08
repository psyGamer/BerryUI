using BerryUI.Util;
using System.IO;

namespace BerryUI.Render;

public readonly struct FontFamily {
    /// Backend-specific handle for this texture. Not intended to be used by the application
    public readonly ResourceHandle<FontFamily> Handle;

    /// Creates a new font family from the provided .ttf data stream
    public FontFamily(byte[] data) {
        Handle = UI.Backend.CreateFontFamily(data);
    }
}
public readonly struct FontFace {
    /// Backend-specific handle for this texture. Not intended to be used by the application
    public readonly ResourceHandle<FontFace> Handle;

    /// Creates a new font family from the provided .ttf data stream
    public FontFace(FontFamily family, float size) {
        Handle = UI.Backend.CreateFontFace(family.Handle, size);
    }
}
