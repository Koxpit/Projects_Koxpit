using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lab;
        int x, y;
        FontDialog fd = new FontDialog();
        ColorDialog cd = new ColorDialog();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab = new Label();
            lab.Parent = this;
            lab.Location = new Point(100, 100);
            lab.Text = textBox1.Text;
            lab.MouseDown += Lab_MouseDown;
            lab.MouseUp += Lab_MouseUp;
            lab.MouseMove += Lab_MouseMove;
        }

        private void Lab_MouseMove(object sender, MouseEventArgs e)
        {
            var lab = sender as Label;
            lab.Left += (e.X - x);
            lab.Top += (e.Y - y);
        }

        private void Lab_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lab.Font = fd.Font;
                } catch
                {
                    MessageBox.Show("Сначала добавьте букву.");
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    lab.ForeColor = cd.Color;
                } catch
                {
                    MessageBox.Show("Сначала добавьте букву.");
                    return;
                }
            }
        }

        private void Lab_MouseUp(object sender, MouseEventArgs e)
        {
            x = y = 0;
        }
    }
}
