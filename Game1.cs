using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Plataformer.User_Interface;

namespace Plataformer
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        //Resolução fixa do jogo
        const int SCREENWIDTH = 1024, SCREENHEIGHT = 768;
        const bool FULLSCREEN = false;

        //Para saber a resolução do desktop
        static public int screenW, screenH;
        static public Vector2 screen_center;

        //Retangulos uteis
        Rectangle screenRect, desktopRect; //renderiza com o tamanho fixo, o tamanho da tela no desktop
            //Alvo de renderização
        RenderTarget2D MainTarget; //Renderiza com o tamanho fixo e encaixa na resolução do desktop

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        PresentationParameters pp;
        Input inp;
        
        //CONSTRUTOR
        public Game1()
        {
            //Seta um display com a tela do tamanho do desktop sem bordas
            //Problemas com firewall podem crashar o jogo com fullscreen
            int initial_screen_width = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width - 10;
            int initial_screen_height = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height - 10;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            inp = new Input();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            inp.Update();
            if (inp.Keypress(Keys.Escape)) Exit();
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
