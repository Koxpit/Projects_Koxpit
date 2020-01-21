using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game4 : Form
    {
        private string hod;

        public Game4()
        {
            InitializeComponent();
            panel1_Resize(null, null);
            hod = "X";
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            //------------------------------ряд 1-------------------------

            button1.Top = 0;
            button1.Left = 0;
            SetWidthAndHeightButtons(button1);

            button2.Top = 0;
            button2.Left = panel1.Width / 3;
            SetWidthAndHeightButtons(button2);

            button3.Top = 0;
            button3.Left = panel1.Width * 2 / 3;
            SetWidthAndHeightButtons(button3);

            //------------------------------ряд 2-------------------------

            button4.Top = panel1.Height / 3;
            button4.Left = 0;
            SetWidthAndHeightButtons(button4);

            button5.Top = panel1.Height / 3;
            button5.Left = panel1.Width / 3;
            SetWidthAndHeightButtons(button5);

            button6.Top = panel1.Height / 3;
            button6.Left = panel1.Width * 2 / 3;
            SetWidthAndHeightButtons(button6);

            //------------------------------ряд 3-------------------------

            button7.Top = panel1.Height * 2 / 3;
            button7.Left = 0;
            SetWidthAndHeightButtons(button7);

            button8.Top = panel1.Height * 2 / 3;
            button8.Left = panel1.Width / 3;
            SetWidthAndHeightButtons(button8);

            button9.Top = panel1.Height * 2 / 3;
            button9.Left = panel1.Width * 2 / 3;
            SetWidthAndHeightButtons(button9);
        }

        private void SetWidthAndHeightButtons(Button button)
        {
            button.Width = panel1.Width / 3;
            button.Height = panel1.Height / 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetBeginHod(button1);
            ProcessGaming(button1.Text);
        }

        private void SetBeginHod(Button button)
        {
            if (button.Text == "")
            {
                button.Text = hod;
                if (hod == "X")
                    hod = "0";
                else
                    hod = "X";
            }
        }

        private void ProcessGaming(string element)
        {
            switch(element)
            {
                case "X":
                    if (CheckWin("X"))
                    {
                        MessageBox.Show("Крестики победили");
                        ResetGame();
                    }
                    break;
                case "0":
                    if (CheckWin("0"))
                    {
                        MessageBox.Show("Нолики победили");
                        ResetGame();
                    }
                    break;
            }

            if (IsTie())
            {
                MessageBox.Show("Ничья");
                ResetGame();
            }
        }

        private bool CheckWin(string element)
        {
            if ((button1.Text == element) && (button2.Text == element) && (button3.Text == element))
                return true;
            else if ((button1.Text == element) && (button4.Text == element) && (button7.Text == element))
                return true;
            else if ((button1.Text == element) && (button5.Text == element) && (button9.Text == element))
                return true;
            else if ((button3.Text == element) && (button6.Text == element) && (button9.Text == element))
                return true;
            else if ((button7.Text == element) && (button8.Text == element) && (button9.Text == element))
                return true;
            else if ((button2.Text == element) && (button5.Text == element) && (button8.Text == element))
                return true;
            else if ((button3.Text == element) && (button5.Text == element) && (button7.Text == element))
                return true;
            else if ((button4.Text == element) && (button5.Text == element) && (button6.Text == element))
                return true;
            else
                return false;
        }

        private bool IsTie()
        {
            if (((button1.Text == "0") || (button1.Text == "X"))
                && ((button2.Text == "0") || (button2.Text == "X"))
                && ((button3.Text == "0") || (button3.Text == "X"))
                && ((button4.Text == "0") || (button4.Text == "X"))
                && ((button5.Text == "0") || (button5.Text == "X"))
                && ((button6.Text == "0") || (button6.Text == "X"))
                && ((button7.Text == "0" || (button7.Text == "X"))
                && ((button8.Text == "0") || (button8.Text == "X"))
                && ((button9.Text == "0") || (button9.Text == "X"))))
                return true;
            return false;
        }

        private void ResetGame()
        {
            Close();
            Game4 newForm = new Game4();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetBeginHod(button2);
            ProcessGaming(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetBeginHod(button3);
            ProcessGaming(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetBeginHod(button4);
            ProcessGaming(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetBeginHod(button5);
            ProcessGaming(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetBeginHod(button6);
            ProcessGaming(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetBeginHod(button7);
            ProcessGaming(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetBeginHod(button8);
            ProcessGaming(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetBeginHod(button9);
            ProcessGaming(button9.Text);
        }
    }
}
