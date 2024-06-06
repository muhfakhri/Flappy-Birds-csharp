namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.BackHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeBottom.BackgroundImage")));
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom.Location = new System.Drawing.Point(237, -118);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(98, 277);
            this.pipeBottom.TabIndex = 0;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flappyBird.BackgroundImage")));
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flappyBird.Location = new System.Drawing.Point(55, 246);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(58, 53);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(-1, 540);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(465, 59);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.BackgroundImage")));
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop.Location = new System.Drawing.Point(320, 347);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(98, 195);
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.SystemColors.WindowText;
            this.scoreText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreText.Location = new System.Drawing.Point(12, 558);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(323, 33);
            this.scoreText.TabIndex = 6;
            this.scoreText.Text = "score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // BackHome
            // 
            this.BackHome.BackColor = System.Drawing.Color.Wheat;
            this.BackHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackHome.BackgroundImage")));
            this.BackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackHome.Image = ((System.Drawing.Image)(resources.GetObject("BackHome.Image")));
            this.BackHome.Location = new System.Drawing.Point(385, 558);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(42, 33);
            this.BackHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackHome.TabIndex = 7;
            this.BackHome.TabStop = false;
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 600);
            this.Controls.Add(this.BackHome);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeBottom);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlappyBird By Satria-Fakhri";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox BackHome;
    }
}

