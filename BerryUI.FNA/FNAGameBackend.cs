using BerryUI.Render;
using BerryUI.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using BerryColor = BerryUI.Util.Color;
using BerryWindow = BerryUI.Render.Window;
using BerryTexture = BerryUI.Render.Texture;
using BerryFont = BerryUI.Render.Font;
using BerryTextBlob = BerryUI.Render.TextBlob;

namespace BerryUI.FNA;

/// Backend for running BerryUI as an FNA game
public sealed class FNAGameBackend : Game, IBackend, IBackend.IWindow {
    private const uint MainWindowHandle = uint.MaxValue;

    public ResourceHandle<BerryWindow> Handle => new(MainWindowHandle);

    private USize minimumSize;

    public USize MinimumSize {
        get => minimumSize;
        set {
            minimumSize = value;
            SDL.SDL_SetWindowMinimumSize(Window.Handle, (int)value.Width, (int)value.Height);
        }
    }

    public Widget? RootWidget { get; set; }

    private readonly AssetDirectory assets;

    private readonly GraphicsDeviceManager graphics;

    // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
    private readonly SDL.SDL_EventFilter currEventFilter;
    private readonly SDL.SDL_EventFilter? prevEventFilter;

    private SpriteBatch batch = null!;
    private RenderTarget2D? screenTargetA, screenTargetB;

    private readonly CommandEncoder commandEncoder = new(BerryTexture.Screen);

    private readonly ResourcePool<BerryWindow, FNAWindow> windowPool = new();
    private readonly ResourcePool<BerryTexture, FNATexture> texturePool = new();
    private readonly ResourcePool<BerryFont, FNAFont> fontPool = new();
    private readonly ResourcePool<BerryTextBlob, FNATextBlob> textBlobPool = new();

    private int prevWidth, prevHeight;
    private bool initializedMainWindow;
    private bool needsClear;

    private IBackend.WindowCallbacks mainWindowCallbacks;

    public FNAGameBackend() {
        graphics = new GraphicsDeviceManager(this);
        graphics.PreferredDepthStencilFormat = DepthFormat.None;
        graphics.SynchronizeWithVerticalRetrace = true;
        graphics.PreferredBackBufferFormat = SurfaceFormat.Color;

        // For debug builds, enable hot reload and use the assets from the project source
#if DEBUG
        assets = new AssetDirectory.FileSystem(Path.Combine(DebugBuildInfo.ProjectPath, "Assets", "BerryUI.FNA"), hotReload: true);
#else
        assets = new AssetDirectory.FileSystem(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "BerryUI.FNA"), hotReload: false);
#endif

        Window.AllowUserResizing = true;
        IsMouseVisible = true;
        IsFixedTimeStep = false;

        SDL.SDL_GetWindowMinimumSize(Window.Handle, out int minW, out int minH);
        minimumSize = new USize((uint)minW, (uint)minH);

        // Use a filter to get SDL events for your extra window
        SDL.SDL_GetEventFilter(out prevEventFilter, out IntPtr prevUserData);
        // Store to avoid garbage collection
        currEventFilter = EventFilter;
        SDL.SDL_SetEventFilter(currEventFilter, prevUserData);
    }

    private unsafe int EventFilter(IntPtr userdata, IntPtr evtPtr) {
        var evt = (SDL.SDL_Event*)evtPtr;
        if (evt->type == SDL.SDL_EventType.SDL_WINDOWEVENT) {
            if (evt->window.windowEvent == SDL.SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE) {
                // Lazy hack, just exit when any window is closed
                Exit();
                return 0;
            }

            // Filter these out so Game doesn't get weird
            if (windowPool.Any(win => evt->window.windowID == win.ID)) {
                return 0;
            }
        }

        return prevEventFilter?.Invoke(userdata, evtPtr) ?? 1;
    }

    protected override void LoadContent() {
        batch = new SpriteBatch(graphics.GraphicsDevice);

        FNARenderer.LoadContent(graphics.GraphicsDevice, assets, (bool)typeof(SpriteBatch).GetField("supportsNoOverwrite", BindingFlags.NonPublic | BindingFlags.Instance)!.GetValue(batch)!);

        UI.LoadContent();
    }

    protected override void UnloadContent() {
        UI.UnloadContent();

        assets.Dispose();

        batch.Dispose();
        batch = null!;
    }

    protected override void Update(GameTime gameTime) {
        var bounds = Window.ClientBounds;
        if (prevWidth != bounds.Width || prevHeight != bounds.Height) {
            prevWidth = bounds.Width;
            prevHeight = bounds.Height;
            needsClear = true;

            mainWindowCallbacks.OnResize((uint)bounds.Width, (uint)bounds.Height);
            RootWidget?.InvalidateLayout();
            needsClear = true;
        }

        if (RootWidget is { } root) {
            UI.Update(root);

            commandEncoder.Reset();
            UI.Draw(root, commandEncoder);
        }

        foreach (var window in windowPool) {
            window.Update();
        }
    }

    private void ValidateBackBuffer() {
        // Get the largest width/height of all windows, use as backbuffer size
        var bounds = Window.ClientBounds;

        foreach (var window in windowPool) {
            SDL.SDL_GetWindowSize(window.Pointer, out int windowWidth, out int windowHeight);

            bounds.Width = Math.Max(bounds.Width, windowWidth);
            bounds.Height = Math.Max(bounds.Height, windowHeight);
        }

        /* Note two details:
         *
         * 1. Do NOT call ApplyChanges, that triggers a window resize!
         * 2. Do NOT pass a window handle here, it may cause a swapchain resize!
         */
        var pp = graphics.GraphicsDevice.PresentationParameters;
        if (pp.BackBufferWidth != bounds.Width || pp.BackBufferHeight != bounds.Height) {
            pp.BackBufferWidth = bounds.Width;
            pp.BackBufferHeight = bounds.Height;
            pp.DeviceWindowHandle = IntPtr.Zero;
            graphics.GraphicsDevice.Reset(pp);
            Console.WriteLine("GraphicsDevice reset!");
        }

        if (screenTargetA == null || screenTargetA.Width != bounds.Width || screenTargetA.Height != bounds.Height ||
            screenTargetB == null || screenTargetB.Width != bounds.Width || screenTargetB.Height != bounds.Height
           ) {
            screenTargetA?.Dispose();
            screenTargetA = new RenderTarget2D(graphics.GraphicsDevice,
                bounds.Width, bounds.Height, mipMap: false,
                SurfaceFormat.HalfVector4, pp.DepthStencilFormat, pp.MultiSampleCount, pp.RenderTargetUsage);

            screenTargetB?.Dispose();
            screenTargetB = new RenderTarget2D(graphics.GraphicsDevice,
                bounds.Width, bounds.Height, mipMap: false,
                SurfaceFormat.HalfVector4, pp.DepthStencilFormat, pp.MultiSampleCount, pp.RenderTargetUsage);
        }
    }

    protected override void Draw(GameTime gameTime) {
        ValidateBackBuffer();

        foreach (var window in windowPool) {
            if (window.CommandEncoder.IsEmpty) {
                continue;
            }

            SDL.SDL_GetWindowSize(window.Pointer, out int windowWidth, out int windowHeight);

            graphics.GraphicsDevice.Viewport = new Viewport(0, 0, windowWidth, windowHeight);
            FNARenderer.Render(
                commandEncoder, graphics.GraphicsDevice,
                screenTargetA!, screenTargetB!, needsClear,
                texturePool, fontPool, textBlobPool);
            needsClear = false;
            graphics.GraphicsDevice.Present(new Rectangle(0, 0, windowWidth, windowHeight), null, window.Pointer);
        }

        if (commandEncoder.IsEmpty) {
            return;
        }

        var bounds = Window.ClientBounds;
        graphics.GraphicsDevice.Viewport = new Viewport(0, 0, bounds.Width, bounds.Height);
        FNARenderer.Render(
            commandEncoder, graphics.GraphicsDevice,
            screenTargetA!, screenTargetB!, needsClear,
            texturePool, fontPool, textBlobPool);
        needsClear = false;
        graphics.GraphicsDevice.Present(new Rectangle(0, 0, bounds.Width, bounds.Height), null, Window.Handle);
    }

    protected override void EndDraw() {
        // Prevent FNA from calling Present, since we already did that inside Draw
    }

    public ResourceHandle<BerryWindow> CreateWindow(uint width, uint height, IBackend.WindowCallbacks callbacks) {
        // The first allocated window is the "main window"
        if (!initializedMainWindow) {
            initializedMainWindow = true;
            mainWindowCallbacks = callbacks;

            graphics.PreferredBackBufferWidth = (int)width;
            graphics.PreferredBackBufferHeight = (int)height;
            return new ResourceHandle<BerryWindow>(MainWindowHandle);
        }

        var window = new FNAWindow(width, height, callbacks);
        window.Handle = windowPool.Allocate(window);
        return window.Handle;
    }

    public void DestroyWindow(ResourceHandle<BerryWindow> handle) {
        if (handle.Value == MainWindowHandle) {
            Exit();
            return;
        }

        windowPool.Free(handle);
    }

    public IBackend.IWindow GetWindow(ResourceHandle<BerryWindow> handle) {
        if (handle.Value == MainWindowHandle) {
            return this;
        }

        return windowPool[handle];
    }

    public ResourceHandle<BerryTexture> CreateTexture(uint width, uint height, BerryColor? fillColor) {
        var texture = new FNATexture(graphics.GraphicsDevice, (int)width, (int)height, fillColor);
        texture.Handle = texturePool.Allocate(texture);
        return texture.Handle;
    }

    public void DestroyTexture(ResourceHandle<BerryTexture> handle) {
        texturePool.Free(handle);
    }

    public ResourceHandle<BerryFont> CreateFont(byte[] data) {
        var font = new FNAFont(data);
        font.Handle = fontPool.Allocate(font);
        return font.Handle;
    }

    public void DestroyFont(ResourceHandle<BerryFont> handle) {
        fontPool.Free(handle);
    }

    public IBackend.IFont GetFont(ResourceHandle<BerryFont> handle) {
        return fontPool[handle];
    }

    public ResourceHandle<BerryTextBlob> CreateSimpleTextBlob(ResourceHandle<BerryFont> font, uint pixelSize, ReadOnlySpan<char> text, float maxWidth) {
        var textBlob = FNATextBlob.ShapeSimple(fontPool[font], pixelSize, text, maxWidth);
        textBlob.Handle = textBlobPool.Allocate(textBlob);
        return textBlob.Handle;
    }

    public void DestroyTextBlob(ResourceHandle<BerryTextBlob> handle) {
        textBlobPool.Free(handle);
    }

    public IBackend.ITextBlob GetTextBlob(ResourceHandle<BerryTextBlob> handle) {
        return textBlobPool[handle];
    }
}
