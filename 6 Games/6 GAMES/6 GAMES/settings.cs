using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void OK_Click(object sender, EventArgs e)
        {



                Regex pravilo1 = new Regex(@"[a-z]+");

                Regex pravilo2 = new Regex(@"[A-Z]+");

                Regex pravilo3 = new Regex(@"[* & { } | = +]+");

                Regex pravilo4 = new Regex(@"[А-Я]+");

                Regex pravilo5 = new Regex(@"[а-я]+");
 

            if (textBox1.Text.Length > 2 || pravilo1.IsMatch(textBox1.Text) || textBox1.Text.Length == 0 || pravilo2.IsMatch(textBox1.Text) || pravilo3.IsMatch(textBox1.Text) || pravilo4.IsMatch(textBox1.Text) || pravilo5.IsMatch(textBox1.Text))
                    MessageBox.Show("вы допустили ошибку");
                
                else

                    MessageBox.Show("Ваш возраст указан правильно");
            
        }
    }
}
