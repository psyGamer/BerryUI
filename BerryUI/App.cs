using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;

namespace BerryUI;

public abstract class App : Game {
    public static App Instance = null!;

    /// Current width of the window.
    public int Width => GraphicsDevice.PresentationParameters.BackBufferWidth;
    /// Current height of the window.
    public int Height => GraphicsDevice.PresentationParameters.BackBufferHeight;

    /// Minimum size for the below, which the user can't go below.
    public Point MinimumWindowSize {
        get;
        set {
            field = value;
            SDL.SDL_SetWindowMinimumSize(Window.Handle, value.X, value.Y);
        }
    } = new(250, 250);

    public readonly GraphicsDeviceManager Graphics;

    protected App() {
        Instance = this;

        Graphics = new GraphicsDeviceManager(this);
        Graphics.PreferredDepthStencilFormat = DepthFormat.None;
        Graphics.SynchronizeWithVerticalRetrace = true;
        SDL.SDL_SetWindowMinimumSize(Window.Handle, MinimumWindowSize.X, MinimumWindowSize.Y);

        Window.AllowUserResizing = true;
        IsMouseVisible = true;
        IsFixedTimeStep = false;
    }

    protected override void Update(GameTime gameTime) {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        GraphicsDevice.Viewport = new(0, 0, Width, Height);
        GraphicsDevice.Clear(ClearOptions.Target, new Vector4(0.1f, 0.9f, 0.1f, 1f), 0, 0);

        base.Draw(gameTime);
    }
}