using System;
using System.Drawing;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game6 : Form
    {
        myBlock[,] block; //двумерный массив (блоков)
        public int direction; //переменная котой будем опеределять направление платформы
        double sx = 1, sy = 1, bx, by; 
        int countx, county; //переменные размера блока

        public Game6()
        {
            InitializeComponent();
            countx = 17; //размер блоков
            county = 10; //размер блоков
            int bw = 40, bh = 25; //размер блока
            int counter = 1; //переменная цвета
            block = new myBlock[countx,county];//инициализируем массив
            for (int x = 0; x < countx; x++) //цикл для задания параметров блокам
                for (int y = 0; y < county; y++) //цикл для задания параметров блокам
                {
                    block[x, y] = new myBlock(); //инициализируем каждый блок
                    block[x, y].Left = x * bw + (panel1.Width - bw * countx) / 2; //параметры блока //отступ слева = X * ширина блока (для отцентровки блоков прибавлем ширину панели и отнимаем ширину всех блоков)
                    block[x, y].Top = (y + 2) * bh; 
                    block[x, y].Width = bw - 2; // -2 = ширина между блоками
                    block[x, y].Height = bh - 2;
                    if (counter == 1) //присвание значения переменной
                        block[x, y].MyColor = Color.Red;  //присваивание цвета значению переменной
                    if (counter == 2)
                        block[x, y].MyColor = Color.Orange;
                    if (counter == 3)
                        block[x, y].MyColor = Color.Yellow;
                    if (counter == 4)
                        block[x, y].MyColor = Color.Green;
                    if (counter == 5)
                        block[x, y].MyColor = Color.LightBlue;
                    if (counter == 6)
                        block[x, y].MyColor = Color.Blue;
                    if (counter == 7)
                    {
                        block[x, y].MyColor = Color.Violet;
                        counter = 0; //при достижении последнего цвета начинаем задание цвета заного
                    }
                    counter++;
                }
            direction = 0; //платформа стоит ( -1 движение налево; +1 движение направо
            bx = pictureBox2.Left; //координты меча
            by = pictureBox2.Top; //координты меча
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < countx; x++) //делаем отрисовку всех наших блоков на панели
                for (int y = 0; y < county; y++)
                {
                  block[x,y].Draw(e.Graphics); //передаем обьект для рисования Graphics
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < countx; x++)
                for (int y = 0; y < county; y++)
                {
                    if (block[x, y].collision(pictureBox2.Left,pictureBox2.Top,pictureBox2.Width, pictureBox2.Height))
                    {
                        if (block[x, y].cl_type == "X") sx = -sx;
                        if (block[x, y].cl_type == "Y") sy = -sy;
                        panel1.Invalidate();
                        y = county;
                        x = countx;
                    }
                }


            pictureBox1.Left += direction; // движение при нажатии кнопки ( перемещает картинку по таймеру в соответствии с нажатой кнопкой )
            bx += sx; //промежуточные переменные куда будем записываить координаты меча
            by += sy;
            pictureBox2.Left = (int)bx; 
            pictureBox2.Top = (int)by;
            if (pictureBox1.Left < 0) //если картинка (платформа) находится на нулевой координате то останавливаем платформу (обратка выхода платфомы за пределы формы) //левый край формы
            {
                pictureBox1.Left = 0;
                direction = 0; //движение платформы = 0 (остановка)
            }

            if(pictureBox2.Top <= 0) 
            {
                sy = -sy;
                pictureBox2.Top += 5;
            }

            if ((pictureBox1.Left - pictureBox2.Width) < pictureBox2.Left && (pictureBox1.Left + pictureBox1.Width) > pictureBox2.Left && (pictureBox2.Top + pictureBox2.Height) >= 410) //столкновение с платформой
            {
                sy = -sy;
                pictureBox2.Top-= 5;
            }

                if (pictureBox2.Left > panel1.Width - pictureBox2.Width) //при столкновении с краем формы мяч движется в обратном направлении
            {
                sx = -sx;
            }

            if (pictureBox2.Left <= 0) 
            {
                sx = -sx;
            }

            if (pictureBox1.Left > panel1.Width-pictureBox1.Width) //правый край формы
            { 
                direction = 0;
            }

            if ( pictureBox2.Top >= 435) //выход за пределы формы
            {
                timer1.Stop();
                MessageBox.Show("Конец игры");
                Close();

                Game6 newForm = new Game6();
                newForm.Show();
            }
        }

        private void Game6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) //движение налево при нажатии кнопки
            {
                direction = -7;
            }

            if (e.KeyCode == Keys.Right) //движение направо при нажатии кнопки
            {
                direction = 7;
            }

            if (e.KeyCode == Keys.Down) //остановка движения
            {
                direction = 0;
            }

        }
    }

    class myBlock //обьявляем класс блоков
    {
        public int Top, Left, Width, Height; //координаты блоков
        public Color MyColor; //цвет блока
        public bool visible = true;
        public string cl_type;
        public void Draw(Graphics g) //метод Draw (отрисовка блоков)
        {
            if (!visible) return;
            SolidBrush b = new SolidBrush(MyColor); //для отрисовки используем кисть и в конструктор передаем цвет
            Pen p = new Pen(Color.Black); //отрисовка рамки ( карандаш черный)
            g.DrawRectangle(p,Left,Top,Width,Height); //отрисовка рамки ( передеам координаты)
            g.FillRectangle(b, Left, Top, Width, Height); //заливка блока
        }

        public bool collision(int xb, int yb, int w, int h)
        {
            if (!visible) return false;
            int xb1 = xb + w;
            int yb1 = yb + h;
            int x = Left;
            int y = Top;
            int x1 = x + Width;
            int y1 = y + Height;
            bool cl = false;
            if (xb1 >= x && xb1 <= x1 && ((y > yb && y < yb1) || (y1 > yb && y1 < yb1))) //столкновение справа
            {
                cl = true;
                cl_type = "X";
            }
            else if (xb >= x && xb <= x1 && ((y > yb && y < yb1) || (y1 > yb && y1 < yb1))) //столкновение слева
            {
                cl = true;
                cl_type = "X";
            }
            else if (yb >= y && yb <= y1 && ((x > xb && y < xb1) || (x1 > xb && x1 < xb1))) //столкновение сверху
            {
                cl = true;
                cl_type = "Y";
            }
            else if (yb1 >= y && yb1 <= y1 && ((x > xb && y < xb1) || (x1 > xb && x1 < xb1))) //столкновение снизу
            {
                cl = true;
                cl_type = "Y";
            }

            if (cl)
            {
                visible = false;
                return true;
            }
            return false;

        }

    }

}
