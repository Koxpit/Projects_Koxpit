using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
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

        private int n;
        private double sum = 0;
        private double zer = 0;
        private double g;

        class Result
        {
            public int x, y, r;

            public Result(int X, int Y, int R)
            {
                x=X;
                y=Y;
                r=R;
            }

            public Boolean Check()
            {
                    if ((y>0)&&(y>x)&&(y>r-x)||(y<0)&&(-y<-x)&&(-y<r-x))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Result res = new Result(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                if (n>0)
                {
                    button3.Enabled=false;
                    button4.Enabled=false;
                }
                else
                {
                    button3.Enabled=true;
                    button4.Enabled=true;
                }
                n--;
                label5.Text=n.ToString();
                if (n<0)
                {
                    label5.Text="0";
                    listBox1.Items.Add("Количество попыток закончилось.");
                    button2.Enabled=true;
                    return;
                }
                else
                {
                    if (res.Check())
                    {
                        sum+=1;
                        listBox1.Items.Add("Попадание в мишень");
                    }
                    else
                    {
                        zer+=1;
                        listBox1.Items.Add("Промах");
                    }

                    if (n==0)
                    {
                        button2.Enabled=true;
                        button3.Enabled=true;
                        button4.Enabled=true;
                    }
                }
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n=Convert.ToInt32(textBox4.Text);
                label5.Text=n.ToString();
                button2.Enabled=false;
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Result res = new Result(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                g=(sum/(sum+zer))*100;
                listBox1.Items.Add("Число попаданий: " + sum);
                listBox1.Items.Add("Процент точных попаданий: " + g);
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
