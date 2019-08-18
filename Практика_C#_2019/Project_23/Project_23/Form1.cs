using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_23
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
                string password = textBox1.Text;
                Regex reg1 = new Regex(@"[*&{}|+]");
                Regex reg2 = new Regex(@"[a-z]+");
                Regex reg3 = new Regex(@"^.*(.)(\1)(\1).*$");

                if (textBox1.TextLength >= 6 && reg1.IsMatch(password) == false && reg2.IsMatch(password) && reg3.IsMatch(password) == false)
                {
                    MessageBox.Show("Пароль введен верно");
                }
                else
                {
                    if (reg1.IsMatch(password) == true)
                        MessageBox.Show("Не должны встречаться символы: * & { } | +");

                    if (reg3.IsMatch(password) == true)
                        MessageBox.Show("Не должны встречаться 3 подряд идущих одинаковых символа");

                    if (textBox1.TextLength < 6)
                        MessageBox.Show("Количество символов должно быть 6 и более");

                    if (reg2.IsMatch(password) == false)
                        MessageBox.Show("Должны встречаться незаглавные буквы.");

                    MessageBox.Show("Пароль введен неверно.");
                }
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
