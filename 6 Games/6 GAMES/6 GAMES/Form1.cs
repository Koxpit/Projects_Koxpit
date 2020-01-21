using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SocNet_Click(object sender, EventArgs e)
        {
            SocNet newForm = new SocNet();
            OpenNewForm(newForm);
        }

        private void OpenNewForm(Form newForm)
        {
            Hide();
            newForm.Show();
        }

        private void DONATE_Click(object sender, EventArgs e)
        {
            DONATE newForm = new DONATE();
            OpenNewForm(newForm);
        }

        private void help_Click(object sender, EventArgs e)
        {
            HELP newForm = new HELP();
            OpenNewForm(newForm);
        }

        private void Games_Click(object sender, EventArgs e)
        {
            Games newForm = new Games();
            OpenNewForm(newForm);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings newForm = new settings();
            OpenNewForm(newForm);
        }


        //игры

        private void button1_Click(object sender, EventArgs e)
        {
            Game1 newForm = new Game1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game2 newForm = new Game2();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game3 newForm = new Game3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game4 newForm = new Game4();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Game5 newForm = new Game5();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Game6 newForm = new Game6();
            newForm.Show();
        }

    }

    // ---------------------------------------------класс-теста-возраста-----------------------
    public class oldik
    {
        public bool TestOld(string olds)
        {
            Regex pravilo1 = new Regex(@"[a-z]+");
            Regex pravilo2 = new Regex(@"[A-Z]+");
            Regex pravilo3 = new Regex(@"[* & { } | = +]+");
            Regex pravilo4 = new Regex(@"[А-Я]+");
            Regex pravilo5 = new Regex(@"[а-я]+");
            if (olds.Length > 2
                || pravilo1.IsMatch(olds)
                || olds.Length == 0
                || pravilo2.IsMatch(olds)
                || pravilo3.IsMatch(olds)
                || pravilo4.IsMatch(olds)
                || pravilo5.IsMatch(olds))
                return true;
            else
                return false;
        }
    }
}
