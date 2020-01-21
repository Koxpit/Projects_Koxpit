namespace _6_GAMES
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.coins = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.PictureBox();
            this.fly = new System.Windows.Forms.PictureBox();
            this.phon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coins)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // coins
            // 
            this.coins.Image = global::_6_GAMES.Properties.Resources.coinNORM2;
            this.coins.Location = new System.Drawing.Point(72, 219);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(42, 43);
            this.coins.TabIndex = 2;
            this.coins.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Controls.Add(this.fly);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 441);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(795, 441);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.TabStop = false;
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // fly
            // 
            this.fly.Image = global::_6_GAMES.Properties.Resources.PlaneNORM;
            this.fly.Location = new System.Drawing.Point(252, 82);
            this.fly.Name = "fly";
            this.fly.Size = new System.Drawing.Size(363, 271);
            this.fly.TabIndex = 1;
            this.fly.TabStop = false;
            // 
            // phon
            // 
            this.phon.Image = ((System.Drawing.Image)(resources.GetObject("phon.Image")));
            this.phon.Location = new System.Drawing.Point(566, -8);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(801, 458);
            this.phon.TabIndex = 0;
            this.phon.TabStop = false;
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phon);
            this.Controls.Add(this.coins);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Самолет";
            ((System.ComponentModel.ISupportInitialize)(this.coins)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox coins;
        private System.Windows.Forms.PictureBox fly;
        private System.Windows.Forms.PictureBox phon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox MainPanel;
    }
}