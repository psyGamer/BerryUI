using BerryUI.Util;

namespace BerryUI.Render;

public class Window {
    /// Current width of the window.
    public uint Width { get; private set; }

    /// Current height of the window.
    public uint Height { get; private set; }

    /// Minimum size for the window, which the user can't go below.
    public USize MinimumSize { get; set; }

    /// Widget which will be used as the base for rendering the window's content.
    public Widget? Content {
        get;
        set {
            field = value;
            UI.Backend.GetWindow(handle).RootWidget = value;
        }
    }

    private readonly ResourceHandle<Window> handle;

    /// Creates a new window with the specified dimensions.
    public Window(uint width, uint height) {
        handle = UI.Backend.CreateWindow(width, height, new IBackend.WindowCallbacks(
            OnResize));

        Width = width;
        Height = height;
    }

    private void OnResize(uint width, uint height) {
        Width = width;
        Height = height;
    }
}
