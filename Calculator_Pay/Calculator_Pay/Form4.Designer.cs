namespace Calculator_Pay
{
    partial class Form4
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
            if (disposing&&(components!=null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.PieceRateFormPayButton = new System.Windows.Forms.Button();
            this.ChargedFormPayButton = new System.Windows.Forms.Button();
            this.AboutProgramButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PieceRateFormPayButton
            // 
            this.PieceRateFormPayButton.Location = new System.Drawing.Point(193, 12);
            this.PieceRateFormPayButton.Name = "PieceRateFormPayButton";
            this.PieceRateFormPayButton.Size = new System.Drawing.Size(139, 50);
            this.PieceRateFormPayButton.TabIndex = 1;
            this.PieceRateFormPayButton.Text = "Сдельная";
            this.PieceRateFormPayButton.UseVisualStyleBackColor = true;
            this.PieceRateFormPayButton.Click += new System.EventHandler(this.PieceRateFormPayButton_Click);
            // 
            // ChargedFormPayButton
            // 
            this.ChargedFormPayButton.Location = new System.Drawing.Point(12, 12);
            this.ChargedFormPayButton.Name = "ChargedFormPayButton";
            this.ChargedFormPayButton.Size = new System.Drawing.Size(139, 50);
            this.ChargedFormPayButton.TabIndex = 0;
            this.ChargedFormPayButton.Text = "Повременная";
            this.ChargedFormPayButton.UseVisualStyleBackColor = true;
            this.ChargedFormPayButton.Click += new System.EventHandler(this.ChargedFormPayButton_Click);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.Location = new System.Drawing.Point(101, 68);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(139, 50);
            this.AboutProgramButton.TabIndex = 2;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(344, 126);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.PieceRateFormPayButton);
            this.Controls.Add(this.ChargedFormPayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 165);
            this.MinimumSize = new System.Drawing.Size(360, 165);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма оплаты труда";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PieceRateFormPayButton;
        private System.Windows.Forms.Button ChargedFormPayButton;
        private System.Windows.Forms.Button AboutProgramButton;
    }
}