namespace _6_GAMES
{
    partial class Game5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game5));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.eat = new System.Windows.Forms.Button();
            this.slep = new System.Windows.Forms.Button();
            this.pictureBoxHero = new System.Windows.Forms.PictureBox();
            this.game = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBarHungry = new System.Windows.Forms.ProgressBar();
            this.progressBarFatigue = new System.Windows.Forms.ProgressBar();
            this.progressBarHappy = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_game = new System.Windows.Forms.Button();
            this.no_slep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.png");
            this.imageList.Images.SetKeyName(1, "2.png");
            this.imageList.Images.SetKeyName(2, "3.png");
            this.imageList.Images.SetKeyName(3, "4.png");
            this.imageList.Images.SetKeyName(4, "5.png");
            this.imageList.Images.SetKeyName(5, "6.png");
            this.imageList.Images.SetKeyName(6, "7.png");
            this.imageList.Images.SetKeyName(7, "8.png");
            this.imageList.Images.SetKeyName(8, "9.png");
            // 
            // eat
            // 
            this.eat.BackColor = System.Drawing.Color.LawnGreen;
            this.eat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eat.Location = new System.Drawing.Point(12, 240);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(75, 23);
            this.eat.TabIndex = 0;
            this.eat.Text = "Кормить";
            this.eat.UseVisualStyleBackColor = false;
            this.eat.Click += new System.EventHandler(this.eat_Click);
            // 
            // slep
            // 
            this.slep.BackColor = System.Drawing.Color.LawnGreen;
            this.slep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slep.Location = new System.Drawing.Point(93, 240);
            this.slep.Name = "slep";
            this.slep.Size = new System.Drawing.Size(75, 23);
            this.slep.TabIndex = 1;
            this.slep.Text = "Спать";
            this.slep.UseVisualStyleBackColor = false;
            this.slep.Click += new System.EventHandler(this.slep_Click);
            // 
            // pictureBoxHero
            // 
            this.pictureBoxHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHero.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHero.Name = "pictureBoxHero";
            this.pictureBoxHero.Size = new System.Drawing.Size(237, 222);
            this.pictureBoxHero.TabIndex = 2;
            this.pictureBoxHero.TabStop = false;
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.LawnGreen;
            this.game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game.Location = new System.Drawing.Point(174, 240);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(75, 23);
            this.game.TabIndex = 3;
            this.game.Text = "Играть";
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBarHungry
            // 
            this.progressBarHungry.Location = new System.Drawing.Point(255, 27);
            this.progressBarHungry.Maximum = 1000;
            this.progressBarHungry.Name = "progressBarHungry";
            this.progressBarHungry.Size = new System.Drawing.Size(179, 23);
            this.progressBarHungry.TabIndex = 4;
            // 
            // progressBarFatigue
            // 
            this.progressBarFatigue.Location = new System.Drawing.Point(255, 73);
            this.progressBarFatigue.Maximum = 1000;
            this.progressBarFatigue.Name = "progressBarFatigue";
            this.progressBarFatigue.Size = new System.Drawing.Size(179, 23);
            this.progressBarFatigue.TabIndex = 5;
            // 
            // progressBarHappy
            // 
            this.progressBarHappy.Location = new System.Drawing.Point(255, 127);
            this.progressBarHappy.Maximum = 1000;
            this.progressBarHappy.Name = "progressBarHappy";
            this.progressBarHappy.Size = new System.Drawing.Size(179, 23);
            this.progressBarHappy.TabIndex = 6;
            this.progressBarHappy.Value = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Голод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Усталость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Счастье";
            // 
            // new_game
            // 
            this.new_game.BackgroundImage = global::_6_GAMES.Properties.Resources._6_GAMES;
            this.new_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_game.Location = new System.Drawing.Point(255, 156);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(179, 136);
            this.new_game.TabIndex = 11;
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // no_slep
            // 
            this.no_slep.BackColor = System.Drawing.Color.LawnGreen;
            this.no_slep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no_slep.Location = new System.Drawing.Point(93, 269);
            this.no_slep.Name = "no_slep";
            this.no_slep.Size = new System.Drawing.Size(75, 23);
            this.no_slep.TabIndex = 12;
            this.no_slep.Text = "Разбудить";
            this.no_slep.UseVisualStyleBackColor = false;
            this.no_slep.Click += new System.EventHandler(this.no_slep_Click);
            // 
            // Game5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 300);
            this.Controls.Add(this.no_slep);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarHappy);
            this.Controls.Add(this.progressBarFatigue);
            this.Controls.Add(this.progressBarHungry);
            this.Controls.Add(this.game);
            this.Controls.Add(this.pictureBoxHero);
            this.Controls.Add(this.slep);
            this.Controls.Add(this.eat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тамагочи";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button eat;
        private System.Windows.Forms.Button slep;
        private System.Windows.Forms.PictureBox pictureBoxHero;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBarHungry;
        private System.Windows.Forms.ProgressBar progressBarFatigue;
        private System.Windows.Forms.ProgressBar progressBarHappy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button no_slep;
    }
}