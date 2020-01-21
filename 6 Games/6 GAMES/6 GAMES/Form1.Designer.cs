namespace _6_GAMES
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.Button();
            this.DONATE = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.SocNet = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::_6_GAMES.Properties.Resources.Game_1__Змейка_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 163);
            this.button1.TabIndex = 0;
            this.button1.Text = "Змейка";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::_6_GAMES.Properties.Resources.Game_2__платформер_;
            this.button2.Location = new System.Drawing.Point(186, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 163);
            this.button2.TabIndex = 1;
            this.button2.Text = "САМОЛЕТ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Image = global::_6_GAMES.Properties.Resources.Game3__Пятнашки_;
            this.button3.Location = new System.Drawing.Point(360, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 163);
            this.button3.TabIndex = 2;
            this.button3.Text = "ПЯТНАШКИ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = global::_6_GAMES.Properties.Resources.Game4__крестики_нолики;
            this.button4.Location = new System.Drawing.Point(12, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 163);
            this.button4.TabIndex = 3;
            this.button4.Text = "Крестики-нолики";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::_6_GAMES.Properties.Resources.Game_5__тамагочи_;
            this.button5.Location = new System.Drawing.Point(186, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 163);
            this.button5.TabIndex = 4;
            this.button5.Text = "Тамагочи";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("a_StamperRg&Bt", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::_6_GAMES.Properties.Resources.Game_6__арканоид_;
            this.button6.Location = new System.Drawing.Point(360, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 163);
            this.button6.TabIndex = 5;
            this.button6.Text = "Арканоид";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Games.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Games.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Games.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Games.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.Games.Location = new System.Drawing.Point(583, 27);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(153, 45);
            this.Games.TabIndex = 7;
            this.Games.Text = "О игре";
            this.Games.UseVisualStyleBackColor = false;
            this.Games.Click += new System.EventHandler(this.Games_Click);
            // 
            // DONATE
            // 
            this.DONATE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DONATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DONATE.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DONATE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DONATE.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.DONATE.Location = new System.Drawing.Point(583, 78);
            this.DONATE.Name = "DONATE";
            this.DONATE.Size = new System.Drawing.Size(153, 45);
            this.DONATE.TabIndex = 8;
            this.DONATE.Text = "Донат";
            this.DONATE.UseVisualStyleBackColor = false;
            this.DONATE.Click += new System.EventHandler(this.DONATE_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settings.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.settings.Location = new System.Drawing.Point(583, 129);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(153, 45);
            this.settings.TabIndex = 9;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // SocNet
            // 
            this.SocNet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SocNet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SocNet.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SocNet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SocNet.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.SocNet.Location = new System.Drawing.Point(583, 180);
            this.SocNet.Name = "SocNet";
            this.SocNet.Size = new System.Drawing.Size(153, 45);
            this.SocNet.TabIndex = 10;
            this.SocNet.Text = "Мы в соц.сетях";
            this.SocNet.UseVisualStyleBackColor = false;
            this.SocNet.Click += new System.EventHandler(this.SocNet_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.help.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.help.Location = new System.Drawing.Point(583, 231);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(153, 45);
            this.help.TabIndex = 11;
            this.help.Text = "Помощь";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Downcome(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Image = global::_6_GAMES.Properties.Resources.Кнопка;
            this.exit.Location = new System.Drawing.Point(583, 282);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(153, 45);
            this.exit.TabIndex = 12;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::_6_GAMES.Properties.Resources.Нейро_сеть;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 358);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.SocNet);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.DONATE);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6 GAMES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Games;
        private System.Windows.Forms.Button DONATE;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button SocNet;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
    }
}

