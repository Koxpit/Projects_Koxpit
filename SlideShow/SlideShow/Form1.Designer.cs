namespace SlideShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.checkStartBegin = new System.Windows.Forms.CheckBox();
            this.aroundShow = new System.Windows.Forms.CheckBox();
            this.LoadMusic = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            this.SecInter = new System.Windows.Forms.Label();
            this.SecInterval = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПрезентациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВJPGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оформлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерСлайдовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартный43ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.широкоэкранный169ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.animationButton = new System.Windows.Forms.Button();
            this.galleryButton = new System.Windows.Forms.Button();
            this.ShowSlide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LabelPrev = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.TopPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Controls.Add(this.checkStartBegin);
            this.TopPanel.Controls.Add(this.aroundShow);
            this.TopPanel.Controls.Add(this.LoadMusic);
            this.TopPanel.Controls.Add(this.LoadImage);
            this.TopPanel.Controls.Add(this.SecInter);
            this.TopPanel.Controls.Add(this.SecInterval);
            this.TopPanel.Controls.Add(this.menuStrip1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 119);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // checkStartBegin
            // 
            this.checkStartBegin.AutoSize = true;
            this.checkStartBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkStartBegin.Location = new System.Drawing.Point(758, 50);
            this.checkStartBegin.Name = "checkStartBegin";
            this.checkStartBegin.Size = new System.Drawing.Size(114, 19);
            this.checkStartBegin.TabIndex = 10;
            this.checkStartBegin.Text = "Показ с начала";
            this.checkStartBegin.UseVisualStyleBackColor = true;
            // 
            // aroundShow
            // 
            this.aroundShow.AutoSize = true;
            this.aroundShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aroundShow.Location = new System.Drawing.Point(643, 50);
            this.aroundShow.Name = "aroundShow";
            this.aroundShow.Size = new System.Drawing.Size(109, 19);
            this.aroundShow.TabIndex = 9;
            this.aroundShow.Text = "Показ по кругу";
            this.aroundShow.UseVisualStyleBackColor = true;
            // 
            // LoadMusic
            // 
            this.LoadMusic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadMusic.FlatAppearance.BorderSize = 0;
            this.LoadMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadMusic.Location = new System.Drawing.Point(214, 40);
            this.LoadMusic.Name = "LoadMusic";
            this.LoadMusic.Size = new System.Drawing.Size(170, 56);
            this.LoadMusic.TabIndex = 6;
            this.LoadMusic.Text = "Загрузить музыку";
            this.LoadMusic.UseVisualStyleBackColor = false;
            this.LoadMusic.Click += new System.EventHandler(this.LoadMusic_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadImage.FlatAppearance.BorderSize = 0;
            this.LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadImage.Location = new System.Drawing.Point(27, 41);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(170, 55);
            this.LoadImage.TabIndex = 5;
            this.LoadImage.Text = "Загрузить изображения";
            this.LoadImage.UseVisualStyleBackColor = false;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // SecInter
            // 
            this.SecInter.AutoSize = true;
            this.SecInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecInter.Location = new System.Drawing.Point(571, 75);
            this.SecInter.Name = "SecInter";
            this.SecInter.Size = new System.Drawing.Size(150, 16);
            this.SecInter.TabIndex = 1;
            this.SecInter.Text = "Интервал в секундах:";
            // 
            // SecInterval
            // 
            this.SecInterval.FormattingEnabled = true;
            this.SecInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20",
            "30"});
            this.SecInterval.Location = new System.Drawing.Point(727, 75);
            this.SecInterval.Name = "SecInterval";
            this.SecInterval.Size = new System.Drawing.Size(121, 21);
            this.SecInterval.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оформлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.загрузитьПрезентациюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // загрузитьПрезентациюToolStripMenuItem
            // 
            this.загрузитьПрезентациюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьВJPGToolStripMenuItem1});
            this.загрузитьПрезентациюToolStripMenuItem.Name = "загрузитьПрезентациюToolStripMenuItem";
            this.загрузитьПрезентациюToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.загрузитьПрезентациюToolStripMenuItem.Text = "Презентация";
            this.загрузитьПрезентациюToolStripMenuItem.Click += new System.EventHandler(this.загрузитьПрезентациюToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьВJPGToolStripMenuItem1
            // 
            this.сохранитьВJPGToolStripMenuItem1.Name = "сохранитьВJPGToolStripMenuItem1";
            this.сохранитьВJPGToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.сохранитьВJPGToolStripMenuItem1.Text = "Сохранить в JPG";
            this.сохранитьВJPGToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьВJPGToolStripMenuItem1_Click);
            // 
            // оформлениеToolStripMenuItem
            // 
            this.оформлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерСлайдовToolStripMenuItem,
            this.форматФонаToolStripMenuItem});
            this.оформлениеToolStripMenuItem.Name = "оформлениеToolStripMenuItem";
            this.оформлениеToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.оформлениеToolStripMenuItem.Text = "Оформление";
            // 
            // размерСлайдовToolStripMenuItem
            // 
            this.размерСлайдовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартный43ToolStripMenuItem,
            this.широкоэкранный169ToolStripMenuItem});
            this.размерСлайдовToolStripMenuItem.Name = "размерСлайдовToolStripMenuItem";
            this.размерСлайдовToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.размерСлайдовToolStripMenuItem.Text = "Размер слайдов";
            // 
            // стандартный43ToolStripMenuItem
            // 
            this.стандартный43ToolStripMenuItem.Name = "стандартный43ToolStripMenuItem";
            this.стандартный43ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.стандартный43ToolStripMenuItem.Text = "Стандартный (4:3)";
            // 
            // широкоэкранный169ToolStripMenuItem
            // 
            this.широкоэкранный169ToolStripMenuItem.Name = "широкоэкранный169ToolStripMenuItem";
            this.широкоэкранный169ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.широкоэкранный169ToolStripMenuItem.Text = "Широкоэкранный (16:9)";
            // 
            // форматФонаToolStripMenuItem
            // 
            this.форматФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сплошнаяЗаливкаToolStripMenuItem,
            this.рисунокИзФайлаToolStripMenuItem});
            this.форматФонаToolStripMenuItem.Name = "форматФонаToolStripMenuItem";
            this.форматФонаToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.форматФонаToolStripMenuItem.Text = "Формат фона";
            // 
            // сплошнаяЗаливкаToolStripMenuItem
            // 
            this.сплошнаяЗаливкаToolStripMenuItem.Name = "сплошнаяЗаливкаToolStripMenuItem";
            this.сплошнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сплошнаяЗаливкаToolStripMenuItem.Text = "Сплошная заливка";
            // 
            // рисунокИзФайлаToolStripMenuItem
            // 
            this.рисунокИзФайлаToolStripMenuItem.Name = "рисунокИзФайлаToolStripMenuItem";
            this.рисунокИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.рисунокИзФайлаToolStripMenuItem.Text = "Рисунок из файла";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BottomPanel.Controls.Add(this.trackBar1);
            this.BottomPanel.Controls.Add(this.button1);
            this.BottomPanel.Controls.Add(this.animationButton);
            this.BottomPanel.Controls.Add(this.galleryButton);
            this.BottomPanel.Controls.Add(this.ShowSlide);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 461);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(884, 160);
            this.BottomPanel.TabIndex = 0;
            this.BottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomPanel_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(69, 6);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(738, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(529, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "Старт на весь экран";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animationButton
            // 
            this.animationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.animationButton.FlatAppearance.BorderSize = 0;
            this.animationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animationButton.Location = new System.Drawing.Point(201, 78);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(151, 69);
            this.animationButton.TabIndex = 6;
            this.animationButton.Text = "Пауза";
            this.animationButton.UseVisualStyleBackColor = false;
            this.animationButton.Click += new System.EventHandler(this.animationButton_Click);
            // 
            // galleryButton
            // 
            this.galleryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.galleryButton.FlatAppearance.BorderSize = 0;
            this.galleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.galleryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.galleryButton.Location = new System.Drawing.Point(27, 57);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(151, 69);
            this.galleryButton.TabIndex = 5;
            this.galleryButton.Text = "Галерея";
            this.galleryButton.UseVisualStyleBackColor = false;
            this.galleryButton.Click += new System.EventHandler(this.galleryButton_Click);
            // 
            // ShowSlide
            // 
            this.ShowSlide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowSlide.FlatAppearance.BorderSize = 0;
            this.ShowSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSlide.Location = new System.Drawing.Point(702, 57);
            this.ShowSlide.Name = "ShowSlide";
            this.ShowSlide.Size = new System.Drawing.Size(151, 71);
            this.ShowSlide.TabIndex = 4;
            this.ShowSlide.Text = "Старт";
            this.ShowSlide.UseVisualStyleBackColor = false;
            this.ShowSlide.Click += new System.EventHandler(this.ShowSlide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelPrev
            // 
            this.LabelPrev.AutoSize = true;
            this.LabelPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPrev.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelPrev.Location = new System.Drawing.Point(23, 165);
            this.LabelPrev.Name = "LabelPrev";
            this.LabelPrev.Size = new System.Drawing.Size(40, 42);
            this.LabelPrev.TabIndex = 0;
            this.LabelPrev.Text = "<";
            this.LabelPrev.Click += new System.EventHandler(this.LabelPrev_Click);
            this.LabelPrev.MouseLeave += new System.EventHandler(this.LabelPrev_MouseLeave);
            this.LabelPrev.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelPrev_MouseMove);
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNext.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelNext.Location = new System.Drawing.Point(6, 165);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(40, 42);
            this.labelNext.TabIndex = 4;
            this.labelNext.Text = ">";
            this.labelNext.Click += new System.EventHandler(this.labelNext_Click);
            this.labelNext.MouseLeave += new System.EventHandler(this.labelNext_MouseLeave);
            this.labelNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelNext_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LabelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 342);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.labelNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(807, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 342);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(69, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 342);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 660);
            this.MinimumSize = new System.Drawing.Size(900, 660);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlideShow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Label SecInter;
        private System.Windows.Forms.ComboBox SecInterval;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ShowSlide;
        private System.Windows.Forms.Button LoadMusic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button animationButton;
        private System.Windows.Forms.Button galleryButton;
        private System.Windows.Forms.Label LabelPrev;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox aroundShow;
        private System.Windows.Forms.CheckBox checkStartBegin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерСлайдовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартный43ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem широкоэкранный169ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокИзФайлаToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПрезентациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВJPGToolStripMenuItem1;
    }
}

