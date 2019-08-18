using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox Block = new PictureBox();
            Image bl = Image.FromFile(@"F:\src\Project_3\График.png");
            Block.Image=bl;
            Block.Location=new Point(150, 10);
            Block.Size=bl.Size;
            Controls.Add(Block);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Y = 0;
            double X = 0;
            double R = 0;

            try
            {
                X=Convert.ToDouble(textBox1.Text);
                R=Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Введены неверные значения");
            }

            try
            {
                if (-9<=X&&X<-6)
                {
                    Y=-Math.Sqrt(Math.Pow(R, 2)-Math.Pow((X+6), 2));
                }
                else if (-6<=X&&X<=-3)
                {
                    Y=X+3;
                }
                else if (-3<X&&X<0)
                {
                    Y=Math.Sqrt(Math.Pow(R, 2)-Math.Pow(X, 2));
                }
                else if (0<=X&&X<=3)
                {
                    Y=-X+3;
                }
                else
                {
                    Y=0.5*X-1.5;
                }
            } catch
            {
                MessageBox.Show("Ошибка в вычислениях.");
            }

            MessageBox.Show("Значение ординаты: "+Y);
        }
    }
}
