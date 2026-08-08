using BerryUI.Util;
using System;
using System.Diagnostics;

namespace BerryUI.Render;

public readonly struct Texture : IDisposable {
    /// Special texture which represents the current window's backbuffer.
    public static readonly Texture Screen = new(new(uint.MaxValue), URect.Empty);

    /// Texture which represents a white 1x1 texture.
    public static Texture Pixel { get; private set; }

    /// Region within the backing texture, which this instance targets.
    public readonly URect Source;
    /// Backend-specific handle for this texture. Not intended to be used by the application
    public readonly ResourceHandle<Texture> Handle;

    /// Creates a new texture with the specified dimensions.
    /// The pixel data will be in an undefined state.
    public Texture(uint width, uint height)
        : this(UI.Backend.CreateTexture(width, height, fillColor: null), URect.FromSize(width, height))
    { }

    /// Creates a new texture with the specified dimensions.
    /// The pixel data will be filled with the specified color.
    public Texture(uint width, uint height, Color fillColor)
        : this(UI.Backend.CreateTexture(width, height, fillColor), URect.FromSize(width, height))
    { }

    private Texture(ResourceHandle<Texture> handle, URect source) {
        Handle = handle;
        Source = source;
    }

    /// Creates a view into the parent texture for the specified target region.
    /// The ownership of the backing texture stays at the parent.
    /// Disposing the parent will invalidate all subregions.
    public Texture GetSubregion(URect region) {
        Debug.Assert(region.Left <= Source.Width);
        Debug.Assert(region.Right <= Source.Width);
        Debug.Assert(region.Top <= Source.Height);
        Debug.Assert(region.Bottom <= Source.Height);

        return new Texture(Handle, new URect(
            Source.X + region.X,
            Source.Y + region.Y,
            region.Width,
            region.Height));
    }

    public void Dispose() {
        UI.Backend.DestroyTexture(Handle);
    }

    internal static void LoadContent() {
        Pixel = new Texture(1, 1, Color.White);
    }
    internal static void UnloadContent() {
        Pixel.Dispose();
    }
}
