using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y, r;
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                r = Convert.ToDouble(textBox3.Text);
                if ((y > 0) && (y > x) && (y > r - x) || (y < 0) && (-y < -x) && (-y < r - x)) MessageBox.Show("Точка попадает в закрашенную часть.");
                else MessageBox.Show("Точка не попадает в закрашенную часть.");
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
