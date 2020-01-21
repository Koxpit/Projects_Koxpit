using System;
using System.Drawing;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game1 : Form
    {
        private int lenWorm = 5; // длина червя
        Point[] worm = new Point[200];
        Point apple; //точка яблока (создание "Яблока")
        DIRECTOIN direct = DIRECTOIN.UP; //движется вверх сначала

        public Game1()
        {
            InitializeComponent();
            SetStartLocationWorm();
            SetStartLocationApple();
        }

        private void SetStartLocationWorm()
        {
            for (int i = 0; i < 5; i++)
            {
                worm[i].X = 100;
                worm[i].Y = 100 + i * 10; //размещение червя вертикально
            }
        }

        private void SetStartLocationApple()
        {
            apple.X = 10;
            apple.Y = 10;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 198; i >= 0; i--) //перемещение червя (перемещаем в конец массива все элементы червя)
            {
                worm[i + 1].X = worm[i].X;
                worm[i + 1].Y = worm[i].Y;
            }
            HandlePressKey();
            SolidBrush colorWorm = new SolidBrush(Color.Green);
            SolidBrush colorApple = new SolidBrush(Color.Red);
            for (int i = 0; i < lenWorm; i++) // отрисовка червя
            {
                try
                {
                    DrawWorm(e, colorWorm, i);
                    DrawApple(e, colorApple, i);
                    if (WormIsMetApple())
                        WormEatApple();
                }
                catch
                {
                    Close();
                }
            }
        }

        private void HandlePressKey()
        {
            if (direct == DIRECTOIN.LEFT)
            {
                worm[0].X = worm[1].X - 10;
                CloseIfWormOutsideForm(direct);
                worm[0].Y = worm[1].Y;
            }
            if (direct == DIRECTOIN.RIGTH)
            {
                worm[0].X = worm[1].X + 10;
                CloseIfWormOutsideForm(direct);
                worm[0].Y = worm[1].Y;
            }
            if (direct == DIRECTOIN.UP)
            {
                worm[0].X = worm[1].X;
                worm[0].Y = worm[1].Y - 10;
                CloseIfWormOutsideForm(direct);
            }
            if (direct == DIRECTOIN.DOWN)
            {
                worm[0].X = worm[1].X;
                worm[0].Y = worm[1].Y + 10;
                CloseIfWormOutsideForm(direct);
            }
        }

        private void DrawWorm(PaintEventArgs e, SolidBrush colorWorm, int i)
        {
            e.Graphics.FillEllipse(colorWorm, worm[i].X, worm[i].Y, 10, 10);
        }

        private void DrawApple(PaintEventArgs e, SolidBrush colorApple, int i)
        {
            e.Graphics.FillEllipse(colorApple, apple.X, apple.Y, 10, 10);
        }

        private bool WormIsMetApple()
        {
            return (worm[0].X == apple.X) && (worm[0].Y == apple.Y);
        }

        private void WormEatApple()
        {
            IncLengthWorm();
            Random R = new Random();
            apple.X = R.Next(0, 50) * 10; //(игровое поле 50 ячеек) 10 - ширина каждой ячейки в пиксилях
            apple.Y = R.Next(0, 50) * 10;
        }

        private void IncLengthWorm()
        {
            lenWorm++;
        }

        private void CloseIfWormOutsideForm(DIRECTOIN direct)
        {
            if (WormIsOutsideForm(direct))
                CloseGame();
        }

        private bool WormIsOutsideForm(DIRECTOIN direct)
        {
            switch(direct)
            {
                case DIRECTOIN.LEFT:
                    return worm[0].X < 0;
                case DIRECTOIN.RIGTH:
                    return worm[0].X > 490;
                case DIRECTOIN.UP:
                    return worm[0].Y < 0;
                case DIRECTOIN.DOWN:
                    return worm[0].Y > 490;
            }
            return true;
        }

        private void CloseGame()
        {
            timer1.Stop();
            Close();
            MessageBox.Show("Конец игры");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate(); //перерисовка формы
        }

        private void Game1_KeyDown(object sender, KeyEventArgs e) //уравление  червём
        {
            SetCurrentDirect(e);
        }

        private void SetCurrentDirect(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                direct = DIRECTOIN.LEFT;
            if (e.KeyCode == Keys.Right)
                direct = DIRECTOIN.RIGTH;
            if (e.KeyCode == Keys.Up)
                direct = DIRECTOIN.UP;
            if (e.KeyCode == Keys.Down)
                direct = DIRECTOIN.DOWN;
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void скоростьЧервяУльтраМедленнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 850;
        }

        private void скоростьЧервяМинимальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void скоростьЧервяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 250;
        }

        private void скоростьЧервяНормальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
        }

        private void скоростьЧервяБыстраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void скоростьЧервяОченьБыстраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void скоростьЧервяУльтраБыстраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 25;
        }
    }

    public enum DIRECTOIN
    {
        UP, DOWN, LEFT, RIGTH
    }
}
