using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_18
{
    public partial class Form1 : Form
    {
        private const int CN = 3;

        private int t, s;

        private int[] n = new int[CN];

        public Form1()
        {
            InitializeComponent();
            groupBox1.Text = "Угадайте загаданное компьютером трехзначное число. Введите свой вариант и нажмите <Enter>";
            //statusBar1.ShowPanels=true;
            //statusBar1.SizingGrip=false;

            label4.Text=" Попыток: 0";
            label5.Text=" Затрачено времени: 0 сек.";

            groupBox1.Enabled=true;

            timer1.Interval=1000;
            timer1.Enabled=false;

            textBox1.MaxLength=CN;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            label5.Text=" Затрачено времени: "+s.ToString() +" сек.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                Random rnd = new Random();

                n[0] = rnd.Next(9) + 1;

                for (int i = 0; i < CN; i++)
                    n[i] = rnd.Next(10);

                t = 0; s = 0;

                textBox1.Text = string.Empty;
                button1.Text = "Стоп";

                textBox1.Select();

                groupBox1.Enabled = true;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                groupBox1.Enabled = false;

                textBox1.Text = string.Empty;
                button1.Text = "Начать";

                label2.Text = "Угадано цифр: 0";
                label3.Text = "Цифр на правильных позициях: 0";

                label4.Text = " Попыток: 0";
                label5.Text = " Затрачено времени: 0 сек.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean[] r = new Boolean[CN];

            int pn = 0, rn = 0;

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar.Equals((char)13))
                {
                    t++;

                    label4.Text = " Попыток: " + t.ToString();

                    for (int i = 0; i < textBox1.TextLength; i++)
                    {
                        for (int j = 0; j < CN; j++)
                            if ((Convert.ToInt16(textBox1.Text.Substring(i, 1)) == n[j])
                                && (!r[j]))
                            {
                                rn++;
                                r[j] = true;
                                break;
                            }

                        if (Convert.ToInt16(textBox1.Text.Substring(i, 1)) == n[i])
                            pn++;
                    }

                    label2.Text = "Угадано цифр: " + rn.ToString();
                    label3.Text = "Цифр на правильных позициях: " + pn.ToString();

                    if (pn == CN)
                    {
                        timer1.Enabled = false;
                        groupBox1.Enabled = false;

                        MessageBox.Show("Вы угадали!\n" +
                            "Загаданное число: " + textBox1.Text +
                            "\nСовершено попыток: " + t.ToString() +
                            "\nЗатрачено времени: " + s.ToString() +
                            " сек.", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Text = string.Empty;
                        button1.Text = "Начать";

                        label2.Text = "Угадано цифр: 0";
                        label3.Text = "Цифр на правильных позициях: 0";

                        label4.Text = " Попыток: 0";
                        label5.Text = " Затрачено времени: 0 сек.";
                    }
                }
            }
            else e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
