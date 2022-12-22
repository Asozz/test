namespace Into_the_Unknown
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtColisionLeft = new System.Windows.Forms.Label();
            this.txtColisionRight = new System.Windows.Forms.Label();
            this.txtColisionUp = new System.Windows.Forms.Label();
            this.txtColisionDown = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.Label();
            this.txtUp = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.Label();
            this.txtMiddleY = new System.Windows.Forms.Label();
            this.txtMiddleX = new System.Windows.Forms.Label();
            this.txtDownWall = new System.Windows.Forms.Label();
            this.txtUpPlayer = new System.Windows.Forms.Label();
            this.txtRightWall = new System.Windows.Forms.Label();
            this.txtLeftPlayer = new System.Windows.Forms.Label();
            this.txtLeftWall = new System.Windows.Forms.Label();
            this.txtUpWall = new System.Windows.Forms.Label();
            this.txtPlayerDown = new System.Windows.Forms.Label();
            this.txtPlayerRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Into_the_Unknown.Properties.Resources.wall;
            this.pictureBox1.Location = new System.Drawing.Point(317, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Into_the_Unknown.Properties.Resources.character2;
            this.player.Location = new System.Drawing.Point(458, 354);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // txtColisionLeft
            // 
            this.txtColisionLeft.AutoSize = true;
            this.txtColisionLeft.ForeColor = System.Drawing.Color.White;
            this.txtColisionLeft.Location = new System.Drawing.Point(705, 40);
            this.txtColisionLeft.Name = "txtColisionLeft";
            this.txtColisionLeft.Size = new System.Drawing.Size(77, 13);
            this.txtColisionLeft.TabIndex = 2;
            this.txtColisionLeft.Text = "Colision = false";
            // 
            // txtColisionRight
            // 
            this.txtColisionRight.AutoSize = true;
            this.txtColisionRight.ForeColor = System.Drawing.Color.White;
            this.txtColisionRight.Location = new System.Drawing.Point(705, 64);
            this.txtColisionRight.Name = "txtColisionRight";
            this.txtColisionRight.Size = new System.Drawing.Size(77, 13);
            this.txtColisionRight.TabIndex = 2;
            this.txtColisionRight.Text = "Colision = false";
            // 
            // txtColisionUp
            // 
            this.txtColisionUp.AutoSize = true;
            this.txtColisionUp.ForeColor = System.Drawing.Color.White;
            this.txtColisionUp.Location = new System.Drawing.Point(705, 90);
            this.txtColisionUp.Name = "txtColisionUp";
            this.txtColisionUp.Size = new System.Drawing.Size(77, 13);
            this.txtColisionUp.TabIndex = 2;
            this.txtColisionUp.Text = "Colision = false";
            // 
            // txtColisionDown
            // 
            this.txtColisionDown.AutoSize = true;
            this.txtColisionDown.ForeColor = System.Drawing.Color.White;
            this.txtColisionDown.Location = new System.Drawing.Point(705, 117);
            this.txtColisionDown.Name = "txtColisionDown";
            this.txtColisionDown.Size = new System.Drawing.Size(77, 13);
            this.txtColisionDown.TabIndex = 2;
            this.txtColisionDown.Text = "Colision = false";
            // 
            // txtRight
            // 
            this.txtRight.AutoSize = true;
            this.txtRight.ForeColor = System.Drawing.Color.White;
            this.txtRight.Location = new System.Drawing.Point(49, 40);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(77, 13);
            this.txtRight.TabIndex = 2;
            this.txtRight.Text = "Colision = false";
            // 
            // txtLeft
            // 
            this.txtLeft.AutoSize = true;
            this.txtLeft.ForeColor = System.Drawing.Color.White;
            this.txtLeft.Location = new System.Drawing.Point(49, 77);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(77, 13);
            this.txtLeft.TabIndex = 2;
            this.txtLeft.Text = "Colision = false";
            // 
            // txtUp
            // 
            this.txtUp.AutoSize = true;
            this.txtUp.ForeColor = System.Drawing.Color.White;
            this.txtUp.Location = new System.Drawing.Point(49, 117);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(77, 13);
            this.txtUp.TabIndex = 2;
            this.txtUp.Text = "Colision = false";
            // 
            // txtDown
            // 
            this.txtDown.AutoSize = true;
            this.txtDown.ForeColor = System.Drawing.Color.White;
            this.txtDown.Location = new System.Drawing.Point(49, 157);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(77, 13);
            this.txtDown.TabIndex = 2;
            this.txtDown.Text = "Colision = false";
            // 
            // txtMiddleY
            // 
            this.txtMiddleY.AutoSize = true;
            this.txtMiddleY.ForeColor = System.Drawing.Color.White;
            this.txtMiddleY.Location = new System.Drawing.Point(49, 419);
            this.txtMiddleY.Name = "txtMiddleY";
            this.txtMiddleY.Size = new System.Drawing.Size(77, 13);
            this.txtMiddleY.TabIndex = 2;
            this.txtMiddleY.Text = "Colision = false";
            // 
            // txtMiddleX
            // 
            this.txtMiddleX.AutoSize = true;
            this.txtMiddleX.ForeColor = System.Drawing.Color.White;
            this.txtMiddleX.Location = new System.Drawing.Point(49, 442);
            this.txtMiddleX.Name = "txtMiddleX";
            this.txtMiddleX.Size = new System.Drawing.Size(77, 13);
            this.txtMiddleX.TabIndex = 2;
            this.txtMiddleX.Text = "Colision = false";
            // 
            // txtDownWall
            // 
            this.txtDownWall.AutoSize = true;
            this.txtDownWall.ForeColor = System.Drawing.Color.White;
            this.txtDownWall.Location = new System.Drawing.Point(300, 40);
            this.txtDownWall.Name = "txtDownWall";
            this.txtDownWall.Size = new System.Drawing.Size(77, 13);
            this.txtDownWall.TabIndex = 2;
            this.txtDownWall.Text = "Colision = false";
            // 
            // txtUpPlayer
            // 
            this.txtUpPlayer.AutoSize = true;
            this.txtUpPlayer.ForeColor = System.Drawing.Color.White;
            this.txtUpPlayer.Location = new System.Drawing.Point(431, 40);
            this.txtUpPlayer.Name = "txtUpPlayer";
            this.txtUpPlayer.Size = new System.Drawing.Size(77, 13);
            this.txtUpPlayer.TabIndex = 2;
            this.txtUpPlayer.Text = "Colision = false";
            // 
            // txtRightWall
            // 
            this.txtRightWall.AutoSize = true;
            this.txtRightWall.ForeColor = System.Drawing.Color.White;
            this.txtRightWall.Location = new System.Drawing.Point(300, 64);
            this.txtRightWall.Name = "txtRightWall";
            this.txtRightWall.Size = new System.Drawing.Size(77, 13);
            this.txtRightWall.TabIndex = 2;
            this.txtRightWall.Text = "Colision = false";
            // 
            // txtLeftPlayer
            // 
            this.txtLeftPlayer.AutoSize = true;
            this.txtLeftPlayer.ForeColor = System.Drawing.Color.White;
            this.txtLeftPlayer.Location = new System.Drawing.Point(431, 64);
            this.txtLeftPlayer.Name = "txtLeftPlayer";
            this.txtLeftPlayer.Size = new System.Drawing.Size(77, 13);
            this.txtLeftPlayer.TabIndex = 2;
            this.txtLeftPlayer.Text = "Colision = false";
            // 
            // txtLeftWall
            // 
            this.txtLeftWall.AutoSize = true;
            this.txtLeftWall.ForeColor = System.Drawing.Color.White;
            this.txtLeftWall.Location = new System.Drawing.Point(217, 64);
            this.txtLeftWall.Name = "txtLeftWall";
            this.txtLeftWall.Size = new System.Drawing.Size(77, 13);
            this.txtLeftWall.TabIndex = 2;
            this.txtLeftWall.Text = "Colision = false";
            // 
            // txtUpWall
            // 
            this.txtUpWall.AutoSize = true;
            this.txtUpWall.ForeColor = System.Drawing.Color.White;
            this.txtUpWall.Location = new System.Drawing.Point(217, 40);
            this.txtUpWall.Name = "txtUpWall";
            this.txtUpWall.Size = new System.Drawing.Size(77, 13);
            this.txtUpWall.TabIndex = 2;
            this.txtUpWall.Text = "Colision = false";
            // 
            // txtPlayerDown
            // 
            this.txtPlayerDown.AutoSize = true;
            this.txtPlayerDown.ForeColor = System.Drawing.Color.White;
            this.txtPlayerDown.Location = new System.Drawing.Point(514, 40);
            this.txtPlayerDown.Name = "txtPlayerDown";
            this.txtPlayerDown.Size = new System.Drawing.Size(77, 13);
            this.txtPlayerDown.TabIndex = 2;
            this.txtPlayerDown.Text = "Colision = false";
            // 
            // txtPlayerRight
            // 
            this.txtPlayerRight.AutoSize = true;
            this.txtPlayerRight.ForeColor = System.Drawing.Color.White;
            this.txtPlayerRight.Location = new System.Drawing.Point(514, 64);
            this.txtPlayerRight.Name = "txtPlayerRight";
            this.txtPlayerRight.Size = new System.Drawing.Size(77, 13);
            this.txtPlayerRight.TabIndex = 2;
            this.txtPlayerRight.Text = "Colision = false";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtMiddleX);
            this.Controls.Add(this.txtMiddleY);
            this.Controls.Add(this.txtLeftPlayer);
            this.Controls.Add(this.txtUpWall);
            this.Controls.Add(this.txtLeftWall);
            this.Controls.Add(this.txtRightWall);
            this.Controls.Add(this.txtPlayerRight);
            this.Controls.Add(this.txtPlayerDown);
            this.Controls.Add(this.txtUpPlayer);
            this.Controls.Add(this.txtDownWall);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.txtUp);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtColisionDown);
            this.Controls.Add(this.txtColisionUp);
            this.Controls.Add(this.txtColisionRight);
            this.Controls.Add(this.txtColisionLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Into the Unknown";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtColisionLeft;
        private System.Windows.Forms.Label txtColisionRight;
        private System.Windows.Forms.Label txtColisionUp;
        private System.Windows.Forms.Label txtColisionDown;
        private System.Windows.Forms.Label txtRight;
        private System.Windows.Forms.Label txtLeft;
        private System.Windows.Forms.Label txtUp;
        private System.Windows.Forms.Label txtDown;
        private System.Windows.Forms.Label txtMiddleY;
        private System.Windows.Forms.Label txtMiddleX;
        private System.Windows.Forms.Label txtDownWall;
        private System.Windows.Forms.Label txtUpPlayer;
        private System.Windows.Forms.Label txtRightWall;
        private System.Windows.Forms.Label txtLeftPlayer;
        private System.Windows.Forms.Label txtLeftWall;
        private System.Windows.Forms.Label txtUpWall;
        private System.Windows.Forms.Label txtPlayerDown;
        private System.Windows.Forms.Label txtPlayerRight;
    }
}

