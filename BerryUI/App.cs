using BerryUI.Util;
using System;

namespace BerryUI;

public abstract class App : IDisposable {
    /// Current width of the window.
    public int Width => backend.Width;
    /// Current height of the window.
    public int Height => backend.Height;

    /// Minimum size for the below, which the user can't go below.
    public Point MinimumWindowSize {
        get => backend.MinimumWindowSize;
        set => backend.MinimumWindowSize = value;
    }

    private readonly IBackend backend;

    protected App(IBackend backend) {
        this.backend = backend;
    }

    public void Dispose() {}
}
