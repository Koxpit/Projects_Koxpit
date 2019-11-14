using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        private List<Record> basket;
        public List<Record> Basket
        {
            get { return basket; }
            set { basket=value; }
        }

        public Form1()
        {
            InitializeComponent();

            basket=new List<Record>();
            f3=new Form3();
            LoadData();
        }

        private void LoadData()
        {
            Form2 f2 = new Form2();
            int id = f2.id;
            FileStream fs = new FileStream(id.ToString()+".dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            if (fs.Length==0)
                list=new List<Record>();
            else
                list=(List<Record>)formatter.Deserialize(fs);
            dataGridView1.DataSource=list.ToList();

            fs.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.BackColor=Color.FromArgb(245, 245, 245);
            toolTip1.SetToolTip(button5, "Load recovered recordings.");
            toolTip1.SetToolTip(button3, "*all parameters.");
        }

        public void SaveToExcel()
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

        public void Output()
        {
            dataGridView1.DataSource=list.ToList();
        }

        public List<Record> SearchFName(string FName)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Name==FName)
                    ret.Add(rec);

            return ret;
        }

        public List<Record> SearchLName(string LName)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Surname==LName)
                    ret.Add(rec);

            return ret;
        }

        public List<Record> SearchPatronymic(string Patronymic)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Patronymic==Patronymic)
                    ret.Add(rec);

            return ret;
        }

        public List<Record> SearchBirthday(string Birthday)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Birthday==Birthday)
                    ret.Add(rec);

            return ret;
        }

        public List<Record> SearchPhoneNumber(string PhoneNumber)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.PhoneNumber==PhoneNumber)
                    ret.Add(rec);

            return ret;
        }

        public List<Record> SearchRecords(string Name, string Surname, string Patronymic, string Birthday, string PhoneNumber)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in list)
                if (rec.Name==Name||rec.Surname==Surname||rec.Patronymic==Patronymic||rec.Birthday==Birthday||rec.PhoneNumber==PhoneNumber)
                    ret.Add(rec);

            return ret;
        }

        public void AddRecord(string Name, string Surname, string Patronymic, string Birthday, string PhoneNumber)
        {
            list.Add(new Record(Name, Surname, Patronymic, Birthday, PhoneNumber));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToLongDateString();
            AddRecord(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text);
            Output();
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToLongDateString();
            dataGridView1.DataSource=SearchRecords(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text).ToList();
            dataGridView1.ReadOnly=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly=false;
            Output();
        }

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchFName(textBox1.Text).ToList();
            dataGridView1.ReadOnly=true;
        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchLName(textBox2.Text).ToList();
            dataGridView1.ReadOnly=true;
        }

        private void patronymicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchPatronymic(textBox3.Text);
            dataGridView1.ReadOnly=true;
        }

        private void birthdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToLongDateString();
            dataGridView1.DataSource=SearchBirthday(data).ToList();
            dataGridView1.ReadOnly=true;
        }

        private void numberTelephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SearchPhoneNumber(textBox5.Text).ToList();
            dataGridView1.ReadOnly=true;
        }

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

        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3=new Form3();
            f3.Owner=this;
            f3.Bas=basket;
            f3.dataGridView1.DataSource=basket.ToList();
            f3.ShowDialog();

        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToLongDateString();
            list.RemoveAt(dataGridView1.CurrentRow.Index);
            AddRecord(textBox1.Text, textBox2.Text, textBox3.Text, date, textBox5.Text);

            if (f3.Recover!=null)
            {
                list.AddRange(f3.Recover);
                f3.Recover.Clear();
            }
            Output();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToExcel();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime d = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString());
            textBox1.Text=dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text=dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text=dataGridView1[2, e.RowIndex].Value.ToString();
            textBox5.Text=dataGridView1[4, e.RowIndex].Value.ToString();
            dateTimePicker1.Value=d;
        }

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

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=light;
            this.ForeColor=dark;

            dataGridView1.BackgroundColor=Color.AntiqueWhite;

            menuStrip1.BackColor=Color.White;

            label6.BackColor=Color.White;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(240, 240, 240);
            this.ForeColor=Color.Black;

            menuStrip1.BackColor=Color.FromArgb(245, 245, 245);
            label6.BackColor=Color.FromArgb(245, 245, 245);

            dataGridView1.BackgroundColor=Color.FromArgb(171, 171, 171);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&&number!=8)
            {
                e.Handled=true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
            {
                e.Handled=true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch<'А'||ch>'я')&&(ch<'A'||ch>'z')&&ch!='\b')
            {
                e.Handled=true;
            }
        }

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
    }

    [Serializable]
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
