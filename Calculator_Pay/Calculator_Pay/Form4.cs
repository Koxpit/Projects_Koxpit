using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_Pay
{
    public partial class Form4 : Form
    {
        Color btnc = Color.FromArgb(8, 0, 0);
        Font font_button = new Font("Arial Black", 11, FontStyle.Regular);
        Color color = Color.FromArgb(248, 212, 136);
        Color bound_element = Color.FromArgb(179, 113, 34);

        public Form4()
        {
            InitializeComponent();

            button1.Font=font_button;
            button2.Font=font_button;
            button3.Font=font_button;

            button1.BackColor=color;
            button2.BackColor=color;
            button3.BackColor=color;

            button2.ForeColor=btnc;
            button1.ForeColor=btnc;
            button3.ForeColor=btnc;

            button1.FlatAppearance.BorderSize=2;
            button1.FlatStyle=FlatStyle.Flat;
            button1.FlatAppearance.BorderColor=bound_element;

            button2.FlatAppearance.BorderSize=2;
            button2.FlatStyle=FlatStyle.Flat;
            button2.FlatAppearance.BorderColor=bound_element;

            button3.FlatAppearance.BorderSize=2;
            button3.FlatStyle=FlatStyle.Flat;
            button3.FlatAppearance.BorderColor=bound_element;
        }

        ChargedForm f2 = null;
        PieceRateForm f3 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (f2==null||f2.IsDisposed)
            {
                f2=new ChargedForm();
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f3==null||f3.IsDisposed)
            {
                f3=new PieceRateForm();
                f3.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }
    }
}
