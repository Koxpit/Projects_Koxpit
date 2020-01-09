namespace Note
{
    partial class NoteBookForm
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
            if (disposing&&(components!=null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.NumberTelephoneTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.NumberTelephoneLabel = new System.Windows.Forms.Label();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronymicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberTelephoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patronymicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchRecordButton = new System.Windows.Forms.Button();
            this.ShowAllRecordsButton = new System.Windows.Forms.Button();
            this.LoginUserDataLabel = new System.Windows.Forms.Label();
            this.UpdateRecordButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChangeRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 183);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(543, 208);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(111, 34);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTextBox_KeyPress);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(111, 60);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTextBox_KeyPress);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(111, 86);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatronymicTextBox.TabIndex = 3;
            this.PatronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicTextBox_KeyPress);
            // 
            // NumberTelephoneTextBox
            // 
            this.NumberTelephoneTextBox.Location = new System.Drawing.Point(111, 138);
            this.NumberTelephoneTextBox.Name = "NumberTelephoneTextBox";
            this.NumberTelephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTelephoneTextBox.TabIndex = 5;
            this.NumberTelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTelephoneTextBox_KeyPress);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 60);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(14, 86);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(62, 13);
            this.PatronymicLabel.TabIndex = 8;
            this.PatronymicLabel.Text = "Patronymic:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(14, 112);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(48, 13);
            this.BirthdayLabel.TabIndex = 9;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // NumberTelephoneLabel
            // 
            this.NumberTelephoneLabel.AutoSize = true;
            this.NumberTelephoneLabel.Location = new System.Drawing.Point(12, 141);
            this.NumberTelephoneLabel.Name = "NumberTelephoneLabel";
            this.NumberTelephoneLabel.Size = new System.Drawing.Size(97, 13);
            this.NumberTelephoneLabel.TabIndex = 10;
            this.NumberTelephoneLabel.Text = "Number telephone:";
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(317, 34);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(105, 33);
            this.AddRecordButton.TabIndex = 11;
            this.AddRecordButton.Text = "Add record";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(427, 34);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(105, 33);
            this.DeleteRecordButton.TabIndex = 12;
            this.DeleteRecordButton.Text = "Delete record";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(111, 112);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDateTimePicker.TabIndex = 13;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(544, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.basketToolStripMenuItem,
            this.topicToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Menu";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Save";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.patronymicToolStripMenuItem,
            this.birthdayToolStripMenuItem,
            this.numberTelephoneToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // firstNameToolStripMenuItem
            // 
            this.firstNameToolStripMenuItem.Name = "firstNameToolStripMenuItem";
            this.firstNameToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.firstNameToolStripMenuItem.Text = "First Name";
            this.firstNameToolStripMenuItem.Click += new System.EventHandler(this.firstNameToolStripMenuItem_Click);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lastNameToolStripMenuItem.Text = "Last Name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.lastNameToolStripMenuItem_Click);
            // 
            // patronymicToolStripMenuItem
            // 
            this.patronymicToolStripMenuItem.Name = "patronymicToolStripMenuItem";
            this.patronymicToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.patronymicToolStripMenuItem.Text = "Patronymic";
            this.patronymicToolStripMenuItem.Click += new System.EventHandler(this.patronymicToolStripMenuItem_Click);
            // 
            // birthdayToolStripMenuItem
            // 
            this.birthdayToolStripMenuItem.Name = "birthdayToolStripMenuItem";
            this.birthdayToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.birthdayToolStripMenuItem.Text = "Birthday";
            this.birthdayToolStripMenuItem.Click += new System.EventHandler(this.birthdayToolStripMenuItem_Click);
            // 
            // numberTelephoneToolStripMenuItem
            // 
            this.numberTelephoneToolStripMenuItem.Name = "numberTelephoneToolStripMenuItem";
            this.numberTelephoneToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.numberTelephoneToolStripMenuItem.Text = "Number Telephone";
            this.numberTelephoneToolStripMenuItem.Click += new System.EventHandler(this.numberTelephoneToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripMenuItem1,
            this.lastNameToolStripMenuItem1,
            this.patronymicToolStripMenuItem1,
            this.birthdayToolStripMenuItem1,
            this.phoneNumberToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // firstNameToolStripMenuItem1
            // 
            this.firstNameToolStripMenuItem1.Name = "firstNameToolStripMenuItem1";
            this.firstNameToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.firstNameToolStripMenuItem1.Text = "First Name";
            this.firstNameToolStripMenuItem1.Click += new System.EventHandler(this.firstNameToolStripMenuItem1_Click);
            // 
            // lastNameToolStripMenuItem1
            // 
            this.lastNameToolStripMenuItem1.Name = "lastNameToolStripMenuItem1";
            this.lastNameToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.lastNameToolStripMenuItem1.Text = "Last Name";
            this.lastNameToolStripMenuItem1.Click += new System.EventHandler(this.lastNameToolStripMenuItem1_Click);
            // 
            // patronymicToolStripMenuItem1
            // 
            this.patronymicToolStripMenuItem1.Name = "patronymicToolStripMenuItem1";
            this.patronymicToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.patronymicToolStripMenuItem1.Text = "Patronymic";
            this.patronymicToolStripMenuItem1.Click += new System.EventHandler(this.patronymicToolStripMenuItem1_Click);
            // 
            // birthdayToolStripMenuItem1
            // 
            this.birthdayToolStripMenuItem1.Name = "birthdayToolStripMenuItem1";
            this.birthdayToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.birthdayToolStripMenuItem1.Text = "Birthday";
            this.birthdayToolStripMenuItem1.Click += new System.EventHandler(this.birthdayToolStripMenuItem1_Click);
            // 
            // phoneNumberToolStripMenuItem
            // 
            this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
            this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.phoneNumberToolStripMenuItem.Text = "Phone Number";
            this.phoneNumberToolStripMenuItem.Click += new System.EventHandler(this.phoneNumberToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // basketToolStripMenuItem
            // 
            this.basketToolStripMenuItem.Name = "basketToolStripMenuItem";
            this.basketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.basketToolStripMenuItem.Text = "Cart";
            this.basketToolStripMenuItem.Click += new System.EventHandler(this.basketToolStripMenuItem_Click);
            // 
            // topicToolStripMenuItem
            // 
            this.topicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.topicToolStripMenuItem.Name = "topicToolStripMenuItem";
            this.topicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.topicToolStripMenuItem.Text = "Topic";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLFileToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // xMLFileToolStripMenuItem
            // 
            this.xMLFileToolStripMenuItem.Name = "xMLFileToolStripMenuItem";
            this.xMLFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLFileToolStripMenuItem.Text = "Excel file";
            this.xMLFileToolStripMenuItem.Click += new System.EventHandler(this.exelFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // SearchRecordButton
            // 
            this.SearchRecordButton.Location = new System.Drawing.Point(316, 86);
            this.SearchRecordButton.Name = "SearchRecordButton";
            this.SearchRecordButton.Size = new System.Drawing.Size(105, 32);
            this.SearchRecordButton.TabIndex = 15;
            this.SearchRecordButton.Text = "Search";
            this.SearchRecordButton.UseVisualStyleBackColor = true;
            this.SearchRecordButton.Click += new System.EventHandler(this.SearchRecordButton_Click);
            // 
            // ShowAllRecordsButton
            // 
            this.ShowAllRecordsButton.Location = new System.Drawing.Point(427, 86);
            this.ShowAllRecordsButton.Name = "ShowAllRecordsButton";
            this.ShowAllRecordsButton.Size = new System.Drawing.Size(105, 32);
            this.ShowAllRecordsButton.TabIndex = 16;
            this.ShowAllRecordsButton.Text = "Show all records";
            this.ShowAllRecordsButton.UseVisualStyleBackColor = true;
            this.ShowAllRecordsButton.Click += new System.EventHandler(this.ShowAllRecordsButton_Click);
            // 
            // LoginUserDataLabel
            // 
            this.LoginUserDataLabel.AutoSize = true;
            this.LoginUserDataLabel.Location = new System.Drawing.Point(462, 0);
            this.LoginUserDataLabel.Name = "LoginUserDataLabel";
            this.LoginUserDataLabel.Size = new System.Drawing.Size(49, 13);
            this.LoginUserDataLabel.TabIndex = 17;
            this.LoginUserDataLabel.Text = "Login/ID";
            // 
            // UpdateRecordButton
            // 
            this.UpdateRecordButton.Location = new System.Drawing.Point(427, 138);
            this.UpdateRecordButton.Name = "UpdateRecordButton";
            this.UpdateRecordButton.Size = new System.Drawing.Size(105, 32);
            this.UpdateRecordButton.TabIndex = 18;
            this.UpdateRecordButton.Text = "Update";
            this.UpdateRecordButton.UseVisualStyleBackColor = true;
            this.UpdateRecordButton.Click += new System.EventHandler(this.UpdateRecordButton_Click);
            // 
            // ChangeRecordButton
            // 
            this.ChangeRecordButton.Location = new System.Drawing.Point(317, 138);
            this.ChangeRecordButton.Name = "ChangeRecordButton";
            this.ChangeRecordButton.Size = new System.Drawing.Size(104, 32);
            this.ChangeRecordButton.TabIndex = 19;
            this.ChangeRecordButton.Text = "Change";
            this.ChangeRecordButton.UseVisualStyleBackColor = true;
            this.ChangeRecordButton.Click += new System.EventHandler(this.ChangeRecordButton_Click);
            // 
            // NoteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 391);
            this.Controls.Add(this.ChangeRecordButton);
            this.Controls.Add(this.UpdateRecordButton);
            this.Controls.Add(this.LoginUserDataLabel);
            this.Controls.Add(this.ShowAllRecordsButton);
            this.Controls.Add(this.SearchRecordButton);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.NumberTelephoneLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.NumberTelephoneTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(560, 430);
            this.MinimumSize = new System.Drawing.Size(560, 430);
            this.Name = "NoteBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook";
            this.Load += new System.EventHandler(this.NoteBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NumberTelephoneTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label NumberTelephoneLabel;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button SearchRecordButton;
        private System.Windows.Forms.Button ShowAllRecordsButton;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronymicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberTelephoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patronymicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem birthdayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicToolStripMenuItem;
        private System.Windows.Forms.Button UpdateRecordButton;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        protected internal System.Windows.Forms.Label LoginUserDataLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ChangeRecordButton;
    }
}

