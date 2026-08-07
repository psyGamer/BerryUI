using BerryUI.Render;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using BerryColor = BerryUI.Util.Color;
using BerryWindow = BerryUI.Render.Window;
using BerryTexture = BerryUI.Render.Texture;

namespace BerryUI.FNA;

/// Backend for running BerryUI as an FNA game
public sealed class FNAGameBackend : Game, IBackend, IBackend.IWindow {
    private sealed class FNAWindow : IBackend.IWindow {
        public readonly IntPtr Pointer;
        public readonly uint ID;
        public readonly CommandBuffer CommandBuffer = new(BerryTexture.Screen);

        private readonly IBackend.WindowCallbacks callbacks;
        private int prevWidth, prevHeight;

        public BerryWindow.Handle Handle { get; }

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

        public FNAWindow(uint width, uint height, IBackend.WindowCallbacks callbacks, BerryWindow.Handle handle) {
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
            Handle = handle;
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
            UI.Backend.DestroyWindow(Handle);
        }
    }

    private const uint MainWindowHandle = uint.MaxValue;

    public BerryWindow.Handle Handle => new(MainWindowHandle);

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
    private readonly SDL.SDL_EventFilter currEventFilter;
    private readonly SDL.SDL_EventFilter? prevEventFilter;

    private SpriteBatch batch = null!;
    private readonly CommandBuffer commandBuffer = new(BerryTexture.Screen);

    private readonly List<FNAWindow?> windowStorage = new(capacity: 8);
    private int prevWindowIndex = int.MinValue;

    private readonly List<Texture2D?> textureStorage = new(capacity: 128);
    private int prevTextureIndex = -1;

    private int prevWidth, prevHeight;
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

            foreach (var extraWindow in windowStorage) {
                if (extraWindow == null) {
                    continue;
                }

                if (evt->window.windowID == extraWindow.ID) {
                    // Filter these out so Game doesn't get weird
                    return 0;
                }
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
            UI.Draw(root, commandBuffer);
        }

        foreach (var extraWindow in windowStorage) {
            extraWindow?.Update();
        }
    }

    private void ValidateBackBuffer() {
        // Get the largest width/height of all windows, use as backbuffer size
        var bounds = Window.ClientBounds;

        foreach (var extraWindow in windowStorage) {
            if (extraWindow == null) {
                continue;
            }

            SDL.SDL_GetWindowSize(extraWindow.Pointer, out int wx, out int wy);

            bounds.Width = Math.Max(bounds.Width, wx);
            bounds.Height = Math.Max(bounds.Height, wy);
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

        foreach (var extraWindow in windowStorage) {
            if (extraWindow == null) {
                continue;
            }

            SDL.SDL_GetWindowSize(extraWindow.Pointer, out int windowWidth, out int windowHeight);

            graphics.GraphicsDevice.Viewport = new Viewport(0, 0, windowWidth, windowHeight);
            DrawCommandBuffer(extraWindow.CommandBuffer);
            graphics.GraphicsDevice.Present(
                new Rectangle(0, 0, windowWidth, windowHeight),
                null,
                extraWindow.Pointer
            );
        }

        var bounds = Window.ClientBounds;
        graphics.GraphicsDevice.Viewport = new Viewport(0, 0, bounds.Width, bounds.Height);
        if (needsClear) {
            GraphicsDevice.Clear(Color.Black);
            needsClear = false;
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
        int spriteIdx = 0;

        batch.Begin(
            SpriteSortMode.Deferred,
            BlendState.AlphaBlend,
            SamplerState.LinearClamp,
            DepthStencilState.None,
            new RasterizerState {
                CullMode = CullMode.CullCounterClockwiseFace,
                ScissorTestEnable = false,
                MultiSampleAntiAlias = false,
            });

        foreach (var type in buf.CommandTypes) {
            switch (type) {
                case CmdType.Sprite:
                    var sprite = buf.SpriteCommands[spriteIdx++];
                    batch.Draw(
                        texture: textureStorage[(int)sprite.Texture.BackendHandle.Value]!,
                        destinationRectangle: sprite.Destination.ToFNA(),
                        sourceRectangle: sprite.Source.ToFNA(),
                        color: sprite.Color.ToFNA());
                    break;
            }
        }

        batch.End();
    }

    public IBackend.IWindow CreateWindow(uint width, uint height, IBackend.WindowCallbacks callbacks) {
        if (prevWindowIndex == int.MinValue) {
            // This is the first window being allocated, assign it to the "main window"
            prevWindowIndex = -1;
            mainWindowCallbacks = callbacks;

            graphics.PreferredBackBufferWidth = (int)width;
            graphics.PreferredBackBufferHeight = (int)height;

            return this;
        }

        // Search for a free slot
        prevWindowIndex++;
        for (; prevWindowIndex < windowStorage.Count; prevWindowIndex++) {
            if (windowStorage[prevWindowIndex] is null) {
                var window = new FNAWindow(width, height, callbacks, new((uint)prevWindowIndex));
                windowStorage[prevWindowIndex] = window;
                return window;
            }
        }

        // Allocate a new slot
        {
            var window = new FNAWindow(width, height, callbacks, new((uint)prevWindowIndex));
            windowStorage.Add(window);
            return window;
        }

    }
    public void DestroyWindow(BerryWindow.Handle handle) {
        if (handle.Value == MainWindowHandle) {
            Exit();
            return;
        }

        prevWindowIndex = (int)handle.Value;
        var window = windowStorage[prevWindowIndex]!;
        windowStorage[prevWindowIndex] = null;

        SDL.SDL_DestroyWindow(window.Pointer);
    }
    public IBackend.IWindow GetWindow(BerryWindow.Handle handle) {
        if (handle.Value == MainWindowHandle) {
            return this;
        }

        return windowStorage[(int)handle.Value]!;
    }

    public BerryTexture.Handle CreateTexture(uint width, uint height, BerryColor? fillColor) {
        var texture = new Texture2D(graphics.GraphicsDevice, (int)width, (int)height, false, SurfaceFormat.Color);
        if (fillColor.HasValue) {
            unsafe {
                int dataLen = (int)(width * height);
                int dataSize = dataLen * Unsafe.SizeOf<BerryColor>();

                nint dataPtr = Marshal.AllocHGlobal(dataSize);
                var dataSpan = new Span<BerryColor>((void*)dataPtr, dataLen);
                dataSpan.Fill(fillColor.Value);

                texture.SetDataPointerEXT(0, null, dataPtr, dataSize);

                Marshal.FreeHGlobal(dataPtr);
            }
        }

        return StoreTexture(texture);
    }
    public void DestroyTexture(BerryTexture.Handle handle) {
        prevTextureIndex = (int)handle.Value;
        var texture = textureStorage[prevTextureIndex]!;
        textureStorage[prevTextureIndex] = null;

        texture.Dispose();
    }

    private BerryTexture.Handle StoreTexture(Texture2D texture) {
        // Search for a free slot
        prevTextureIndex++;
        for (; prevTextureIndex < textureStorage.Count; prevTextureIndex++) {
            if (textureStorage[prevTextureIndex] is null) {
                textureStorage[prevTextureIndex] = texture;
                return new BerryTexture.Handle((uint)prevTextureIndex);
            }
        }

        // Allocate a new slot
        textureStorage.Add(texture);
        return new BerryTexture.Handle((uint)prevTextureIndex);
    }
}
