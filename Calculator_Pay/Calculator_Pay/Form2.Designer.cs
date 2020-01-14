namespace Calculator_Pay
{
    partial class ChargedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargedForm));
            this.IsHoursPayRadioButton = new System.Windows.Forms.RadioButton();
            this.IsSalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.ExistBonuseCheckBox = new System.Windows.Forms.CheckBox();
            this.WorkTimeTextBox = new System.Windows.Forms.TextBox();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.WorkedTimeTextBox = new System.Windows.Forms.TextBox();
            this.WorkedTimeLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfChildsLabel = new System.Windows.Forms.Label();
            this.AvailablilityDisabledChildsLabel = new System.Windows.Forms.Label();
            this.DeducOnChildrenLabel = new System.Windows.Forms.Label();
            this.DeducExistOrNotLabel = new System.Windows.Forms.Label();
            this.SupplementsGroupBox = new System.Windows.Forms.GroupBox();
            this.SupplementedRadioButton = new System.Windows.Forms.RadioButton();
            this.UnsapplementedRadioButton = new System.Windows.Forms.RadioButton();
            this.RegionalSuppleRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NorthSuppleRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NorthSuppleLabel = new System.Windows.Forms.Label();
            this.SuppleExistOrNotLabel = new System.Windows.Forms.Label();
            this.RegionalSuppleLabel = new System.Windows.Forms.Label();
            this.BonuseLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PayOnHandTextBox = new System.Windows.Forms.TextBox();
            this.PayOnHandLabel = new System.Windows.Forms.Label();
            this.ChildsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DisabledChildsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeducNotExistRadioButton = new System.Windows.Forms.RadioButton();
            this.DeducExistRadioButton = new System.Windows.Forms.RadioButton();
            this.IsDisabledChildsCheckBox = new System.Windows.Forms.CheckBox();
            this.DeducsGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.BonuseTextBox = new System.Windows.Forms.TextBox();
            this.IsDaysPayRadioButton = new System.Windows.Forms.RadioButton();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.CertificateButton = new System.Windows.Forms.Button();
            this.SupplementsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegionalSuppleRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthSuppleRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledChildsNumericUpDown)).BeginInit();
            this.DeducsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsHoursPayRadioButton
            // 
            this.IsHoursPayRadioButton.AutoSize = true;
            this.IsHoursPayRadioButton.Location = new System.Drawing.Point(105, 12);
            this.IsHoursPayRadioButton.Name = "IsHoursPayRadioButton";
            this.IsHoursPayRadioButton.Size = new System.Drawing.Size(107, 17);
            this.IsHoursPayRadioButton.TabIndex = 0;
            this.IsHoursPayRadioButton.Text = "Часовая ставка";
            this.IsHoursPayRadioButton.UseVisualStyleBackColor = true;
            this.IsHoursPayRadioButton.CheckedChanged += new System.EventHandler(this.IsHoursPayRadioButton_CheckedChanged);
            // 
            // IsSalaryRadioButton
            // 
            this.IsSalaryRadioButton.AutoSize = true;
            this.IsSalaryRadioButton.Checked = true;
            this.IsSalaryRadioButton.Location = new System.Drawing.Point(16, 13);
            this.IsSalaryRadioButton.Name = "IsSalaryRadioButton";
            this.IsSalaryRadioButton.Size = new System.Drawing.Size(57, 17);
            this.IsSalaryRadioButton.TabIndex = 2;
            this.IsSalaryRadioButton.TabStop = true;
            this.IsSalaryRadioButton.Text = "Оклад";
            this.IsSalaryRadioButton.UseVisualStyleBackColor = true;
            this.IsSalaryRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ExistBonuseCheckBox
            // 
            this.ExistBonuseCheckBox.AutoSize = true;
            this.ExistBonuseCheckBox.Location = new System.Drawing.Point(357, 13);
            this.ExistBonuseCheckBox.Name = "ExistBonuseCheckBox";
            this.ExistBonuseCheckBox.Size = new System.Drawing.Size(66, 17);
            this.ExistBonuseCheckBox.TabIndex = 3;
            this.ExistBonuseCheckBox.Text = "Премия";
            this.ExistBonuseCheckBox.UseVisualStyleBackColor = true;
            this.ExistBonuseCheckBox.CheckedChanged += new System.EventHandler(this.ExistBonuseCheckBox_CheckedChanged);
            // 
            // WorkTimeTextBox
            // 
            this.WorkTimeTextBox.Location = new System.Drawing.Point(226, 50);
            this.WorkTimeTextBox.Name = "WorkTimeTextBox";
            this.WorkTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.WorkTimeTextBox.TabIndex = 4;
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Location = new System.Drawing.Point(13, 50);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(114, 13);
            this.WorkTimeLabel.TabIndex = 5;
            this.WorkTimeLabel.Text = "Кол-во рабочих дней:";
            // 
            // WorkedTimeTextBox
            // 
            this.WorkedTimeTextBox.Location = new System.Drawing.Point(226, 80);
            this.WorkedTimeTextBox.Name = "WorkedTimeTextBox";
            this.WorkedTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.WorkedTimeTextBox.TabIndex = 6;
            // 
            // WorkedTimeLabel
            // 
            this.WorkedTimeLabel.AutoSize = true;
            this.WorkedTimeLabel.Location = new System.Drawing.Point(12, 80);
            this.WorkedTimeLabel.Name = "WorkedTimeLabel";
            this.WorkedTimeLabel.Size = new System.Drawing.Size(145, 13);
            this.WorkedTimeLabel.TabIndex = 7;
            this.WorkedTimeLabel.Text = "Кол-во отработанных дней:";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(13, 108);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(42, 13);
            this.SalaryLabel.TabIndex = 8;
            this.SalaryLabel.Text = "Оклад:";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(226, 111);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTextBox.TabIndex = 9;
            // 
            // NumberOfChildsLabel
            // 
            this.NumberOfChildsLabel.AutoSize = true;
            this.NumberOfChildsLabel.Location = new System.Drawing.Point(11, 116);
            this.NumberOfChildsLabel.Name = "NumberOfChildsLabel";
            this.NumberOfChildsLabel.Size = new System.Drawing.Size(66, 13);
            this.NumberOfChildsLabel.TabIndex = 22;
            this.NumberOfChildsLabel.Text = "Количество";
            this.NumberOfChildsLabel.Visible = false;
            // 
            // AvailablilityDisabledChildsLabel
            // 
            this.AvailablilityDisabledChildsLabel.AutoSize = true;
            this.AvailablilityDisabledChildsLabel.Location = new System.Drawing.Point(8, 87);
            this.AvailablilityDisabledChildsLabel.Name = "AvailablilityDisabledChildsLabel";
            this.AvailablilityDisabledChildsLabel.Size = new System.Drawing.Size(139, 13);
            this.AvailablilityDisabledChildsLabel.TabIndex = 20;
            this.AvailablilityDisabledChildsLabel.Text = "Наличие детей-инвалидов";
            this.AvailablilityDisabledChildsLabel.Visible = false;
            // 
            // DeducOnChildrenLabel
            // 
            this.DeducOnChildrenLabel.AutoSize = true;
            this.DeducOnChildrenLabel.Location = new System.Drawing.Point(8, 53);
            this.DeducOnChildrenLabel.Name = "DeducOnChildrenLabel";
            this.DeducOnChildrenLabel.Size = new System.Drawing.Size(93, 13);
            this.DeducOnChildrenLabel.TabIndex = 17;
            this.DeducOnChildrenLabel.Text = "Вычеты на детей";
            this.DeducOnChildrenLabel.Visible = false;
            // 
            // DeducExistOrNotLabel
            // 
            this.DeducExistOrNotLabel.AutoSize = true;
            this.DeducExistOrNotLabel.Location = new System.Drawing.Point(8, 19);
            this.DeducExistOrNotLabel.Name = "DeducExistOrNotLabel";
            this.DeducExistOrNotLabel.Size = new System.Drawing.Size(95, 13);
            this.DeducExistOrNotLabel.TabIndex = 0;
            this.DeducExistOrNotLabel.Text = "Наличие вычетов";
            // 
            // SupplementsGroupBox
            // 
            this.SupplementsGroupBox.Controls.Add(this.SupplementedRadioButton);
            this.SupplementsGroupBox.Controls.Add(this.UnsapplementedRadioButton);
            this.SupplementsGroupBox.Controls.Add(this.RegionalSuppleRateNumericUpDown);
            this.SupplementsGroupBox.Controls.Add(this.NorthSuppleRateNumericUpDown);
            this.SupplementsGroupBox.Controls.Add(this.NorthSuppleLabel);
            this.SupplementsGroupBox.Controls.Add(this.SuppleExistOrNotLabel);
            this.SupplementsGroupBox.Controls.Add(this.RegionalSuppleLabel);
            this.SupplementsGroupBox.Location = new System.Drawing.Point(346, 50);
            this.SupplementsGroupBox.Name = "SupplementsGroupBox";
            this.SupplementsGroupBox.Size = new System.Drawing.Size(279, 150);
            this.SupplementsGroupBox.TabIndex = 25;
            this.SupplementsGroupBox.TabStop = false;
            this.SupplementsGroupBox.Text = "Надбавки";
            // 
            // SupplementedRadioButton
            // 
            this.SupplementedRadioButton.AutoSize = true;
            this.SupplementedRadioButton.Location = new System.Drawing.Point(159, 19);
            this.SupplementedRadioButton.Name = "SupplementedRadioButton";
            this.SupplementedRadioButton.Size = new System.Drawing.Size(40, 17);
            this.SupplementedRadioButton.TabIndex = 35;
            this.SupplementedRadioButton.TabStop = true;
            this.SupplementedRadioButton.Text = "Да";
            this.SupplementedRadioButton.UseVisualStyleBackColor = true;
            this.SupplementedRadioButton.CheckedChanged += new System.EventHandler(this.SupplementedRadioButton_CheckedChanged);
            // 
            // UnsapplementedRadioButton
            // 
            this.UnsapplementedRadioButton.AutoSize = true;
            this.UnsapplementedRadioButton.Checked = true;
            this.UnsapplementedRadioButton.Location = new System.Drawing.Point(219, 21);
            this.UnsapplementedRadioButton.Name = "UnsapplementedRadioButton";
            this.UnsapplementedRadioButton.Size = new System.Drawing.Size(44, 17);
            this.UnsapplementedRadioButton.TabIndex = 34;
            this.UnsapplementedRadioButton.TabStop = true;
            this.UnsapplementedRadioButton.Text = "Нет";
            this.UnsapplementedRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegionalSuppleRateNumericUpDown
            // 
            this.RegionalSuppleRateNumericUpDown.Location = new System.Drawing.Point(172, 113);
            this.RegionalSuppleRateNumericUpDown.Name = "RegionalSuppleRateNumericUpDown";
            this.RegionalSuppleRateNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.RegionalSuppleRateNumericUpDown.TabIndex = 33;
            this.RegionalSuppleRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RegionalSuppleRateNumericUpDown.Visible = false;
            // 
            // NorthSuppleRateNumericUpDown
            // 
            this.NorthSuppleRateNumericUpDown.DecimalPlaces = 2;
            this.NorthSuppleRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NorthSuppleRateNumericUpDown.Location = new System.Drawing.Point(172, 58);
            this.NorthSuppleRateNumericUpDown.Name = "NorthSuppleRateNumericUpDown";
            this.NorthSuppleRateNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.NorthSuppleRateNumericUpDown.TabIndex = 4;
            this.NorthSuppleRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NorthSuppleRateNumericUpDown.Visible = false;
            // 
            // NorthSuppleLabel
            // 
            this.NorthSuppleLabel.AutoSize = true;
            this.NorthSuppleLabel.Location = new System.Drawing.Point(6, 62);
            this.NorthSuppleLabel.Name = "NorthSuppleLabel";
            this.NorthSuppleLabel.Size = new System.Drawing.Size(107, 13);
            this.NorthSuppleLabel.TabIndex = 3;
            this.NorthSuppleLabel.Text = "Северная надбавка";
            this.NorthSuppleLabel.Visible = false;
            // 
            // SuppleExistOrNotLabel
            // 
            this.SuppleExistOrNotLabel.AutoSize = true;
            this.SuppleExistOrNotLabel.Location = new System.Drawing.Point(6, 23);
            this.SuppleExistOrNotLabel.Name = "SuppleExistOrNotLabel";
            this.SuppleExistOrNotLabel.Size = new System.Drawing.Size(57, 13);
            this.SuppleExistOrNotLabel.TabIndex = 0;
            this.SuppleExistOrNotLabel.Text = "Надбавки";
            // 
            // RegionalSuppleLabel
            // 
            this.RegionalSuppleLabel.AutoSize = true;
            this.RegionalSuppleLabel.Location = new System.Drawing.Point(6, 115);
            this.RegionalSuppleLabel.Name = "RegionalSuppleLabel";
            this.RegionalSuppleLabel.Size = new System.Drawing.Size(130, 13);
            this.RegionalSuppleLabel.TabIndex = 2;
            this.RegionalSuppleLabel.Text = "Районный коэффициент";
            this.RegionalSuppleLabel.Visible = false;
            // 
            // BonuseLabel
            // 
            this.BonuseLabel.AutoSize = true;
            this.BonuseLabel.Location = new System.Drawing.Point(12, 146);
            this.BonuseLabel.Name = "BonuseLabel";
            this.BonuseLabel.Size = new System.Drawing.Size(50, 13);
            this.BonuseLabel.TabIndex = 27;
            this.BonuseLabel.Text = "Премия:";
            this.BonuseLabel.Visible = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(30, 201);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(104, 37);
            this.CalculateButton.TabIndex = 28;
            this.CalculateButton.Text = "Расчет";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PayOnHandTextBox
            // 
            this.PayOnHandTextBox.Location = new System.Drawing.Point(154, 286);
            this.PayOnHandTextBox.Name = "PayOnHandTextBox";
            this.PayOnHandTextBox.ReadOnly = true;
            this.PayOnHandTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayOnHandTextBox.TabIndex = 29;
            // 
            // PayOnHandLabel
            // 
            this.PayOnHandLabel.AutoSize = true;
            this.PayOnHandLabel.Location = new System.Drawing.Point(27, 286);
            this.PayOnHandLabel.Name = "PayOnHandLabel";
            this.PayOnHandLabel.Size = new System.Drawing.Size(99, 13);
            this.PayOnHandLabel.TabIndex = 30;
            this.PayOnHandLabel.Text = "Зарплата на руки:";
            // 
            // ChildsNumericUpDown
            // 
            this.ChildsNumericUpDown.Location = new System.Drawing.Point(172, 53);
            this.ChildsNumericUpDown.Name = "ChildsNumericUpDown";
            this.ChildsNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.ChildsNumericUpDown.TabIndex = 23;
            this.ChildsNumericUpDown.Visible = false;
            // 
            // DisabledChildsNumericUpDown
            // 
            this.DisabledChildsNumericUpDown.Location = new System.Drawing.Point(172, 116);
            this.DisabledChildsNumericUpDown.Name = "DisabledChildsNumericUpDown";
            this.DisabledChildsNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.DisabledChildsNumericUpDown.TabIndex = 24;
            this.DisabledChildsNumericUpDown.Visible = false;
            // 
            // DeducNotExistRadioButton
            // 
            this.DeducNotExistRadioButton.AutoSize = true;
            this.DeducNotExistRadioButton.Checked = true;
            this.DeducNotExistRadioButton.Location = new System.Drawing.Point(219, 19);
            this.DeducNotExistRadioButton.Name = "DeducNotExistRadioButton";
            this.DeducNotExistRadioButton.Size = new System.Drawing.Size(44, 17);
            this.DeducNotExistRadioButton.TabIndex = 25;
            this.DeducNotExistRadioButton.TabStop = true;
            this.DeducNotExistRadioButton.Text = "Нет";
            this.DeducNotExistRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeducExistRadioButton
            // 
            this.DeducExistRadioButton.AutoSize = true;
            this.DeducExistRadioButton.Location = new System.Drawing.Point(159, 19);
            this.DeducExistRadioButton.Name = "DeducExistRadioButton";
            this.DeducExistRadioButton.Size = new System.Drawing.Size(40, 17);
            this.DeducExistRadioButton.TabIndex = 33;
            this.DeducExistRadioButton.TabStop = true;
            this.DeducExistRadioButton.Text = "Да";
            this.DeducExistRadioButton.UseVisualStyleBackColor = true;
            this.DeducExistRadioButton.CheckedChanged += new System.EventHandler(this.DeducExistRadioButton_CheckedChanged);
            // 
            // IsDisabledChildsCheckBox
            // 
            this.IsDisabledChildsCheckBox.AutoSize = true;
            this.IsDisabledChildsCheckBox.Location = new System.Drawing.Point(219, 87);
            this.IsDisabledChildsCheckBox.Name = "IsDisabledChildsCheckBox";
            this.IsDisabledChildsCheckBox.Size = new System.Drawing.Size(41, 17);
            this.IsDisabledChildsCheckBox.TabIndex = 34;
            this.IsDisabledChildsCheckBox.Text = "Да";
            this.IsDisabledChildsCheckBox.UseVisualStyleBackColor = true;
            this.IsDisabledChildsCheckBox.Visible = false;
            this.IsDisabledChildsCheckBox.CheckedChanged += new System.EventHandler(this.IsDisabledChildsCheckBox_CheckedChanged);
            // 
            // DeducsGroupBox
            // 
            this.DeducsGroupBox.Controls.Add(this.DeducNotExistRadioButton);
            this.DeducsGroupBox.Controls.Add(this.IsDisabledChildsCheckBox);
            this.DeducsGroupBox.Controls.Add(this.DeducExistRadioButton);
            this.DeducsGroupBox.Controls.Add(this.DeducExistOrNotLabel);
            this.DeducsGroupBox.Controls.Add(this.DisabledChildsNumericUpDown);
            this.DeducsGroupBox.Controls.Add(this.ChildsNumericUpDown);
            this.DeducsGroupBox.Controls.Add(this.NumberOfChildsLabel);
            this.DeducsGroupBox.Controls.Add(this.AvailablilityDisabledChildsLabel);
            this.DeducsGroupBox.Controls.Add(this.DeducOnChildrenLabel);
            this.DeducsGroupBox.Location = new System.Drawing.Point(346, 206);
            this.DeducsGroupBox.Name = "DeducsGroupBox";
            this.DeducsGroupBox.Size = new System.Drawing.Size(279, 152);
            this.DeducsGroupBox.TabIndex = 35;
            this.DeducsGroupBox.TabStop = false;
            this.DeducsGroupBox.Text = "Вычеты";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(154, 201);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(100, 37);
            this.PrintButton.TabIndex = 36;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BonuseTextBox
            // 
            this.BonuseTextBox.Location = new System.Drawing.Point(226, 146);
            this.BonuseTextBox.Name = "BonuseTextBox";
            this.BonuseTextBox.Size = new System.Drawing.Size(100, 20);
            this.BonuseTextBox.TabIndex = 26;
            this.BonuseTextBox.Visible = false;
            // 
            // IsDaysPayRadioButton
            // 
            this.IsDaysPayRadioButton.AutoSize = true;
            this.IsDaysPayRadioButton.Location = new System.Drawing.Point(226, 12);
            this.IsDaysPayRadioButton.Name = "IsDaysPayRadioButton";
            this.IsDaysPayRadioButton.Size = new System.Drawing.Size(108, 17);
            this.IsDaysPayRadioButton.TabIndex = 37;
            this.IsDaysPayRadioButton.TabStop = true;
            this.IsDaysPayRadioButton.Text = "Дневная ставка";
            this.IsDaysPayRadioButton.UseVisualStyleBackColor = true;
            this.IsDaysPayRadioButton.CheckedChanged += new System.EventHandler(this.IsDaysPayRadioButton_CheckedChanged);
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Location = new System.Drawing.Point(23, 332);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(104, 37);
            this.ExportToExcelButton.TabIndex = 38;
            this.ExportToExcelButton.Text = "В Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = true;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // CertificateButton
            // 
            this.CertificateButton.Location = new System.Drawing.Point(525, 7);
            this.CertificateButton.Name = "CertificateButton";
            this.CertificateButton.Size = new System.Drawing.Size(100, 37);
            this.CertificateButton.TabIndex = 39;
            this.CertificateButton.Text = "Справка";
            this.CertificateButton.UseVisualStyleBackColor = true;
            this.CertificateButton.Click += new System.EventHandler(this.CertificateButton_Click);
            // 
            // ChargedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(654, 381);
            this.Controls.Add(this.CertificateButton);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.IsDaysPayRadioButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DeducsGroupBox);
            this.Controls.Add(this.PayOnHandLabel);
            this.Controls.Add(this.PayOnHandTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BonuseLabel);
            this.Controls.Add(this.BonuseTextBox);
            this.Controls.Add(this.SupplementsGroupBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.WorkedTimeLabel);
            this.Controls.Add(this.WorkedTimeTextBox);
            this.Controls.Add(this.WorkTimeLabel);
            this.Controls.Add(this.WorkTimeTextBox);
            this.Controls.Add(this.ExistBonuseCheckBox);
            this.Controls.Add(this.IsSalaryRadioButton);
            this.Controls.Add(this.IsHoursPayRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 420);
            this.MinimumSize = new System.Drawing.Size(670, 420);
            this.Name = "ChargedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Повременная оплата труда";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SupplementsGroupBox.ResumeLayout(false);
            this.SupplementsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegionalSuppleRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthSuppleRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledChildsNumericUpDown)).EndInit();
            this.DeducsGroupBox.ResumeLayout(false);
            this.DeducsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.Label WorkedTimeLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label NumberOfChildsLabel;
        private System.Windows.Forms.Label AvailablilityDisabledChildsLabel;
        private System.Windows.Forms.Label DeducOnChildrenLabel;
        private System.Windows.Forms.Label DeducExistOrNotLabel;
        private System.Windows.Forms.GroupBox SupplementsGroupBox;
        private System.Windows.Forms.Label NorthSuppleLabel;
        private System.Windows.Forms.Label SuppleExistOrNotLabel;
        private System.Windows.Forms.Label RegionalSuppleLabel;
        private System.Windows.Forms.Label BonuseLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label PayOnHandLabel;
        private System.Windows.Forms.RadioButton DeducNotExistRadioButton;
        private System.Windows.Forms.RadioButton UnsapplementedRadioButton;
        private System.Windows.Forms.GroupBox DeducsGroupBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExportToExcelButton;
        public System.Windows.Forms.NumericUpDown DisabledChildsNumericUpDown;
        public System.Windows.Forms.NumericUpDown ChildsNumericUpDown;
        public System.Windows.Forms.NumericUpDown RegionalSuppleRateNumericUpDown;
        public System.Windows.Forms.NumericUpDown NorthSuppleRateNumericUpDown;
        public System.Windows.Forms.RadioButton IsHoursPayRadioButton;
        public System.Windows.Forms.RadioButton IsSalaryRadioButton;
        public System.Windows.Forms.CheckBox ExistBonuseCheckBox;
        public System.Windows.Forms.TextBox WorkTimeTextBox;
        public System.Windows.Forms.TextBox WorkedTimeTextBox;
        public System.Windows.Forms.TextBox SalaryTextBox;
        public System.Windows.Forms.TextBox BonuseTextBox;
        public System.Windows.Forms.RadioButton IsDaysPayRadioButton;
        public System.Windows.Forms.CheckBox IsDisabledChildsCheckBox;
        public System.Windows.Forms.RadioButton DeducExistRadioButton;
        public System.Windows.Forms.RadioButton SupplementedRadioButton;
        private System.Windows.Forms.Button CertificateButton;
        private System.Windows.Forms.TextBox PayOnHandTextBox;
    }
}