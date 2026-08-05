using BerryUI.Util;
using System;

namespace BerryUI;

/// "Opaque" interface representing the platform backend
public interface IBackend : IDisposable {
    /// Current width of the window.
    int Width { get; }

    /// Current height of the window.
    int Height { get; }

    /// Minimum size for the below, which the user can't go below.
    Point MinimumWindowSize { get; set; }

    /// Hands the control-flow execution over to the backend.
    void Run(App app);
}
