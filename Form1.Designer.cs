namespace GUI_PrggrammingGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.missedShots = new System.Windows.Forms.Label();
            this.totalShots = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.PictureBox();
            this.timerCount = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.PictureBox();
            this.gameOver = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.lazerShoot = new AxWMPLib.AxWindowsMediaPlayer();
            this.win = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazerShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Turquoise;
            this.startButton.Location = new System.Drawing.Point(777, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(165, 20);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Restart";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Turquoise;
            this.exitButton.Location = new System.Drawing.Point(948, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 20);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Turquoise;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(188, 8);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(68, 20);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // missedShots
            // 
            this.missedShots.AutoSize = true;
            this.missedShots.BackColor = System.Drawing.Color.Turquoise;
            this.missedShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedShots.Location = new System.Drawing.Point(262, 8);
            this.missedShots.Name = "missedShots";
            this.missedShots.Size = new System.Drawing.Size(76, 20);
            this.missedShots.TabIndex = 3;
            this.missedShots.Text = "Missed: 0";
            this.missedShots.Click += new System.EventHandler(this.missedShots_Click);
            // 
            // totalShots
            // 
            this.totalShots.AutoSize = true;
            this.totalShots.BackColor = System.Drawing.Color.Turquoise;
            this.totalShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShots.Location = new System.Drawing.Point(344, 8);
            this.totalShots.Name = "totalShots";
            this.totalShots.Size = new System.Drawing.Size(61, 20);
            this.totalShots.TabIndex = 4;
            this.totalShots.Text = "Total: 0";
            this.totalShots.Click += new System.EventHandler(this.totalShots_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GUI_PrggrammingGame.Properties.Resources.alien_3;
            this.pictureBox2.Location = new System.Drawing.Point(16, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // over
            // 
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Image = global::GUI_PrggrammingGame.Properties.Resources.Gameover1;
            this.over.Location = new System.Drawing.Point(-4, -6);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(1131, 424);
            this.over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.over.TabIndex = 9;
            this.over.TabStop = false;
            this.over.Visible = false;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // timerCount
            // 
            this.timerCount.AutoSize = true;
            this.timerCount.BackColor = System.Drawing.Color.Turquoise;
            this.timerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerCount.Location = new System.Drawing.Point(12, 8);
            this.timerCount.Name = "timerCount";
            this.timerCount.Size = new System.Drawing.Size(163, 20);
            this.timerCount.TabIndex = 10;
            this.timerCount.Text = "Time left:  15 seconds";
            this.timerCount.Click += new System.EventHandler(this.timerCount_Click);
            // 
            // winner
            // 
            this.winner.BackColor = System.Drawing.Color.Transparent;
            this.winner.Image = global::GUI_PrggrammingGame.Properties.Resources.winner2;
            this.winner.Location = new System.Drawing.Point(-9, -6);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(1136, 424);
            this.winner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winner.TabIndex = 11;
            this.winner.TabStop = false;
            this.winner.Visible = false;
            this.winner.Click += new System.EventHandler(this.winner_Click);
            // 
            // gameOver
            // 
            this.gameOver.Enabled = true;
            this.gameOver.Location = new System.Drawing.Point(870, 217);
            this.gameOver.Name = "gameOver";
            this.gameOver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gameOver.OcxState")));
            this.gameOver.Size = new System.Drawing.Size(243, 48);
            this.gameOver.TabIndex = 13;
            this.gameOver.Visible = false;
            // 
            // backgroundMusic
            // 
            this.backgroundMusic.Enabled = true;
            this.backgroundMusic.Location = new System.Drawing.Point(870, 166);
            this.backgroundMusic.Name = "backgroundMusic";
            this.backgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("backgroundMusic.OcxState")));
            this.backgroundMusic.Size = new System.Drawing.Size(243, 48);
            this.backgroundMusic.TabIndex = 14;
            this.backgroundMusic.Visible = false;
            this.backgroundMusic.Enter += new System.EventHandler(this.backgroundMusic_Enter);
            // 
            // lazerShoot
            // 
            this.lazerShoot.Enabled = true;
            this.lazerShoot.Location = new System.Drawing.Point(870, 112);
            this.lazerShoot.Name = "lazerShoot";
            this.lazerShoot.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lazerShoot.OcxState")));
            this.lazerShoot.Size = new System.Drawing.Size(243, 48);
            this.lazerShoot.TabIndex = 15;
            this.lazerShoot.Visible = false;
            // 
            // win
            // 
            this.win.Enabled = true;
            this.win.Location = new System.Drawing.Point(870, 58);
            this.win.Name = "win";
            this.win.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("win.OcxState")));
            this.win.Size = new System.Drawing.Size(243, 48);
            this.win.TabIndex = 16;
            this.win.Visible = false;
            this.win.Enter += new System.EventHandler(this.win_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_PrggrammingGame.Properties.Resources.GUI_game_background;
            this.ClientSize = new System.Drawing.Size(1125, 417);
            this.Controls.Add(this.win);
            this.Controls.Add(this.lazerShoot);
            this.Controls.Add(this.backgroundMusic);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.over);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.timerCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.totalShots);
            this.Controls.Add(this.missedShots);
            this.Controls.Add(this.Score);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazerShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label missedShots;
        private System.Windows.Forms.Label totalShots;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox over;
        private System.Windows.Forms.Label timerCount;
        private System.Windows.Forms.PictureBox winner;
        private AxWMPLib.AxWindowsMediaPlayer gameOver;
        private AxWMPLib.AxWindowsMediaPlayer backgroundMusic;
        private AxWMPLib.AxWindowsMediaPlayer lazerShoot;
        private AxWMPLib.AxWindowsMediaPlayer win;
    }
}

