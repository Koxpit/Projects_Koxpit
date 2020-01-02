using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class Form4 : Form
    {
        private string print = "";

        private List<Calendar> record { get; set; }

        public List<Calendar> Record
        {
            get { return record; }
            set { record=value; }
        }

        public Form4()
        {
            InitializeComponent();

            record=new List<Calendar>();
        }

        // Вывод данных из списка в таблицу
        private void Output()
        {
            try
            {
                dataGridView1.DataSource=record.ToList();
            } catch { MessageBox.Show("Error adding/updating table!"); }
        }

        // Удаление записи
        private void DelRecord()
        {
            try
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
                            record.RemoveAt(row.Index);
                        }
                    }

                    dataGridView1.DataSource=record.ToList();
                }
                else { MessageBox.Show("Book is empty!"); }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Добавление записи
        private void AddRecord()
        {
            try
            {
                Calendar note = new Calendar(monthCalendar1.SelectionStart.ToLongDateString(), textBox1.Text);
                record.Add(note);
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
            Output();
        }

        // Обработка кнопки добавления записи
        private void button1_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        // Обработка кнопки удаления записи
        private void button2_Click(object sender, EventArgs e)
        {
            DelRecord();
        }

        // Сохранение данных из таблицы в Excel файл
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

        // Обработка кнопки меню
        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => SaveToExcel());
        }

        // Печать
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void Print()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    print += row.Cells[0].Value.ToString() + ": " + row.Cells[1].Value.ToString() + "\n";

                PrintDocument pD = new PrintDocument();
                pD.PrintPage += PrintPageHandler;

                PrintDialog pDg = new PrintDialog();
                pDg.Document = pD;

                if (pDg.ShowDialog() == DialogResult.OK)
                    pDg.Document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Печать
        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Print());
        }

        // Сортировка данных по дате
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=record.OrderBy(x => x.Date).ToList();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        // Вывод окна "О программе"
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Закрытие текущего окна
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработка двойного клика по ячейке для изменения записи
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime d = DateTime.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
            textBox1.Text=dataGridView1[1, e.RowIndex].Value.ToString();
            monthCalendar1.SelectionStart=d;
        }

        // Удаление старой и загрузка измененной записи в таблицу
        private void button3_Click(object sender, EventArgs e)
        {
            record.RemoveAt(dataGridView1.CurrentRow.Index);
            AddRecord();
            Output();
        }
    }

    [Serializable] // - для работы с файлами(загрузка, получение данных)
    public struct Calendar
    {
        public string Date { get; set; }
        public string Note { get; set; }

        public Calendar(string Date, string Note)
        {
            this.Date=Date;
            this.Note=Note;
        }
    }
}
