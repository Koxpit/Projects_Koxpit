using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            monthCalendar1.TodayDate=DateTime.Now;

            monthCalendar1.SelectionRange=
                new SelectionRange(monthCalendar1.TodayDate, monthCalendar1.TodayDate);

            button1.Enabled=false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString()==","&&
                    textBox1.Text.IndexOf(",")==-1)&&
                    !(e.KeyChar.ToString()=="-"&&
                    textBox1.Text.Length==0))
                    e.Handled=true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&
                textBox1.Text!="-"&&
                textBox1.Text!=","&&
                textBox1.Text!="-,")
                button1.Enabled=true;
            else button1.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tp;

            try
            {
                tp=Convert.ToDouble(textBox1.Text);
            } catch
            {
                MessageBox.Show("Введенное значение иеет неверный формат.",
                    "Погода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fi = new FileInfo(Application.StartupPath+"\\meteo.txt");

            StreamWriter sw;

            if (fi.Exists)
                sw=fi.AppendText();
            else
                sw=fi.CreateText();

            DateTime dt = monthCalendar1.SelectionStart;
            do
            {
                sw.WriteLine(dt.ToShortDateString()+
                    " "+tp.ToString("N"));
                dt=dt.AddDays(1);
            } while (DateTime.Compare(monthCalendar1.SelectionEnd, dt)>=0);

            sw.Close();

            textBox1.Text=string.Empty;
        }
    }
}
