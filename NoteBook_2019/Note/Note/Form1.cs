using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        Form3 f3;

        
        Color dark = Color.Black;
        Color whited = Color.WhiteSmoke;
        Color light = Color.AliceBlue;

        private List<Record> list;
        public List<Record> List
        {
            get { return list; }
            set { list=value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private List<Record> basket;
        public List<Record> Basket
        {
            get { return basket; }
            set { basket=value; }
        }

        private string print = "";

        public Form1()
        {
            InitializeComponent();

            basket=new List<Record>();
            f3=new Form3();
        }

        // Загрузка записей пользователя
        private void LoadData()
        {
            try
            {
                FileStream fs = new FileStream(ID.ToString()+".dat", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                if (fs.Length==0)
                    list=new List<Record>();
                else
                    list=(List<Record>)formatter.Deserialize(fs);
                dataGridView1.DataSource=list.ToList();

                fs.Close();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        // Подсказки
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            label6.BackColor=Color.FromArgb(245, 245, 245);
            toolTip1.SetToolTip(button5, "Load recovered recordings.");
            toolTip1.SetToolTip(button3, "*all parameters.");
        }


        // Сохранение данных из таблицы в Excel
        public void SaveToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

                ExcelWorkBook=ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

                ExcelWorkSheet=(Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i<dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j<dataGridView1.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i+1, j+1]=dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                ExcelApp.Visible=true;
                ExcelApp.UserControl=true;
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Вывод данных из списка в таблицу
        public void Output()
        {
            try
            {
                dataGridView1.DataSource=list.ToList();
            } catch { MessageBox.Show("Error adding/updating table!"); }
        }

        // Поиск по имени
        public List<Record> SearchFName(string FName)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Name==FName)
                    ret.Add(rec);

            return ret;
        }

        // Поиск по фамилии
        public List<Record> SearchLName(string LName)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Surname==LName)
                    ret.Add(rec);

            return ret;
        }

        // Поиск по отчеству
        public List<Record> SearchPatronymic(string Patronymic)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Patronymic==Patronymic)
                    ret.Add(rec);

            return ret;
        }

        // Поиск по дате рождения
        public List<Record> SearchBirthday(string Birthday)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Birthday==Birthday)
                    ret.Add(rec);

            return ret;
        }

        // Поиск по номеру телефона
        public List<Record> SearchPhoneNumber(string PhoneNumber)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.PhoneNumber==PhoneNumber)
                    ret.Add(rec);

            return ret;
        }

        // Поиск по всем параметрам
        public List<Record> SearchRecords(string Name, string Surname, string Patronymic, string Birthday, string PhoneNumber)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Name==Name||rec.Surname==Surname||rec.Patronymic==Patronymic||rec.Birthday==Birthday||rec.PhoneNumber==PhoneNumber)
                    ret.Add(rec);

            return ret;
        }

        // Добавление новой записи
        public void AddRecord(string Name, string Surname, string Patronymic, string Birthday, string PhoneNumber)
        {
            list.Add(new Record(Name, Surname, Patronymic, Birthday, PhoneNumber));
        }

        // Обработка кнопки добавления новой записи
        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToLongDateString();
            AddRecord(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text);
            Output();
        }

        // Обработка кнопки удаления выбранных записей и загрузка их в корзину
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                if (dataGridView1.SelectedRows.Count==0)
                {
                    MessageBox.Show("No records selected!");
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        basket.Add(list.ElementAt(row.Index));
                        list.RemoveAt(row.Index);
                    }
                }

                dataGridView1.DataSource=list.ToList();
            } else { MessageBox.Show("Book is empty!"); }
        }

        // Сохранение данных из списка в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2();
                int id = f2.id;
                FileStream fs = new FileStream(id.ToString()+".dat", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, list);
                fs.Close();
                MessageBox.Show("Save complete!");
            }
            catch { return; }
        }

        // Обработка кнопки поиска записей по всем параметрам
        private void button3_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToLongDateString();
            dataGridView1.DataSource=SearchRecords(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text).ToList();
        }

        // Обработка кнопки вывода всех записей в таблицу
        private void button4_Click(object sender, EventArgs e)
        {
            Output();
        }

        // Обработка кнопок поиска записей по параметрам

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchFName(textBox1.Text).ToList();
        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchLName(textBox2.Text).ToList();
        }

        private void patronymicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchPatronymic(textBox3.Text);
        }

        private void birthdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToLongDateString();
            dataGridView1.DataSource=SearchBirthday(data).ToList();
        }

        private void numberTelephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchPhoneNumber(textBox5.Text).ToList();
        }
        // Конец обработок кнопок поиска по параметрам

            // Обработка кнопок сортировки записей по параметрам
        private void firstNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=list.OrderBy(x => x.Name).ToList();
        }

        private void lastNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=list.OrderBy(x => x.Surname).ToList();
        }

        private void patronymicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=list.OrderBy(x => x.Patronymic).ToList();
        }

        private void birthdayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=list.OrderBy(x => x.Birthday).ToList();
        }

        private void phoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=list.OrderBy(x => x.PhoneNumber).ToList();
        }
        // Конец обработки кнопок сортировки записей по параметрам

            // Открытие корзины
        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3=new Form3();
            f3.Owner=this;
            f3.Bas=basket;
            f3.dataGridView1.DataSource=basket.ToList();
            f3.ShowDialog();
        }

        // Открытие календаря
        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        // Обновление записей таблицы: загрузка измененных и восстановленных записей в таблицу
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (f3.Recover!=null)
                {
                    list.AddRange(f3.Recover);
                    f3.Recover.Clear();
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
            Output();
        }

        // Открытие окна "О программе"
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

        // Кнопка сохранения данных в Excel
        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToExcel();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        // Режим редактирования записей по нажатию на ячейку
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime d = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString());
                textBox1.Text=dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text=dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text=dataGridView1[2, e.RowIndex].Value.ToString();
                textBox5.Text=dataGridView1[4, e.RowIndex].Value.ToString();
                dateTimePicker1.Value=d;
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Темная тема
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=dark;
            this.ForeColor=whited;

            button1.ForeColor=dark;
            button2.ForeColor=dark;
            button3.ForeColor=dark;
            button4.ForeColor=dark;
            button5.ForeColor=dark;

            menuStrip1.BackColor=whited;

            dataGridView1.ForeColor=dark;
            dataGridView1.BackgroundColor=dark;

            label6.BackColor=whited;
            label6.ForeColor=dark;
        }

        // Светлая тема
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=light;
            this.ForeColor=dark;

            dataGridView1.BackgroundColor=Color.AntiqueWhite;

            menuStrip1.BackColor=Color.White;

            label6.BackColor=Color.White;
        }

        // Тема по умолчанию
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(240, 240, 240);
            this.ForeColor=Color.Black;

            menuStrip1.BackColor=Color.FromArgb(245, 245, 245);
            label6.BackColor=Color.FromArgb(245, 245, 245);

            dataGridView1.BackgroundColor=Color.FromArgb(171, 171, 171);
        }

        // Обработка ввода. Доступны только цифры.
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&&number!=8)
            {
                e.Handled=true;
            }
        }

        // Обработка ввода. Доступны только буквы.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
            {
                e.Handled=true;
            }
        }

        // Обработка ввода. Доступны только буквы.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
            {
                e.Handled=true;
            }
        }

        // Обработка ввода. Доступны только буквы.
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
            {
                e.Handled=true;
            }
        }

        private void topicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                print = "";
                if (dataGridView1.RowCount!=0)
                {
                    for (int i = 0; i<dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j<dataGridView1.ColumnCount; j++)
                        {
                            print+=dataGridView1[j, i].Value.ToString();
                        }
                        print+="\n";
                    }

                    PrintDocument pD = new PrintDocument();
                    pD.PrintPage+=PrintPageHandler;

                    PrintDialog pDg = new PrintDialog();
                    pDg.Document=pD;

                    if (pDg.ShowDialog()==DialogResult.OK)
                        pDg.Document.Print();
                } else { MessageBox.Show("Table is empty!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveAt(dataGridView1.CurrentRow.Index);
                string date = dateTimePicker1.Value.ToLongDateString();
                AddRecord(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text);
                Output();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
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

        public Record(string Name, string Surname, string Patronymic, string Birthday, string PhoneNumber)
        {
            this.Name=Name;
            this.Surname=Surname;
            this.Patronymic=Patronymic;
            this.Birthday=Birthday;
            this.PhoneNumber=PhoneNumber;
        }
    }
}
