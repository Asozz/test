using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DangerousWoods
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D playerSprite;
        Texture2D playerWalking;
        Texture2D walkDown;
        Texture2D walkUp;
        Texture2D walkRight;
        Texture2D walkLeft;

        Texture2D background;

        Player player = new Player();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1620;
            _graphics.PreferredBackBufferHeight = 960;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            playerSprite = Content.Load<Texture2D>("player");
            walkDown = Content.Load<Texture2D>("walkDown");
            walkUp = Content.Load<Texture2D>("walkUp");
            walkRight = Content.Load<Texture2D>("walkRight");
            walkLeft = Content.Load<Texture2D>("walkLeft");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(playerSprite, new Vector2(player.Position.X - 8, player.Position.Y - 8), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}