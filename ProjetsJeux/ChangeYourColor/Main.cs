using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ChangeYourColor
{
    enum Dir
    {
        Right,
        Left,
        Down
    }

    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D playerSprite;
        Texture2D platformSprite;
        Texture2D groundSprite;

        SpriteFont testFont;

        Player player = new Player();

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            playerSprite = Content.Load<Texture2D>("character2");
            platformSprite = Content.Load<Texture2D>("platform");
            groundSprite = Content.Load<Texture2D>("ground");
            testFont = Content.Load<SpriteFont>("timerFont");
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
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(groundSprite, new Vector2(0, 680), Color.White);
            _spriteBatch.Draw(platformSprite, new Vector2(650, 550), Color.White);
            // Player sprite drawing
            _spriteBatch.Draw(playerSprite, new Vector2(player.Position.X - 25, player.Position.Y - 25), Color.White);
            _spriteBatch.DrawString(testFont, "isGrounded = " + player.isGrounded, new Vector2(0, 0), Color.White);
            _spriteBatch.DrawString(testFont, "isJumping = " + player.isJumping, new Vector2(0, 50), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}