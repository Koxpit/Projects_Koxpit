using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Note
{
    public partial class Form4 : Form
    {
        private string print = "";

        private List<Calendar> record;
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

        private void Output()
        {
            dataGridView1.DataSource=record.ToList();
        }

        private void DelRecord()
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
        }

        private void AddRecord()
        {
            Calendar note = new Calendar(monthCalendar1.SelectionStart.ToLongDateString(), textBox1.Text);
            record.Add(note);
            Output();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelRecord();
        }

        public void SaveToXML()
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
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToXML();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    print+=row.Cells[0].Value.ToString()+": "+row.Cells[1].Value.ToString() + "\n";

                PrintDocument pD = new PrintDocument();
                pD.PrintPage+=PrintPageHandler;

                PrintDialog pDg = new PrintDialog();
                pDg.Document=pD;

                if (pDg.ShowDialog()==DialogResult.OK)
                    pDg.Document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=record.OrderBy(x => x.Date).ToList();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime d = DateTime.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
            textBox1.Text=dataGridView1[1, e.RowIndex].Value.ToString();
            monthCalendar1.SelectionStart=d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            record.RemoveAt(dataGridView1.CurrentRow.Index);
            AddRecord();
            Output();
        }
    }

    [Serializable]
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
