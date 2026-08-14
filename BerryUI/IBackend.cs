using BerryUI.Render;
using BerryUI.Util;
using System;

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

    interface IFont {
        /// Handle which uniquely identifies this font family inside the backend.
        ResourceHandle<Font> Handle { get; }
    }
    interface ITextBlob {
        /// Handle which uniquely identifies this text blob inside the backend.
        ResourceHandle<TextBlob> Handle { get; }

        /// Minimal bounding box which contains all glyphs inside this blob
        USize Bounds { get; }
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

    /// Creates a new font.
    ResourceHandle<Font> CreateFont(byte[] data);
    /// Destroys a previously created font.
    /// All text blobs created with this font need to be destroyed beforehand.
    void DestroyFont(ResourceHandle<Font> handle);
    /// Retrieves the font associated with the handle from the backend.
    IFont GetFont(ResourceHandle<Font> handle);

    /// Creates a simple new text blob.
    /// The provided <see cref="maxWidth"/> is use for wrapping the text onto new lines.
    /// The text data is copied internally and therefore doesn't need to stay valid after this call.
    ResourceHandle<TextBlob> CreateSimpleTextBlob(ResourceHandle<Font> font, uint pixelSize, ReadOnlySpan<char> text, float maxWidth);

    /// Destroys a previously created text blob.
    void DestroyTextBlob(ResourceHandle<TextBlob> handle);
    /// Retrieves the text blob associated with the handle from the backend.
    ITextBlob GetTextBlob(ResourceHandle<TextBlob> handle);
}
