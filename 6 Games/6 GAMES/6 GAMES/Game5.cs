using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game5 : Form
    {
        int sleep = 0; //переменная сна 
        public Game5()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            
        }

        private void eat_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = imageList1.Images[3];
                progressBar1.Value -= 50;
            }
            catch
            {
                progressBar1.Value = 0;
            }
        }

        private void slep_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[8];
            sleep = 1;
        }

        private void game_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value < progressBar3.Maximum-50)
            {
                pictureBox1.Image = imageList1.Images[1];
                progressBar3.Value += 50;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {


            progressBar1.Value++;

            try
            {
                if (sleep == 1)
                    progressBar2.Value -= 10;
                else
                    progressBar2.Value++;
            }
            catch
            {
                sleep = 0;
                pictureBox1.Image = imageList1.Images[0];
            }
            




            progressBar3.Value--;
        }

        private void no_slep_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
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
