using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_24
{
    public partial class Form1 : Form
    {
        private const int bw = 80, bh = 50,
            bdx = 10, bdy = 10;
        Button[] btn = new Button[10];
        int[] v = new int[10];
        RadioButton rb1;
        RadioButton rb2;
        Label l1; Label l2; Label l3; Label l4;
        int c, d;

        private void button2_Click(object sender, EventArgs e)
        {
            l1.Text="Количество выигрышей у нолика: 0";
            l2.Text="Количество выигрышей у крестика: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 10; i++)
                btn[i].Text="";
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            l1=new Label();
            l1.Parent=this;
            l1.Location=new Point(400, 300);
            l1.Size=new Size(200, 30);
            l1.Text="Количество выигрышей у нолика: 0";

            l2=new Label();
            l2.Parent=this;
            l2.Location=new Point(400, 330);
            l2.Size=new Size(200, 30);
            l2.Text="Количество выигрышей у крестика: 0";

            for (int i = 1; i<10; i++)
            {
                btn[i]=new Button();
                    btn[i].Name="Button"+Convert.ToString(i);

                        x=((i-1)%3)*bw+
                            (((i-1)%3)+1)*bdx;
                        y=(((9-i)/3)+1)*bh+
                            (((9-i)/3)+2)*bdy;
                        btn[i].SetBounds(x, y, bw, bh);

                v[i]=i;

                btn[i].Click+=new EventHandler(ButtonN_Click);
                Controls.Add(btn[i]);
            }

            rb1 = new RadioButton();
            rb1.Parent = this;
            rb1.Location = new Point(400, 60);
            rb1.Text = "X";
            rb1.Size = new Size(40, 40);

            rb2 = new RadioButton();
            rb2.Parent = this;
            rb2.Location = new Point(400, 110);
            rb2.Text = "0";
            rb2.Size = new Size(40, 40);
        }

        private int t=0;
        private void ButtonN_Click(object sender, EventArgs e)
        {
            Button btn_c = (Button)sender;
            if (rb1.Checked)
            {
                if (t%2!=0)
                {
                    btn_c.Text=rb1.Text;
                    t++;
                }
                else MessageBox.Show("Ходить должен нолик");
            }
            else if (rb2.Checked)
            {
                if (t%2==0)
                {
                    btn_c.Text=rb2.Text;
                    t++;
                }
                else MessageBox.Show("Ходить должен крестик");
            }
            else MessageBox.Show("Первым ходит нолик. Выберите '0'");


            if (btn[v[1]].Text=="0"&&btn[v[2]].Text=="0"&&btn[v[3]].Text=="0")
            {
                MessageBox.Show("Нолик выиграл");
                c++;
                l1.Text="Количество выигрышей у нолика: "+c.ToString();
            }
            if (btn[v[4]].Text=="0"&&btn[v[5]].Text=="0"&&btn[v[6]].Text=="0")
            {
                MessageBox.Show("Нолик выиграл");
                c++;
                l1.Text="Количество выигрышей у нолика: "+c.ToString();
            }
            if (btn[v[7]].Text=="0"&&btn[v[8]].Text=="0"&&btn[v[9]].Text=="0")
            {
                MessageBox.Show("Нолик выиграл");
                c++;
                l1.Text="Количество выигрышей у нолика: "+c.ToString();
            }
            if (btn[v[1]].Text=="X"&&btn[v[2]].Text=="X"&&btn[v[3]].Text=="X")
            {
                MessageBox.Show("Крестик выиграл");
                d++;
                l2.Text="Количество выигрышей у крестика: "+d.ToString();
            }
            if (btn[v[4]].Text=="X"&&btn[v[5]].Text=="X"&&btn[v[6]].Text=="X")
            {
                MessageBox.Show("Крестик выиграл");
                d++;
                l2.Text="Количество выигрышей у крестика: "+d.ToString();
            }
            if (btn[v[7]].Text=="X"&&btn[v[8]].Text=="X"&&btn[v[9]].Text=="X")
            {
                MessageBox.Show("Крестик выиграл");
                d++;
                l2.Text="Количество выигрышей у крестика: "+d.ToString();
            }

            if (btn[v[1]].Text=="0"&&btn[v[5]].Text=="0"&&btn[v[9]].Text=="0")
            {
                MessageBox.Show("Нолик выиграл");
                c++;
                l1.Text="Количество выигрышей у нолика: "+c.ToString();
            }
            if (btn[v[3]].Text=="0"&&btn[v[5]].Text=="0"&&btn[v[7]].Text=="0")
            {
                MessageBox.Show("Нолик выиграл");
                c++;
                l1.Text="Количество выигрышей у нолика: "+c.ToString();
            }

            if (btn[v[1]].Text=="X"&&btn[v[5]].Text=="X"&&btn[v[9]].Text=="X")
            {
                MessageBox.Show("Крестик выиграл");
                d++;
                l2.Text="Количество выигрышей у крестика: "+d.ToString();
            }
            if (btn[v[3]].Text=="X"&&btn[v[5]].Text=="X"&&btn[v[7]].Text=="X")
            {
                MessageBox.Show("Крестик выиграл");
                d++;
                l2.Text="Количество выигрышей у крестика: "+d.ToString();
            }
        }
    }
}
