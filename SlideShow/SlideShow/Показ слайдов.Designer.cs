namespace SlideShow
{
    partial class Показ_слайдов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Показ_слайдов));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAllScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxAllScreen
            // 
            this.pictureBoxAllScreen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxAllScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAllScreen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAllScreen.Name = "pictureBoxAllScreen";
            this.pictureBoxAllScreen.Size = new System.Drawing.Size(584, 361);
            this.pictureBoxAllScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAllScreen.TabIndex = 0;
            this.pictureBoxAllScreen.TabStop = false;
            // 
            // Показ_слайдов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBoxAllScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Показ_слайдов";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Показ_слайдов";
            this.Load += new System.EventHandler(this.Показ_слайдов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        protected internal System.Windows.Forms.PictureBox pictureBoxAllScreen;
    }
}