using System;
using System.Drawing;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Game3 : Form
    {

        Button[] B; //масси кнопок

        public Game3()
        {
            InitializeComponent();

            B = new Button[16]; //инициализация массива кнопок
            B[0] = button1;
            B[1] = button2; 
            B[2] = button3;
            B[3] = button4;
            B[4] = button5;
            B[5] = button6;
            B[6] = button7;
            B[7] = button8;
            B[8] = button9;
            B[9] = button10;
            B[10] = button11;
            B[11] = button12;
            B[12] = button13;
            B[13] = button14;
            B[14] = button15;
            B[15] = button16;

            panel1_Resize(null, null); //размещаем кнопки при запуске программы 
        }

        private void panel1_Resize(object sender, EventArgs e) //при изменении размеров панели все кнопки автоматически будут растянуты на всю панель
        {
            for (int i = 0; i < 16; i++) //цикл размещения кнопок // i-номер кнопки
            {
                int x, y;
                y = i / 4; // номер строки
                x = i - y * 4; // номер столбца
                B[i].Top = y * panel1.Height / 4;
                B[i].Left = x * panel1.Width / 4;
                B[i].Width = panel1.Width / 4;
                B[i].Height = panel1.Height / 4;
                try
                {
                    B[i].Font = new Font("Algerian", panel1.Height / 10, FontStyle.Bold);
                }
                catch
                {
                    this.Width = 646;
                    this.Height = 433;
                    InitializeComponent();

                    Close();
                    Game3 newForm = new Game3();
                    newForm.Show();

                    MessageBox.Show("Игровое поле не может быть такого размера");
                }
            }
        }


        private void button16_Click_1(object sender, EventArgs e)
        {
           try
           {
                Button bclick = (Button)sender; //кнопка по которую мы нажали 
                int n = (int)Convert.ToInt64(bclick.Tag.ToString()); //определяем номер кнопки (тег) по которой нажали и преобразуем в integer // в "n" хранится номер кнопки
                n--; //получаем индекс в массиве (т.к. индекс в массиве на один меньше номера кнопки)(по этому уменьшаем на один)
                int y = n / 4; //позиция кнопки на игровом поле
                int x = n - y * 4;
                int yt, yb; //кнопка сверху (Top (yt)) кнопка снизу (Bottom (yb))
                int xl, xr; //кнопка слева (xl) и кнопка справа (xr)
                yt = y - 1; //кнопка сверху  ( (-1) т.к. ось Y напраленна вниз на компьтерах
                yb = y + 1; //кнопка снизу
                xl = x - 1; //кнопка слева
                xr = x + 1; //кнопка справа
                if (xr < 4) //обработчик правой кнопки ... меньше 4 ( 0, 1, 2, 3) в этих случаях кнопка существует
                {
                    int nr = y * 4 + xr; //получаем номер кнопки 
                    if (!B[nr].Visible) //если она нивидима (! = не) заначит с ней помжно поменяться (текстом кнопки) //движение вправо
                    {
                        B[nr].Visible = true; //делаем видимой кнопку с которой поменялись
                        B[n].Visible = false; //делам невидимой кнопку которую нажали
                        B[nr].Text = B[n].Text; //переносим текст из кнопки на которую нажали в ту которая невидимая ( из n в nr )
                    }
                }

                if (xl >= 0)
                {
                    int nl = y * 4 + xl;
                    if (!B[nl].Visible) //движение влево
                    {
                        B[nl].Visible = true;
                        B[n].Visible = false;
                        B[nl].Text = B[n].Text;
                    }
                }

                if (yt >= 0)
                {
                    int nt = yt * 4 + x;
                    if (!B[nt].Visible) //движение вверх
                    {
                        B[nt].Visible = true;
                        B[n].Visible = false;
                        B[nt].Text = B[n].Text;
                    }
                }

                if (yb < 4)
                {
                    int nb = yb * 4 + x;
                    if (!B[nb].Visible) //движение вниз
                    {
                        B[nb].Visible = true;
                        B[n].Visible = false;
                        B[nb].Text = B[n].Text;
                    }
                }
            }
           catch
           {

           }
        }
    }
}
