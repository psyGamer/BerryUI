using BerryUI.Render;
using BerryUI.Util;
using System;
using System.IO;

namespace BerryUI;

public interface IBackend : IDisposable {
    readonly record struct WindowCallbacks(WindowCallbacks.OnResizeFunc OnResize) {
        public delegate void OnResizeFunc(uint width, uint height);
    }

    interface IWindow {
        /// Handle which uniquely identifies this window inside the backend.
        ResourceHandle<Window> Handle { get; }

        /// Minimum size for the window, which the user can't go below.
        USize MinimumSize { get; set; }

        /// Widget which will be used as the base for rendering the window's content.
        Widget? RootWidget { get; set; }
    }

    interface IFontFamily {
        /// Handle which uniquely identifies this font family inside the backend.
        ResourceHandle<FontFamily> Handle { get; }
    }
    interface IFontFace {
        /// Handle which uniquely identifies this font face inside the backend.
        ResourceHandle<FontFace> Handle { get; }
    }

    /// Creates a new window alongside the existing main window.
    /// The first call will create the "main window". Closing it will cause the application to exit.
    ResourceHandle<Window> CreateWindow(uint width, uint height, WindowCallbacks callbacks);
    /// Destroys a previously created window.
    void DestroyWindow(ResourceHandle<Window> handle);
    /// Retrieves the window associated with the handle from the backend.
    IWindow GetWindow(ResourceHandle<Window> handle);

    /// Creates a new texture.
    ResourceHandle<Texture> CreateTexture(uint width, uint height, Color? fillColor);
    /// Destroys a previously created texture.
    void DestroyTexture(ResourceHandle<Texture> handle);

    /// Creates a new font family.
    ResourceHandle<FontFamily> CreateFontFamily(byte[] data);
    /// Destroys a previously created font family.
    /// All font faces created with this family need to be destroyed beforehand.
    void DestroyFontFamily(ResourceHandle<FontFamily> handle);
    /// Retrieves the font family associated with the handle from the backend.
    IFontFamily GetFontFamily(ResourceHandle<FontFamily> handle);

    /// Creates a new font face.
    ResourceHandle<FontFace> CreateFontFace(ResourceHandle<FontFamily> family, float size);
    /// Destroys a previously created font face.
    void DestroyFontFace(ResourceHandle<FontFace> handle);
    /// Retrieves the font face associated with the handle from the backend.
    IFontFace GetFontFace(ResourceHandle<FontFace> handle);
}
