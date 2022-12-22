using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Into_the_Unknown
{
    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        bool goUp;
        bool goDown;
        bool collisionUp;
        bool collisionDown;
        bool collisionRight;
        bool collisionLeft;
        bool isOver;
        bool isUnder;
        bool isRight;
        bool isLeft;
        bool isMiddleY;
        bool isMiddleX;
        int wallLeft;
        int wallRight;
        int wallUp;
        int wallDown;
        int playerLeft;
        int playerRight;
        int playerUp;
        int playerDown;
        int playerSpeed = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtColisionLeft.Text = "CollisionLeft = " + collisionLeft;
            txtColisionRight.Text = "CollisionRight = " + collisionRight;
            txtColisionUp.Text = "CollisionUp = " + collisionUp;
            txtColisionDown.Text = "CollisionDown = " + collisionDown;
            txtLeft.Text = "Left = " + isLeft;
            txtRight.Text = "Right = " + isRight;
            txtUp.Text = "Up = " + isOver;
            txtDown.Text = "Down = " + isUnder;
            txtMiddleY.Text = "MiddleY = " + isMiddleY;
            txtMiddleX.Text = "MiddleX = " + isMiddleX;
            txtUpPlayer.Text = "PlayerUp = " + playerUp;
            txtDownWall.Text = "DownWall = " + wallDown;
            txtLeftPlayer.Text = "PlayerLeft = " + playerLeft;
            txtRightWall.Text = "RightWall = " + wallRight;
            txtUpWall.Text = "UpWall = " + wallUp;
            txtLeftWall.Text = "LeftWall = " + wallLeft;
            txtPlayerDown.Text = "PlayerDown = " + playerDown;
            txtPlayerRight.Text = "PlayerRight = " + playerRight;
            if (goUp == true && player.Top > 0 && collisionUp == false)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top < 510 && collisionDown == false)
            {
                player.Top += playerSpeed;
            }
            if (goRight == true && player.Left < 835 && collisionRight == false)
            {
                player.Left += playerSpeed;
            }
            if (goLeft == true && player.Right > 50 && collisionLeft == false)
            {
                player.Left -= playerSpeed;
            }
            playerRight = player.Left + 47;
            playerLeft = player.Left;
            playerDown = player.Top + 47;
            playerUp = player.Top;

            // Collision check
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        wallRight = x.Left + 50;
                        wallLeft = x.Left;
                        wallDown = x.Top + 50;
                        wallUp = x.Top;
                        if (playerUp > wallDown)
                        {
                            isUnder = true;
                            isOver = false;
                        }
                        if (playerDown < wallUp)
                        {
                            isOver = true;
                            isUnder = false;
                        }
                        if (playerLeft > wallRight)
                        {
                            isRight = true;
                            isLeft = false;
                        }
                        if (playerRight < wallLeft)
                        {
                            isLeft = true;
                            isRight = false;
                        }

                        // Check if player can be blocked by block (Y)
                        if (true)
                        {
                            if ((playerUp <= wallDown && playerDown >= wallDown) || (playerDown >= wallUp && playerUp <= wallUp))
                            {
                                isMiddleY = true;
                            }
                            else
                            {
                                isMiddleY = false;
                            }
                        }

                        // Check if player can be blocked by block (X)
                        if (true)
                        {
                            if ((playerRight > wallLeft && playerLeft < wallLeft) || (playerLeft < wallRight && playerRight > wallRight))
                            {
                                isMiddleX = true;
                            }
                            else
                            {
                                isMiddleX = false;
                            }
                        }

                        // Left collision check
                        if (isRight == true)
                        {
                            if (isMiddleY == true && playerLeft <= wallRight)
                            {
                                collisionLeft = true;
                            }
                            else
                            {
                                collisionLeft = false;
                            }
                        }

                        // Right collision check
                        if (isLeft == true)
                        {
                            if (isMiddleY == true && playerRight >= wallLeft)
                            {
                                collisionRight = true;
                            }
                            else
                            {
                                collisionRight = false;
                            }
                        }

                        // Up collision check
                        if (isUnder == true)
                        {
                            if (isMiddleX == true && playerUp < wallDown)
                            {
                                collisionUp = true;
                            }
                            else
                            {
                                collisionUp = false;
                            }
                        }

                        // Down collision check
                        if (isOver == true)
                        {
                            if (isMiddleX == true && playerDown > wallUp)
                            {
                                collisionDown = true;
                            }
                            else
                            {
                                collisionDown = false;
                            }
                        }
                    }
                }
            }
        }
    }
}

