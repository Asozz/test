using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DangerousWoods
{
    class Player
    {
        private Vector2 position = new Vector2(100, 100);
        private int playerSpeed = 180;
        public bool isMoving = false;

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (kState.IsKeyDown(Keys.Right))
            {
                position.X += playerSpeed * dt;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                position.X -= playerSpeed * dt;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                position.Y -= playerSpeed * dt;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                position.Y += playerSpeed * dt;
            }
        }
        public Vector2 Position
        {
            get { return position; }
        }
    }
}
