using BerryUI.Render;
using BerryUI.Util;
using System;

namespace BerryUI;

public static class UI {
    /// Global instance of the backend for this execution environment.
    public static IBackend Backend = null!;

    //internal static readonly List<Widget> AllWidgets = [];

    private static bool loadedContent;

    /// Should be called **once** after the backend is able to start creating resources.
    public static void LoadContent() {
        if (loadedContent) {
            throw new Exception("Content was already loaded");
        }

        Texture.LoadContent();

        loadedContent = true;
    }

    /// Should be called **once** before the backend is no longer able to destroy resources.
    public static void UnloadContent() {
        if (!loadedContent) {
            throw new Exception("Content was not loaded");
        }

        Texture.UnloadContent();

        loadedContent = false;
    }

    public static void Update(Widget root) {
        if (!loadedContent) {
            throw new Exception("Content is not loaded");
        }

        while (root.NeedsLayout) {
            root.NeedsLayout = false;
            root.ResolveLayout();
        }
    }

    public static void Draw(Widget root, CommandEncoder enc) {
        if (!loadedContent) {
            throw new Exception("Content is not loaded");
        }

        if (root.CheckDraw(enc, out var drawRegion)) {
            enc.Rect(drawRegion, Color.Black); // TODO: Configurable background color
            root.Draw(enc, drawRegion);
        }
    }
}
