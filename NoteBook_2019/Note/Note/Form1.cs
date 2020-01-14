using System;
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
        private List<Record> ListBasket { get; set; }
        private int id;

        public List<Record> Basket
        {
            get { return ListBasket; }
            set { ListBasket = value; }
        }
        public List<Record> List
        {
            get { return ListRecords; }
            set { ListRecords = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public NoteBookForm()
        {
            InitializeComponent();

            ListBasket = new List<Record>();
            f3 = new CartForm();
        }

        private void NoteBookForm_Load(object sender, EventArgs e)
        {
            LoadData();
            
            LoginUserDataLabel.BackColor = Color.FromArgb(245, 245, 245);
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

                    if (FileIsEmpty(fs))
                        ListRecords = new List<Record>();
                    else
                        ListRecords = (List<Record>)formatter.Deserialize(fs);

                    OutputListRecordsToDataGrid();

                    fs.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool FileIsEmpty(FileStream fs)
        {
            return fs.Length == 0;
        }

        public void OutputListRecordsToDataGrid()
        {
            try
            {
                dataGridView.DataSource = ListRecords.ToList();
            }
            catch {
                MessageBox.Show("Error adding/updating table!");
            }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void AddRecord()
        {
            Record newRecord = CreateNewRecord();
            ListRecords.Add(newRecord);

            OutputListRecordsToDataGrid();
        }

        private Record CreateNewRecord()
        {
            return new Record
            {
                Name = FirstNameTextBox.Text,
                Surname = LastNameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                Birthday = BirthdayDateTimePicker.Value.ToLongDateString(),
                PhoneNumber = NumberTelephoneTextBox.Text
            };
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (dataGridView.SelectedRows.Count == 0)
                    MessageBox.Show("No records selected!");
                else
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        ListBasket.Add(ListRecords.ElementAt(row.Index));
                        ListRecords.RemoveAt(row.Index);
                    }

                dataGridView.DataSource = ListRecords.ToList();
            }
            else { MessageBox.Show("Book is empty!"); }
        }

        private void SearchRecordButton_Click(object sender, EventArgs e)
        {
            Record searchRecord = CreateNewRecord();
            dataGridView.DataSource = SearchRecords.
                SearchRecord(searchRecord, ListRecords);
        }

        private void ShowAllRecordsButton_Click(object sender, EventArgs e)
        {
            OutputListRecordsToDataGrid();
        }

        // Удаляет выделенную запись и вставляет новую
        private void ChangeRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListRecords.RemoveAt(dataGridView.CurrentRow.Index);
                AddRecord();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // Выводит в таблицу восстановленные записи
        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (f3.RecoverList != null)
                {
                    ListRecords.AddRange(f3.RecoverList);
                    f3.RecoverList.Clear();
                }

                OutputListRecordsToDataGrid();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // Поиск записи по имени
        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = SearchRecords
                .SearchFName(FirstNameTextBox.Text, ListRecords);
        }

        // Поиск записи по фамилии
        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = SearchRecords
                .SearchLName(LastNameTextBox.Text, ListRecords);
        }

        // Поиск записи по отчеству
        private void patronymicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = SearchRecords
                .SearchPatronymic(PatronymicTextBox.Text, ListRecords);
        }

        // Поиск записи по дате рождения
        private void birthdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = BirthdayDateTimePicker.Value.ToLongDateString();
            dataGridView.DataSource = SearchRecords
                .SearchBirthday(data, ListRecords);
        }

        // Поиск записи по номеру телефона
        private void numberTelephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = SearchRecords
                .SearchPhoneNumber(NumberTelephoneTextBox.Text, ListRecords);
        }

        // Обработка событий сортировки записей по параметрам

        private void firstNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ListRecords.OrderBy(x => x.Name).ToList();
        }

        private void lastNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ListRecords.OrderBy(x => x.Surname).ToList();
        }

        private void patronymicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ListRecords.OrderBy(x => x.Patronymic).ToList();
        }

        private void birthdayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ListRecords.OrderBy(x => x.Birthday).ToList();
        }

        private void phoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ListRecords.OrderBy(x => x.PhoneNumber).ToList();
        }
        // Конец обработки событий сортировки записей по параметрам

        // Режим редактирования записей по нажатии на ячейку
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FirstNameTextBox.Text = dataGridView[0, e.RowIndex]
                    .Value.ToString();
                LastNameTextBox.Text = dataGridView[1, e.RowIndex]
                    .Value.ToString();
                PatronymicTextBox.Text = dataGridView[2, e.RowIndex]
                    .Value.ToString();
                NumberTelephoneTextBox.Text = dataGridView[4, e.RowIndex]
                    .Value.ToString();
                BirthdayDateTimePicker.Value = DateTime.Parse(dataGridView[3, e.RowIndex]
                    .Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Сохранение данных из списка в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveRecords.SaveToFile(ListRecords);
        }

        // Сохранение записей в таблицу Excel
        private async void exelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => SaveRecords.SaveToExcel(dataGridView));
        }

        // Печать данных
        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => PrintRecordsToTextFile());
        }

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
            if ( (ch<'А'||ch>'я') && (ch<'A'||ch>'z') && ch!='\b' )
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
            if ( !Char.IsDigit(number) && number!=8 )
                e.Handled=true;
        }

        // Темная тема
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = dark;
            ForeColor = whited;

            AddRecordButton.ForeColor = dark;
            DeleteRecordButton.ForeColor = dark;
            SearchRecordButton.ForeColor = dark;
            ShowAllRecordsButton.ForeColor = dark;
            UpdateRecordButton.ForeColor = dark;

            menuStrip.BackColor = whited;

            dataGridView.ForeColor = dark;
            dataGridView.BackgroundColor = dark;

            LoginUserDataLabel.BackColor = whited;
            LoginUserDataLabel.ForeColor = dark;
        }

        // Светлая тема
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = light;
            ForeColor = dark;

            dataGridView.BackgroundColor = Color.AntiqueWhite;
            menuStrip.BackColor = Color.White;
            LoginUserDataLabel.BackColor = Color.White;
        }

        // Тема по умолчанию
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(240, 240, 240);
            ForeColor = Color.Black;

            menuStrip.BackColor = Color.FromArgb(245, 245, 245);
            LoginUserDataLabel.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView.BackgroundColor = Color.FromArgb(171, 171, 171);
        }

        // Открытие корзины
        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new CartForm();
            f3.Owner = this;
            f3.Cart = ListBasket;
            f3.dataGridView.DataSource = ListBasket;
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
            about.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    [Serializable]
    public class Record
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
    }
}
