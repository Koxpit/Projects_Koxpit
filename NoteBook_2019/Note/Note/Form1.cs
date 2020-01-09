﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class NoteBookForm : Form
    {
        CartForm f3;

        Color dark = Color.Black;
        Color whited = Color.WhiteSmoke;
        Color light = Color.AliceBlue;

        private string printData = "";

        private List<Record> ListRecords { get; set; }
        public List<Record> List
        {
            get { return ListRecords; }
            set { ListRecords=value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private List<Record> ListBasket { get; set; }
        public List<Record> Basket
        {
            get { return ListBasket; }
            set { ListBasket=value; }
        }

        public NoteBookForm()
        {
            InitializeComponent();

            ListBasket=new List<Record>();
            f3=new CartForm();
        }

        private void NoteBookForm_Load(object sender, EventArgs e)
        {
            LoadData();

            LoginUserDataLabel.BackColor=Color.FromArgb(245, 245, 245);
            toolTip.SetToolTip(UpdateRecordButton, "Load recovered recordings.");
            toolTip.SetToolTip(SearchRecordButton, "*all parameters.");
        }

        // Загрузка записей пользователя
        private void LoadData()
        {
            try
            {
                using (FileStream fs = new FileStream(ID.ToString() + ".dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    if (fs.Length == 0)
                        ListRecords = new List<Record>();
                    else
                        ListRecords = (List<Record>)formatter.Deserialize(fs);

                    OutputListRecordsToDataGrid();

                    fs.Close();
                }

            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void OutputListRecordsToDataGrid()
        {
            try
            {
                dataGridView.DataSource=ListRecords.ToList();
            }
            catch { MessageBox.Show("Error adding/updating table!"); }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        // Добавление новой записи
        private void AddRecord()
        {
            ListRecords.Add(new Record
            {
                Name = FirstNameTextBox.Text,
                Surname = LastNameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                Birthday = BirthdayDateTimePicker.Value.ToLongDateString(),
                PhoneNumber = NumberTelephoneTextBox.Text
            });

            OutputListRecordsToDataGrid();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow!=null)
            {
                if (dataGridView.SelectedRows.Count==0)
                    MessageBox.Show("No records selected!");
                else
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        ListBasket.Add(ListRecords.ElementAt(row.Index));
                        ListRecords.RemoveAt(row.Index);
                    }

                dataGridView.DataSource=ListRecords.ToList();
            }
            else { MessageBox.Show("Book is empty!"); }
        }

        private void SearchRecordButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=SearchRecords().ToList();
        }

        // Поиск записи по всем параметрам
        public List<Record> SearchRecords()
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Name==FirstNameTextBox.Text||
                    rec.Surname==LastNameTextBox.Text||
                    rec.Patronymic==PatronymicTextBox.Text||
                    rec.Birthday==BirthdayDateTimePicker.Value.ToLongDateString()||
                    rec.PhoneNumber==NumberTelephoneTextBox.Text)
                    list.Add(rec);

            return list;
        }

        private void ShowAllRecordsButton_Click(object sender, EventArgs e)
        {
            OutputListRecordsToDataGrid();
        }

        private void ChangeRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListRecords.RemoveAt(dataGridView.CurrentRow.Index);
                AddRecord();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (f3.RecoverList!=null)
                {
                    ListRecords.AddRange(f3.RecoverList);
                    f3.RecoverList.Clear();
                }

                OutputListRecordsToDataGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=SearchFName(FirstNameTextBox.Text).ToList();
        }

        // Поиск по имени
        public List<Record> SearchFName(string FName)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Name==FName)
                    list.Add(rec);

            return list;
        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=SearchLName(LastNameTextBox.Text).ToList();
        }

        // Поиск по фамилии
        public List<Record> SearchLName(string LName)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Surname==LName)
                    list.Add(rec);

            return list;
        }

        private void patronymicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=SearchPatronymic(PatronymicTextBox.Text);
        }

        // Поиск по отчеству
        public List<Record> SearchPatronymic(string Patronymic)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Patronymic==Patronymic)
                    list.Add(rec);

            return list;
        }

        private void birthdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = BirthdayDateTimePicker.Value.ToLongDateString();
            dataGridView.DataSource=SearchBirthday(data).ToList();
        }

        // Поиск по дате рождения
        public List<Record> SearchBirthday(string Birthday)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Birthday==Birthday)
                    list.Add(rec);

            return list;
        }

        private void numberTelephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=SearchPhoneNumber(NumberTelephoneTextBox.Text).ToList();
        }

        // Поиск по номеру телефона
        public List<Record> SearchPhoneNumber(string PhoneNumber)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.PhoneNumber==PhoneNumber)
                    list.Add(rec);

            return list;
        }

        // Обработка событий сортировки записей по параметрам

        private void firstNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=ListRecords.OrderBy(x => x.Name).ToList();
        }

        private void lastNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=ListRecords.OrderBy(x => x.Surname).ToList();
        }

        private void patronymicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=ListRecords.OrderBy(x => x.Patronymic).ToList();
        }

        private void birthdayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=ListRecords.OrderBy(x => x.Birthday).ToList();
        }

        private void phoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource=ListRecords.OrderBy(x => x.PhoneNumber).ToList();
        }
        // Конец обработки событий сортировки записей по параметрам

        // Режим редактирования записей по нажатии на ячейку
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FirstNameTextBox.Text=dataGridView[0, e.RowIndex].Value.ToString();
                LastNameTextBox.Text=dataGridView[1, e.RowIndex].Value.ToString();
                PatronymicTextBox.Text=dataGridView[2, e.RowIndex].Value.ToString();
                NumberTelephoneTextBox.Text=dataGridView[4, e.RowIndex].Value.ToString();
                BirthdayDateTimePicker.Value=DateTime.Parse(dataGridView[3, e.RowIndex].Value.ToString());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Сохранение данных из списка в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm f2 = new LoginForm();
                int id = f2.id;

                using (FileStream fs = new FileStream(id.ToString() + ".dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, ListRecords);

                    MessageBox.Show("Save complete!");
                    fs.Close();
                }
            }
            catch { return; }
        }

        // Сохранение записей в таблицу Excel
        public void SaveRecordsToExcel()
        {
            SaveRecords.SaveToExcel(dataGridView);
        }

        private async void exelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => SaveRecordsToExcel());
        }

        // Печать данных
        private void PrintRecordsToTextFile()
        {
            try
            {
                if (dataGridView.RowCount != 0)
                {
                    CreatePrintString();

                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += PrintPageHandler;

                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDoc;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                        printDialog.Document.Print();
                }
                else
                    MessageBox.Show("Table is empty!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CreatePrintString()
        {
            printData = "";
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    printData += dataGridView[j, i].Value.ToString();

                printData += "\n";
            }

            return printData;
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printData, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => PrintRecordsToTextFile());
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlySimbols(e);
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlySimbols(e);
        }

        private void PatronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlySimbols(e);
        }

        // Доступ для ввода в текстовое поле только букв.
        public void EnterOnlySimbols(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
                e.Handled=true;
        }

        private void NumberTelephoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyDigits(e);
        }

        // Доступ для ввода в текстовое поле только цифр.
        public void EnterOnlyDigits(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&&number!=8)
                e.Handled=true;
        }

        // Темная тема
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor=dark;
            ForeColor=whited;

            AddRecordButton.ForeColor=dark;
            DeleteRecordButton.ForeColor=dark;
            SearchRecordButton.ForeColor=dark;
            ShowAllRecordsButton.ForeColor=dark;
            UpdateRecordButton.ForeColor=dark;

            menuStrip.BackColor=whited;

            dataGridView.ForeColor=dark;
            dataGridView.BackgroundColor=dark;

            LoginUserDataLabel.BackColor=whited;
            LoginUserDataLabel.ForeColor=dark;
        }

        // Светлая тема
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor=light;
            ForeColor=dark;

            dataGridView.BackgroundColor=Color.AntiqueWhite;
            menuStrip.BackColor=Color.White;
            LoginUserDataLabel.BackColor=Color.White;
        }

        // Тема по умолчанию
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor=Color.FromArgb(240, 240, 240);
            ForeColor=Color.Black;

            menuStrip.BackColor=Color.FromArgb(245, 245, 245);
            LoginUserDataLabel.BackColor=Color.FromArgb(245, 245, 245);
            dataGridView.BackgroundColor=Color.FromArgb(171, 171, 171);
        }

        // Открытие корзины
        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3=new CartForm();
            f3.Owner=this;
            f3.Cart=ListBasket;
            f3.dataGridView.DataSource=ListBasket.ToList();
            f3.ShowDialog();
        }

        // Открытие формы календаря
        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarForm f4 = new CalendarForm();
            f4.ShowDialog();
        }

        // Открытие формы "О программе"
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        // Закрытие приложения
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    [Serializable] // - для работы с файлами
    public class Record
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
    }
}
