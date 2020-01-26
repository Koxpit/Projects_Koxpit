using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game5 : Form
    {
        int sleep = 0;

        public Game5()
        {
            InitializeComponent();
            pictureBoxHero.Image = imageList.Images[0];
        }

        private void eat_Click(object sender, EventArgs e)
        {
            if(progressBarHungry.Value > progressBarHungry.Maximum-50)
            {
                pictureBoxHero.Image = imageList.Images[3];
                progressBarHungry.Value -= 50;
            }
            else
            {
                progressBarHungry.Value = 0;
            }
        }

        private void slep_Click(object sender, EventArgs e)
        {
            pictureBoxHero.Image = imageList.Images[8];
            sleep = 1;
        }

        private void game_Click(object sender, EventArgs e)
        {
            if (progressBarHappy.Value < progressBarHappy.Maximum-50)
            {
                pictureBoxHero.Image = imageList.Images[1];
                progressBarHappy.Value += 50;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBarHungry.Value++;
                if (sleep == 1)
                    progressBarFatigue.Value -= 10;
                else
                    progressBarFatigue.Value++;
                progressBarHappy.Value--;
            }
            catch
            {
                sleep = 0;
                pictureBoxHero.Image = imageList.Images[0];
            }
        }

        private void no_slep_Click(object sender, EventArgs e)
        {
            pictureBoxHero.Image = imageList.Images[0];
            sleep = 0;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            Close();
            Game5 newForm = new Game5();
            newForm.Show();
        }
    }
}
