namespace Calculator_Pay
{
    partial class PieceRateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PieceRateForm));
            this.IsHoursStakeRadioButton = new System.Windows.Forms.RadioButton();
            this.IsDaysStakeRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PayOnHandTextBox = new System.Windows.Forms.TextBox();
            this.PayOnHandLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExistBonuseCheckBox = new System.Windows.Forms.CheckBox();
            this.BonuseTextBox = new System.Windows.Forms.TextBox();
            this.BonuseLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StakeGroupBox = new System.Windows.Forms.GroupBox();
            this.FormOfPayGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgressFormRadioButton = new System.Windows.Forms.RadioButton();
            this.IsDirectFormRadioButton = new System.Windows.Forms.RadioButton();
            this.IsIndirectFormRadioButton = new System.Windows.Forms.RadioButton();
            this.IsAccordFormRadioButton = new System.Windows.Forms.RadioButton();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.CertificateButton = new System.Windows.Forms.Button();
            this.StakeGroupBox.SuspendLayout();
            this.FormOfPayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsHoursStakeRadioButton
            // 
            this.IsHoursStakeRadioButton.AutoSize = true;
            this.IsHoursStakeRadioButton.Checked = true;
            this.IsHoursStakeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.IsHoursStakeRadioButton.Name = "IsHoursStakeRadioButton";
            this.IsHoursStakeRadioButton.Size = new System.Drawing.Size(69, 17);
            this.IsHoursStakeRadioButton.TabIndex = 0;
            this.IsHoursStakeRadioButton.TabStop = true;
            this.IsHoursStakeRadioButton.Text = "Часовая";
            this.IsHoursStakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // IsDaysStakeRadioButton
            // 
            this.IsDaysStakeRadioButton.AutoSize = true;
            this.IsDaysStakeRadioButton.Location = new System.Drawing.Point(101, 19);
            this.IsDaysStakeRadioButton.Name = "IsDaysStakeRadioButton";
            this.IsDaysStakeRadioButton.Size = new System.Drawing.Size(70, 17);
            this.IsDaysStakeRadioButton.TabIndex = 1;
            this.IsDaysStakeRadioButton.TabStop = true;
            this.IsDaysStakeRadioButton.Text = "Дневная";
            this.IsDaysStakeRadioButton.UseVisualStyleBackColor = true;
            this.IsDaysStakeRadioButton.CheckedChanged += new System.EventHandler(this.IsDaysStakeRadioButton_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 155);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(98, 34);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Расчет";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Норматив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ставка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество:";
            // 
            // PayOnHandTextBox
            // 
            this.PayOnHandTextBox.Location = new System.Drawing.Point(136, 192);
            this.PayOnHandTextBox.Name = "PayOnHandTextBox";
            this.PayOnHandTextBox.ReadOnly = true;
            this.PayOnHandTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayOnHandTextBox.TabIndex = 9;
            // 
            // PayOnHandLabel
            // 
            this.PayOnHandLabel.AutoSize = true;
            this.PayOnHandLabel.Location = new System.Drawing.Point(12, 192);
            this.PayOnHandLabel.Name = "PayOnHandLabel";
            this.PayOnHandLabel.Size = new System.Drawing.Size(99, 13);
            this.PayOnHandLabel.TabIndex = 10;
            this.PayOnHandLabel.Text = "Зарплата на руки:";
            // 
            // ExistBonuseCheckBox
            // 
            this.ExistBonuseCheckBox.AutoSize = true;
            this.ExistBonuseCheckBox.Location = new System.Drawing.Point(431, 172);
            this.ExistBonuseCheckBox.Name = "ExistBonuseCheckBox";
            this.ExistBonuseCheckBox.Size = new System.Drawing.Size(66, 17);
            this.ExistBonuseCheckBox.TabIndex = 11;
            this.ExistBonuseCheckBox.Text = "Премия";
            this.ExistBonuseCheckBox.UseVisualStyleBackColor = true;
            this.ExistBonuseCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BonuseTextBox
            // 
            this.BonuseTextBox.Location = new System.Drawing.Point(431, 143);
            this.BonuseTextBox.Name = "BonuseTextBox";
            this.BonuseTextBox.Size = new System.Drawing.Size(100, 20);
            this.BonuseTextBox.TabIndex = 12;
            this.BonuseTextBox.Visible = false;
            // 
            // BonuseLabel
            // 
            this.BonuseLabel.AutoSize = true;
            this.BonuseLabel.Location = new System.Drawing.Point(280, 143);
            this.BonuseLabel.Name = "BonuseLabel";
            this.BonuseLabel.Size = new System.Drawing.Size(50, 13);
            this.BonuseLabel.TabIndex = 13;
            this.BonuseLabel.Text = "Премия:";
            this.BonuseLabel.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(431, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(431, 117);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Сверх нормы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Повышенная ставка:";
            // 
            // StakeGroupBox
            // 
            this.StakeGroupBox.Controls.Add(this.IsHoursStakeRadioButton);
            this.StakeGroupBox.Controls.Add(this.IsDaysStakeRadioButton);
            this.StakeGroupBox.Location = new System.Drawing.Point(15, 12);
            this.StakeGroupBox.Name = "StakeGroupBox";
            this.StakeGroupBox.Size = new System.Drawing.Size(200, 54);
            this.StakeGroupBox.TabIndex = 18;
            this.StakeGroupBox.TabStop = false;
            this.StakeGroupBox.Text = "Ставка";
            // 
            // FormOfPayGroupBox
            // 
            this.FormOfPayGroupBox.Controls.Add(this.ProgressFormRadioButton);
            this.FormOfPayGroupBox.Controls.Add(this.IsDirectFormRadioButton);
            this.FormOfPayGroupBox.Controls.Add(this.IsIndirectFormRadioButton);
            this.FormOfPayGroupBox.Controls.Add(this.IsAccordFormRadioButton);
            this.FormOfPayGroupBox.Location = new System.Drawing.Point(293, 12);
            this.FormOfPayGroupBox.Name = "FormOfPayGroupBox";
            this.FormOfPayGroupBox.Size = new System.Drawing.Size(238, 69);
            this.FormOfPayGroupBox.TabIndex = 19;
            this.FormOfPayGroupBox.TabStop = false;
            this.FormOfPayGroupBox.Text = "Форма оплаты";
            // 
            // ProgressFormRadioButton
            // 
            this.ProgressFormRadioButton.AutoSize = true;
            this.ProgressFormRadioButton.Checked = true;
            this.ProgressFormRadioButton.Location = new System.Drawing.Point(111, 42);
            this.ProgressFormRadioButton.Name = "ProgressFormRadioButton";
            this.ProgressFormRadioButton.Size = new System.Drawing.Size(104, 17);
            this.ProgressFormRadioButton.TabIndex = 21;
            this.ProgressFormRadioButton.TabStop = true;
            this.ProgressFormRadioButton.Text = "Прогрессивная";
            this.ProgressFormRadioButton.UseVisualStyleBackColor = true;
            this.ProgressFormRadioButton.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // IsDirectFormRadioButton
            // 
            this.IsDirectFormRadioButton.AutoSize = true;
            this.IsDirectFormRadioButton.Location = new System.Drawing.Point(111, 19);
            this.IsDirectFormRadioButton.Name = "IsDirectFormRadioButton";
            this.IsDirectFormRadioButton.Size = new System.Drawing.Size(65, 17);
            this.IsDirectFormRadioButton.TabIndex = 20;
            this.IsDirectFormRadioButton.TabStop = true;
            this.IsDirectFormRadioButton.Text = "Прямая";
            this.IsDirectFormRadioButton.UseVisualStyleBackColor = true;
            this.IsDirectFormRadioButton.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // IsIndirectFormRadioButton
            // 
            this.IsIndirectFormRadioButton.AutoSize = true;
            this.IsIndirectFormRadioButton.Location = new System.Drawing.Point(6, 19);
            this.IsIndirectFormRadioButton.Name = "IsIndirectFormRadioButton";
            this.IsIndirectFormRadioButton.Size = new System.Drawing.Size(80, 17);
            this.IsIndirectFormRadioButton.TabIndex = 1;
            this.IsIndirectFormRadioButton.TabStop = true;
            this.IsIndirectFormRadioButton.Text = "Косвенная";
            this.IsIndirectFormRadioButton.UseVisualStyleBackColor = true;
            this.IsIndirectFormRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // IsAccordFormRadioButton
            // 
            this.IsAccordFormRadioButton.AutoSize = true;
            this.IsAccordFormRadioButton.Location = new System.Drawing.Point(6, 42);
            this.IsAccordFormRadioButton.Name = "IsAccordFormRadioButton";
            this.IsAccordFormRadioButton.Size = new System.Drawing.Size(80, 17);
            this.IsAccordFormRadioButton.TabIndex = 0;
            this.IsAccordFormRadioButton.TabStop = true;
            this.IsAccordFormRadioButton.Text = "Аккордная";
            this.IsAccordFormRadioButton.UseVisualStyleBackColor = true;
            this.IsAccordFormRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(340, 195);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(92, 36);
            this.PrintButton.TabIndex = 20;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Location = new System.Drawing.Point(440, 195);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(92, 36);
            this.ExportToExcelButton.TabIndex = 21;
            this.ExportToExcelButton.Text = "В Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = true;
            this.ExportToExcelButton.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // CertificateButton
            // 
            this.CertificateButton.Location = new System.Drawing.Point(242, 195);
            this.CertificateButton.Name = "CertificateButton";
            this.CertificateButton.Size = new System.Drawing.Size(92, 36);
            this.CertificateButton.TabIndex = 22;
            this.CertificateButton.Text = "Справка";
            this.CertificateButton.UseVisualStyleBackColor = true;
            this.CertificateButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PieceRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(544, 251);
            this.Controls.Add(this.CertificateButton);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.FormOfPayGroupBox);
            this.Controls.Add(this.StakeGroupBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.BonuseLabel);
            this.Controls.Add(this.BonuseTextBox);
            this.Controls.Add(this.ExistBonuseCheckBox);
            this.Controls.Add(this.PayOnHandLabel);
            this.Controls.Add(this.PayOnHandTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 290);
            this.MinimumSize = new System.Drawing.Size(560, 290);
            this.Name = "PieceRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сдельная оплата труда";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.StakeGroupBox.ResumeLayout(false);
            this.StakeGroupBox.PerformLayout();
            this.FormOfPayGroupBox.ResumeLayout(false);
            this.FormOfPayGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IsHoursStakeRadioButton;
        private System.Windows.Forms.RadioButton IsDaysStakeRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PayOnHandTextBox;
        private System.Windows.Forms.Label PayOnHandLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox ExistBonuseCheckBox;
        private System.Windows.Forms.TextBox BonuseTextBox;
        private System.Windows.Forms.Label BonuseLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox StakeGroupBox;
        private System.Windows.Forms.GroupBox FormOfPayGroupBox;
        private System.Windows.Forms.RadioButton IsIndirectFormRadioButton;
        private System.Windows.Forms.RadioButton IsAccordFormRadioButton;
        private System.Windows.Forms.RadioButton ProgressFormRadioButton;
        private System.Windows.Forms.RadioButton IsDirectFormRadioButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.Button CertificateButton;
        protected internal System.Windows.Forms.TextBox textBox1;
    }
}