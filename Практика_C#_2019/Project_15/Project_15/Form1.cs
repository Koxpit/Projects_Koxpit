using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled=false;
            radioButton1.Checked=true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!(Char.IsControl(e.KeyChar)))
                if (!((e.KeyChar.ToString()==",")&&(textBox1.Text.IndexOf(",")==-1)))
                    e.Handled=true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!(Char.IsControl(e.KeyChar)))
                if (!((e.KeyChar.ToString()==",")&&(textBox2.Text.IndexOf(",")==-1)))
                    e.Handled=true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Text!=string.Empty)
                label5.Text=string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single w, h, s, c, cst;
            w=Convert.ToSingle(textBox1.Text);
            h=Convert.ToSingle(textBox2.Text);
            s=w*h/1000000;

            if (radioButton1.Checked)
                c=7000;
            else
                c=9000;
            cst=s*c;

            if (checkBox1.Checked) cst+=100;
            if (checkBox2.Checked) cst+=2000;
            if (checkBox3.Checked) cst+=2000;

            if (radioButton1.Checked)
                label5.Text = "Размер окна: " + w.ToString() + " x " + h.ToString() + " мм\n" +
                    "Откидной: 7000 руб/м2" + "\nСтоимость: " + cst.ToString();
            else
                label5.Text = "Размер окна: " + w.ToString() + " x " + h.ToString() + " мм\n" +
                    "Поворотно-откидной: 9000 руб/м2" + "\nСтоимость: " + cst.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text!=string.Empty)
                label5.Text=string.Empty;

            if((textBox1.TextLength==0)||(textBox2.TextLength==0)||
                    (textBox1.Text==",")||(textBox2.Text==","))
                button1.Enabled=false;
            else button1.Enabled=true;
        }
    }
}
