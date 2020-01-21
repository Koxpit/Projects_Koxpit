namespace _6_GAMES
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяМинимальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяНормальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяБыстраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяОченьБыстраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.сToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.начатьToolStripMenuItem.Text = "Старт";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // сToolStripMenuItem
            // 
            this.сToolStripMenuItem.Name = "сToolStripMenuItem";
            this.сToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.сToolStripMenuItem.Text = "Стоп";
            this.сToolStripMenuItem.Click += new System.EventHandler(this.сToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem,
            this.скоростьЧервяМинимальнаяToolStripMenuItem,
            this.скоростьЧервяToolStripMenuItem,
            this.скоростьЧервяНормальнаяToolStripMenuItem,
            this.скоростьЧервяБыстраяToolStripMenuItem,
            this.скоростьЧервяОченьБыстраяToolStripMenuItem,
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // скоростьЧервяУльтраМедленнаяToolStripMenuItem
            // 
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem.Name = "скоростьЧервяУльтраМедленнаяToolStripMenuItem";
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem.Text = "Скорость червя: ультра медленная";
            this.скоростьЧервяУльтраМедленнаяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяУльтраМедленнаяToolStripMenuItem_Click);
            // 
            // скоростьЧервяМинимальнаяToolStripMenuItem
            // 
            this.скоростьЧервяМинимальнаяToolStripMenuItem.Name = "скоростьЧервяМинимальнаяToolStripMenuItem";
            this.скоростьЧервяМинимальнаяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяМинимальнаяToolStripMenuItem.Text = "Скорость червя: очень медленная";
            this.скоростьЧервяМинимальнаяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяМинимальнаяToolStripMenuItem_Click);
            // 
            // скоростьЧервяToolStripMenuItem
            // 
            this.скоростьЧервяToolStripMenuItem.Name = "скоростьЧервяToolStripMenuItem";
            this.скоростьЧервяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяToolStripMenuItem.Text = "Скорость червя: медленная";
            this.скоростьЧервяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяToolStripMenuItem_Click);
            // 
            // скоростьЧервяНормальнаяToolStripMenuItem
            // 
            this.скоростьЧервяНормальнаяToolStripMenuItem.Name = "скоростьЧервяНормальнаяToolStripMenuItem";
            this.скоростьЧервяНормальнаяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяНормальнаяToolStripMenuItem.Text = "Скорость червя: нормальная";
            this.скоростьЧервяНормальнаяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяНормальнаяToolStripMenuItem_Click);
            // 
            // скоростьЧервяБыстраяToolStripMenuItem
            // 
            this.скоростьЧервяБыстраяToolStripMenuItem.Name = "скоростьЧервяБыстраяToolStripMenuItem";
            this.скоростьЧервяБыстраяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяБыстраяToolStripMenuItem.Text = "Скорость червя: быстрая";
            this.скоростьЧервяБыстраяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяБыстраяToolStripMenuItem_Click);
            // 
            // скоростьЧервяОченьБыстраяToolStripMenuItem
            // 
            this.скоростьЧервяОченьБыстраяToolStripMenuItem.Name = "скоростьЧервяОченьБыстраяToolStripMenuItem";
            this.скоростьЧервяОченьБыстраяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяОченьБыстраяToolStripMenuItem.Text = "Скорость червя: очень быстрая";
            this.скоростьЧервяОченьБыстраяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяОченьБыстраяToolStripMenuItem_Click);
            // 
            // скоростьЧервяУльтраБыстраяToolStripMenuItem
            // 
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem.Name = "скоростьЧервяУльтраБыстраяToolStripMenuItem";
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem.Text = "Скорость червя: ультра быстрая";
            this.скоростьЧервяУльтраБыстраяToolStripMenuItem.Click += new System.EventHandler(this.скоростьЧервяУльтраБыстраяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Game1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game1";
            this.Text = "Змейка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяМинимальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяНормальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяБыстраяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяОченьБыстраяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяУльтраМедленнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьЧервяУльтраБыстраяToolStripMenuItem;
    }
}