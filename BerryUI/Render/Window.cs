namespace BerryUI.Render;

public class Window {
    /// Unique numeric identifier for a window.
    /// The actual value is implementation specific.
    public readonly record struct Handle(uint Value);

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

    private readonly Handle handle;

    /// Creates a new window with the specified dimensions.
    public Window(uint width, uint height) {
        var window = UI.Backend.CreateWindow(width, height, new IBackend.WindowCallbacks(
            OnResize));

        Width = width;
        Height = height;

        handle = window.Handle;
    }

    private void OnResize(uint width, uint height) {
        Width = width;
        Height = height;
    }
}
