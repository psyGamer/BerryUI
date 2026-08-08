using BerryUI.Render;
using BerryUI.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using System;
using System.Linq;
using BerryColor = BerryUI.Util.Color;
using BerryWindow = BerryUI.Render.Window;
using BerryTexture = BerryUI.Render.Texture;
using BerryFontFamily = BerryUI.Render.FontFamily;
using BerryFontFace = BerryUI.Render.FontFace;
using FNAColor = Microsoft.Xna.Framework.Color;

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

    private readonly GraphicsDeviceManager graphics;

    // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
    private readonly SDL.SDL_EventFilter currEventFilter;
    private readonly SDL.SDL_EventFilter? prevEventFilter;

    private SpriteBatch batch = null!;
    private readonly CommandBuffer commandBuffer = new(BerryTexture.Screen);

    private readonly ResourcePool<BerryWindow, FNAWindow> windowPool = new();
    private readonly ResourcePool<BerryTexture, FNATexture> texturePool = new();
    private readonly ResourcePool<BerryFontFamily, FNAFontFamily> fontFamilyPool = new();
    private readonly ResourcePool<BerryFontFace, FNAFontFace> fontFacePool = new();

    private int prevWidth, prevHeight;
    private bool initializedMainWindow;
    private bool needsClear;

    private IBackend.WindowCallbacks mainWindowCallbacks;

    public FNAGameBackend() {
        graphics = new GraphicsDeviceManager(this);
        graphics.PreferredDepthStencilFormat = DepthFormat.None;
        graphics.SynchronizeWithVerticalRetrace = true;

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

        UI.LoadContent();
    }

    protected override void UnloadContent() {
        UI.UnloadContent();

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
            RootWidget?.InvalidateLayoutAndDraw();
        }

        if (RootWidget is { } root) {
            UI.Update(root);

            commandBuffer.Reset();
            root.InvalidateDraw();
            UI.Draw(root, commandBuffer);
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
    }

    protected override void Draw(GameTime gameTime) {
        ValidateBackBuffer();

        foreach (var window in windowPool) {
            SDL.SDL_GetWindowSize(window.Pointer, out int windowWidth, out int windowHeight);

            graphics.GraphicsDevice.Viewport = new Viewport(0, 0, windowWidth, windowHeight);
            if (window.NeedsClear) {
                window.NeedsClear = false;
                GraphicsDevice.Clear(FNAColor.Black);
            }
            DrawCommandBuffer(window.CommandBuffer);
            graphics.GraphicsDevice.Present(
                new Rectangle(0, 0, windowWidth, windowHeight),
                null,
                window.Pointer
            );
        }

        var bounds = Window.ClientBounds;
        graphics.GraphicsDevice.Viewport = new Viewport(0, 0, bounds.Width, bounds.Height);
        if (needsClear) {
            needsClear = false;
            GraphicsDevice.Clear(FNAColor.Black);
        }

        DrawCommandBuffer(commandBuffer);
    }

    // Override this so that we can present with subrectangle
    protected override void EndDraw() {
        var bounds = Window.ClientBounds;
        graphics.GraphicsDevice.Present(
            new Rectangle(0, 0, bounds.Width, bounds.Height),
            null,
            Window.Handle
        );
    }

    private void DrawCommandBuffer(CommandBuffer buf) {
        // Process text
        foreach (var text in buf.TextCommands) {
            var face = fontFacePool[text.Font];
            face.RegisterText(text.Text);
        }
        foreach (var face in fontFacePool) {
            face.StoreNew(texturePool);
        }

        batch.Begin(
            SpriteSortMode.Deferred,
            BlendState.AlphaBlend,
            SamplerState.PointClamp,
            DepthStencilState.None,
            new RasterizerState {
                CullMode = CullMode.CullCounterClockwiseFace,
                ScissorTestEnable = false,
                MultiSampleAntiAlias = false,
            });

        int spriteIdx = 0, textIdx = 0;
        foreach (var type in buf.CommandTypes) {
            switch (type) {
                case CmdType.Sprite:
                    var sprite = buf.SpriteCommands[spriteIdx++];
                    batch.Draw(
                        texture: texturePool[sprite.Texture].Texture,
                        destinationRectangle: sprite.Destination.ToFNA(),
                        sourceRectangle: sprite.Source.ToFNA(),
                        color: sprite.Color.ToFNA());
                    break;

                case CmdType.Text:
                    var text = buf.TextCommands[textIdx++];
                    var face = fontFacePool[text.Font];
                    face.RenderText(text.Text, batch, text.Position.ToVector2(), texturePool);
                    break;
            }
        }

        batch.End();
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

    public ResourceHandle<BerryFontFamily> CreateFontFamily(byte[] data) {
        var fontFamily = new FNAFontFamily(data);
        fontFamily.Handle = fontFamilyPool.Allocate(fontFamily);
        return fontFamily.Handle;
    }
    public void DestroyFontFamily(ResourceHandle<BerryFontFamily> handle) {
        fontFamilyPool.Free(handle);
    }
    public IBackend.IFontFamily GetFontFamily(ResourceHandle<BerryFontFamily> handle) {
        return fontFamilyPool[handle];
    }

    public ResourceHandle<BerryFontFace> CreateFontFace(ResourceHandle<BerryFontFamily> family, float size) {
        var fontFace = new FNAFontFace(fontFamilyPool[family], size);
        fontFace.Handle = fontFacePool.Allocate(fontFace);
        return fontFace.Handle;
    }
    public void DestroyFontFace(ResourceHandle<BerryFontFace> handle) {
        fontFacePool.Free(handle);
    }
    public IBackend.IFontFace GetFontFace(ResourceHandle<BerryFontFace> handle) {
        return fontFacePool[handle];
    }
}
