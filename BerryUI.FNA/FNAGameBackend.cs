using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using Point = BerryUI.Util.Point;

namespace BerryUI.FNA;

/// Backend for running BerryUI as an FNA game
public sealed class FNAGameBackend : Game, IBackend {
    public int Width => GraphicsDevice.PresentationParameters.BackBufferWidth;
    public int Height => GraphicsDevice.PresentationParameters.BackBufferHeight;

    public Point MinimumWindowSize {
        get;
        set {
            field = value;
            SDL.SDL_SetWindowMinimumSize(Window.Handle, value.X, value.Y);
        }
    } = new(250, 250);

    private readonly GraphicsDeviceManager Graphics;

    private App App = null!; // Initialized once when calling 'Run'

    public FNAGameBackend() {
        Graphics = new GraphicsDeviceManager(this);
        Graphics.PreferredDepthStencilFormat = DepthFormat.None;
        Graphics.SynchronizeWithVerticalRetrace = true;
        SDL.SDL_SetWindowMinimumSize(Window.Handle, MinimumWindowSize.X, MinimumWindowSize.Y);

        Window.AllowUserResizing = true;
        IsMouseVisible = true;
        IsFixedTimeStep = false;
    }

    public void Run(App app) {
        App = app;

        // Start FNA game-loop
        Run();
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
