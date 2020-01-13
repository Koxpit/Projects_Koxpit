namespace SlideShow
{
    partial class Галерея
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Галерея));
            this.menuStripGallery = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxGallery = new System.Windows.Forms.ListBox();
            this.pictureBoxGallery = new System.Windows.Forms.PictureBox();
            this.NextImageLabel = new System.Windows.Forms.Button();
            this.PreviousImageLabel = new System.Windows.Forms.Button();
            this.printDialogGallery = new System.Windows.Forms.PrintDialog();
            this.menuStripGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripGallery
            // 
            this.menuStripGallery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem1});
            this.menuStripGallery.Location = new System.Drawing.Point(0, 0);
            this.menuStripGallery.Name = "menuStripGallery";
            this.menuStripGallery.Size = new System.Drawing.Size(944, 24);
            this.menuStripGallery.TabIndex = 0;
            this.menuStripGallery.Text = "menuStrip";
            // 
            // менюToolStripMenuItem1
            // 
            this.менюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem});
            this.менюToolStripMenuItem1.Name = "менюToolStripMenuItem1";
            this.менюToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem1.Text = "Меню";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click_1);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.удалитьToolStripMenuItem.Text = "Печать";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // listBoxGallery
            // 
            this.listBoxGallery.FormattingEnabled = true;
            this.listBoxGallery.HorizontalScrollbar = true;
            this.listBoxGallery.Location = new System.Drawing.Point(12, 40);
            this.listBoxGallery.Name = "listBoxGallery";
            this.listBoxGallery.Size = new System.Drawing.Size(174, 394);
            this.listBoxGallery.TabIndex = 1;
            this.listBoxGallery.SelectedIndexChanged += new System.EventHandler(this.listBoxGallery_SelectedIndexChanged);
            // 
            // pictureBoxGallery
            // 
            this.pictureBoxGallery.Location = new System.Drawing.Point(219, 43);
            this.pictureBoxGallery.Name = "pictureBoxGallery";
            this.pictureBoxGallery.Size = new System.Drawing.Size(700, 450);
            this.pictureBoxGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGallery.TabIndex = 2;
            this.pictureBoxGallery.TabStop = false;
            // 
            // NextImageLabel
            // 
            this.NextImageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextImageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextImageLabel.FlatAppearance.BorderSize = 0;
            this.NextImageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextImageLabel.Location = new System.Drawing.Point(114, 449);
            this.NextImageLabel.Name = "NextImageLabel";
            this.NextImageLabel.Size = new System.Drawing.Size(60, 44);
            this.NextImageLabel.TabIndex = 3;
            this.NextImageLabel.Text = ">";
            this.NextImageLabel.UseVisualStyleBackColor = false;
            this.NextImageLabel.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // PreviousImageLabel
            // 
            this.PreviousImageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PreviousImageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousImageLabel.FlatAppearance.BorderSize = 0;
            this.PreviousImageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousImageLabel.Location = new System.Drawing.Point(21, 449);
            this.PreviousImageLabel.Name = "PreviousImageLabel";
            this.PreviousImageLabel.Size = new System.Drawing.Size(60, 44);
            this.PreviousImageLabel.TabIndex = 4;
            this.PreviousImageLabel.Text = "<";
            this.PreviousImageLabel.UseVisualStyleBackColor = false;
            this.PreviousImageLabel.Click += new System.EventHandler(this.PreviousImage_Click);
            // 
            // printDialogGallery
            // 
            this.printDialogGallery.UseEXDialog = true;
            // 
            // Галерея
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.PreviousImageLabel);
            this.Controls.Add(this.NextImageLabel);
            this.Controls.Add(this.pictureBoxGallery);
            this.Controls.Add(this.listBoxGallery);
            this.Controls.Add(this.menuStripGallery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripGallery;
            this.MaximumSize = new System.Drawing.Size(960, 570);
            this.MinimumSize = new System.Drawing.Size(960, 570);
            this.Name = "Галерея";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Галерея";
            this.menuStripGallery.ResumeLayout(false);
            this.menuStripGallery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGallery;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        protected internal System.Windows.Forms.ListBox listBoxGallery;
        protected internal System.Windows.Forms.PictureBox pictureBoxGallery;
        private System.Windows.Forms.Button NextImageLabel;
        private System.Windows.Forms.Button PreviousImageLabel;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialogGallery;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
    }
}