using System;
using System.Drawing;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game2 : Form
    {
        Bitmap frame;
        Plane plane;
        Сoin[] coin;

        public Game2()
        {
            InitializeComponent();

            Cursor.Hide();
            coins.BackColor = Color.Transparent; //прозрачный фон чтобы монетки были круглыми
            frame = new Bitmap(phon.Width, phon.Height);
            coin = new Сoin[15];
            CreatePlane(new Random());
            CreateMoneys(new Random());
        }

        private void CreatePlane(Random random)
        {
            plane = new Plane(MainPanel.Width, MainPanel.Height, random);
        }

        private void CreateMoneys(Random random)
        {
            for (int i = 0; i < 15; i++)
                coin[i] = new Сoin(MainPanel.Width, MainPanel.Height, random);
        }


        int left;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetOrNotResetImage();
            Graphics g = Graphics.FromImage(frame);
            g.DrawImage(phon.Image, left, 0, phon.Width, phon.Height);
            MovingBackground(g);

            // Отрисовка монет
            for (int i = 0; i < 15; i++)
            {
                frame = coin[i].Draw(coins, frame);
                if (CoinIsFacedWithPlane(i)) 
                    coin[i].x = MainPanel.Width;
            }
            plane.Draw(fly, frame);
            MainPanel.Image = frame;
        }

        private void ResetOrNotResetImage()
        {
            left--;
            if (left < -phon.Width)
                left = 0;
        }

        private void MovingBackground(Graphics g)
        {
            g.DrawImage(phon.Image, left + phon.Width, 0, phon.Width, phon.Height);
        }

        private bool CoinIsFacedWithPlane(int i)
        {
            if (((coin[i].y > plane.y && coin[i].y < plane.y + 200
                    && (coin[i].x == plane.x + 169 || coin[i].x == plane.x + 170
                    || coin[i].x == plane.x + 171 || coin[i].x == plane.x + 172
                    || coin[i].x == plane.x + 173)))
                    || (coin[i].x == 0))
                return true;
            return false;
        }
        
        class Сoin
        {
            public int x, y;
            int frameCoin = 0, trottle = 0;

            public Сoin(int width, int height, Random rand)
            {
                frameCoin = rand.Next(0, 6); // 6 - 6 кадров монеток
                x = rand.Next(0, width - 240) + 200;
                y = rand.Next(0, height - 80) + 40;
            }

            public Bitmap Draw(PictureBox coin, Bitmap frame) // вращение монеток
            {
                Bitmap coinImage = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(coinImage);
                Graphics g1 = Graphics.FromImage(frame);
                g.DrawImage(coin.Image, -frameCoin * 40, 0, 240, 40);
                g1.DrawImage(coinImage, x, y, 40, 40);
                MoveCoins();
                ChangeFrameCoin(ref trottle);
                return frame;
            }

            private void MoveCoins()
            {
                x--;
            }

            private void ChangeFrameCoin(ref int trottle)
            {
                trottle++;
                if (trottle == 4)
                {
                    trottle = 0;
                    frameCoin++;
                }
                if (frameCoin == 6)
                    frameCoin = 0;
            }
        }

        class Plane
        {
            public int x, y;
            int framePlane = 0;

            public Plane(int w, int h, Random rand)
            {
                framePlane = rand.Next(0, 1);
                x = 0;
                y = 100;
            }

            public Bitmap Draw(PictureBox hero, Bitmap frame)
            {
                Bitmap planeImage = new Bitmap(365, 270);
                Graphics g = Graphics.FromImage(planeImage);
                Graphics g1 = Graphics.FromImage(frame);
                g.DrawImage(hero.Image, -framePlane * (365 - 3), 0, 365, 270);
                g1.DrawImage(planeImage, x, y, 200, 200);
                MovePlane();
                return frame;
            }

            private void MovePlane()
            {
                x--;
            }
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            plane.y = e.Y;
            plane.x = e.X;
        }
    }
}
