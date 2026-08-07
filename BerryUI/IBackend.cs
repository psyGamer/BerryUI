using BerryUI.Render;
using BerryUI.Util;
using System;

namespace BerryUI;

public interface IBackend : IDisposable {
    interface IWindow : IDisposable {
        /// Handle which uniquely identifies this window inside the backend.
        Window.Handle Handle { get; }

        /// Minimum size for the window, which the user can't go below.
        USize MinimumSize { get; set; }

        /// Widget which will be used as the base for rendering the window's content.
        Widget? RootWidget { get; set; }
    }

    readonly record struct WindowCallbacks(WindowCallbacks.OnResizeFunc OnResize) {
        public delegate void OnResizeFunc(uint width, uint height);
    }

    /// Creates a new window alongside the existing main window.
    /// The first call will create the "main window". Closing it will cause the application to exit.
    IWindow CreateWindow(uint width, uint height, WindowCallbacks callbacks);
    /// Destroys a previously created window.
    void DestroyWindow(Window.Handle handle);
    /// Retrieves the window associated with the handle from the backend.
    IWindow GetWindow(Window.Handle handle);

    /// Creates a new texture.
    Texture.Handle CreateTexture(uint width, uint height, Color? fillColor);
    /// Destroys a previously created texture.
    void DestroyTexture(Texture.Handle handle);
}
