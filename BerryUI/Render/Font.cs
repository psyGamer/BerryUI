using BerryUI.Util;
using System;
using System.IO;

namespace BerryUI.Render;

public readonly struct Font {
    /// Conversion factor for converting font points into pixels.
    public const float PointsToPixels = 4.0f / 3.0f;
    /// Conversion factor for converting pixels into font points.
    public const float PixelsToPoints = 3.0f / 4.0f;

    /// Backend-specific handle for this texture. Not intended to be used by the application.
    public readonly ResourceHandle<Font> Handle;

    /// Creates a new font family from the provided .ttf data stream.
    public Font(byte[] data) {
        Handle = UI.Backend.CreateFont(data);
    }

    public TextBlob CreateSimpleText(uint pixelSize, ReadOnlySpan<char> text, float maxWidth = float.MaxValue) {
        return new TextBlob(UI.Backend.CreateSimpleTextBlob(Handle, pixelSize, text, maxWidth));
    }
}
public readonly struct TextBlob {
    /// Backend-specific handle for this texture. Not intended to be used by the application.
    public readonly ResourceHandle<TextBlob> Handle;

    internal TextBlob(ResourceHandle<TextBlob> handle) {
        Handle = handle;
    }
}
