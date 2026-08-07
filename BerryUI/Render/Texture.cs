using BerryUI.Util;
using System;

namespace BerryUI.Render;

public struct Texture : IDisposable {
    /// Unique numeric identifier for a texture.
    /// The actual value is implementation specific.
    public readonly record struct Handle(uint Value);

    /// Special texture which represents the current window's backbuffer.
    public static readonly Texture Screen = new(new Handle(uint.MaxValue));

    /// Texture which represents a white 1x1 texture.
    public static Texture Pixel { get; private set; }

    /// Backend-specific handle for this texture. Not intended to be used by the application
    public readonly Handle BackendHandle;

    /// Creates a new texture with the specified dimensions.
    /// The pixel data will be in an undefined state.
    public Texture(uint width, uint height)
        : this(UI.Backend.CreateTexture(width, height, fillColor: null))
    { }

    /// Creates a new texture with the specified dimensions.
    /// The pixel data will be filled with the specified color.
    public Texture(uint width, uint height, Color fillColor)
        : this (UI.Backend.CreateTexture(width, height, fillColor))
    { }

    private Texture(Handle handle) {
        BackendHandle = handle;
    }

    public void Dispose() {
        UI.Backend.DestroyTexture(BackendHandle);
    }

    internal static void LoadContent() {
        Pixel = new Texture(1, 1, Color.White);
    }
    internal static void UnloadContent() {
        Pixel.Dispose();
    }
}
