using BerryUI.Render;
using BerryUI.Util;
using SDL2;
using System;
using BerryWindow = BerryUI.Render.Window;
using BerryTexture = BerryUI.Render.Texture;

namespace BerryUI.FNA;

public sealed class FNAWindow : IBackend.IWindow, IDisposable {
    public readonly IntPtr Pointer;
    public readonly uint ID;
    public readonly CommandBuffer CommandBuffer = new(BerryTexture.Screen);

    private readonly IBackend.WindowCallbacks callbacks;
    private int prevWidth, prevHeight;

    public ResourceHandle<BerryWindow> Handle { get; set; }

    private USize minimumSize;

    public USize MinimumSize {
        get => minimumSize;
        set {
            minimumSize = value;
            SDL.SDL_SetWindowMinimumSize(Pointer, (int)value.Width, (int)value.Height);
        }
    }

    public Widget? RootWidget { get; set; }
    public bool NeedsClear;

    public FNAWindow(uint width, uint height, IBackend.WindowCallbacks callbacks) {
        Pointer = SDL.SDL_CreateWindow(
            "Extra Window",
            SDL.SDL_WINDOWPOS_CENTERED,
            SDL.SDL_WINDOWPOS_CENTERED,
            (int)width,
            (int)height,
            // SDL_WINDOW_VULKAN just loads libvulkan, so we can always set it
            SDL.SDL_WindowFlags.SDL_WINDOW_VULKAN |
            SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN
        );
        ID = SDL.SDL_GetWindowID(Pointer);

        SDL.SDL_GetWindowMinimumSize(Pointer, out int minW, out int minH);
        minimumSize = new USize((uint)minW, (uint)minH);

        this.callbacks = callbacks;
    }

    public void Update() {
        SDL.SDL_GetWindowSize(Pointer, out int currWidth, out int currHeight);
        if (prevWidth != currWidth || prevHeight != currHeight) {
            prevWidth = currWidth;
            prevHeight = currHeight;

            callbacks.OnResize((uint)currWidth, (uint)currHeight);
            RootWidget?.InvalidateLayoutAndDraw();
            NeedsClear = true;
        }

        if (RootWidget is { } root) {
            UI.Update(root);

            CommandBuffer.Reset();
            UI.Draw(root, CommandBuffer);
        }
    }

    public void Dispose() {
        SDL.SDL_DestroyWindow(Pointer);
    }
}
