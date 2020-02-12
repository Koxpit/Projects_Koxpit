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
    public partial class CalendarForm : Form
    {
        private string printData = "";
        private List<Calendar> recordList;

        public List<Calendar> RecordList
        {
            get { return recordList; }
            set { recordList = value; }
        }

        public CalendarForm()
        {
            InitializeComponent();
            recordList = new List<Calendar>();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void AddRecord()
        {
            try
            {
                recordList.Add(new Calendar {
                    Date = monthCalendar.SelectionStart.ToLongDateString(),
                    Note = textBox.Text
                });
                OutputListRecordToDataGrid();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void OutputListRecordToDataGrid()
        {
            try
            {
                dataGridView.DataSource = recordList.ToList();
            }
            catch { MessageBox.Show("Error adding/updating table!"); }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow != null)
                {
                    if (dataGridView.SelectedRows.Count == 0)
                        MessageBox.Show("No records selected!");
                    else
                        foreach (DataGridViewRow row in dataGridView.SelectedRows)
                            recordList.RemoveAt(row.Index);
                    OutputListRecordToDataGrid();
                }
                else
                {
                    MessageBox.Show("Book is empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Удаление выделенной записи и загрузка измененной в таблицу
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            recordList.RemoveAt(dataGridView.CurrentRow.Index);
            AddRecord();
            OutputListRecordToDataGrid();
        }

        // Обработка двойного клика по ячейке для изменения записи
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox.Text = dataGridView[1, e.RowIndex]
                .Value.ToString();
            monthCalendar.SelectionStart = DateTime.Parse(dataGridView[0, e.RowIndex]
                .Value.ToString());
        }

        // Сортировка записей по дате
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = recordList.OrderBy(x => x.Date).ToList();
        }

        // Сохранение записей из таблицы в Excel таблицу
        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => SaveToExcel());
        }

        public void SaveToExcel()
        {
            SaveRecords.SaveToExcel(dataGridView);
        }

        // Печать данных
        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => PrintRecordsToDocument());
        }

        private void PrintRecordsToDocument()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                    printData += row.Cells[0].Value.ToString() + ": "
                        + row.Cells[1].Value.ToString() + "\n";

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printData, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    [Serializable]
    public struct Calendar
    {
        internal string Date { get; set; }
        internal string Note { get; set; }
    }
}
