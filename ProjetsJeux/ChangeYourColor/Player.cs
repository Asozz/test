using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ChangeYourColor
{
    class Player
    {
        private Vector2 position = new Vector2(100, 600);
        private Dir direction = Dir.Right;
        private int playerSpeed = 5;
        private int jumpSpeed = 0;
        public int gravity = 5;
        public int velocity;
        public float timer = 0.2f;
        public bool isMoving;
        public bool isJumping;
        public bool isGrounded;

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            velocity = jumpSpeed - gravity;
            isMoving = false;
            if (position.Y <= 654)
            {
                position.Y += gravity;
            }
            if (velocity == -5)
            {
                isGrounded = true;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                isJumping = true;
            }
            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
                isMoving = true;
            }
            if (isMoving)
            {
                switch (direction)
                {
                    case Dir.Down:
                        break;
                    case Dir.Right:
                        position.X += playerSpeed;
                        break;
                    case Dir.Left:
                        position.X -= playerSpeed;
                        break;
                }
            }
            if (isJumping && isGrounded)
            {
                jumpSpeed = 10;
                if (timer >= 0)
                {
                    timer -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                if (timer <= 0)
                {
                    isJumping = false;
                    if (isGrounded)
                    {
                        timer = 0.2f;
                    }
                }
                if (isJumping)
                {
                    position.Y -= jumpSpeed;
                }
            }
        }
        public Vector2 Position
        {
            get { return position; }
        }
    }
}
