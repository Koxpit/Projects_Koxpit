using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Показ_слайдов : Form
    {
        public Показ_слайдов()
        {
            InitializeComponent();

        }

        public bool around = false;
        private int current;
        public int Current { get { return current; } set { current=value; } }
        private int interval;
        public int Interval { get { return current; } set { interval=value; } }

        private List<string> img = new List<string>();
        public List<string> Img { get { return img; } set { img = value; } }

        // Загружает картинку на весь экран
        private void Показ_слайдов_Load(object sender, EventArgs e)
        {
            Size s = Screen.PrimaryScreen.Bounds.Size;
            this.Size=s;
            pictureBox1.Size=s;

            if (img.Count!=0)
            {
                timer1.Interval=interval*1000;
                timer1.Start();
            }
            else MessageBox.Show("Изображений нет!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        // Листает к следующему изображению
        private void NextImage()
        {
            if (img.Count!=0)
            {
                try
                {
                    if (current+1 < img.Count)
                    {
                        current+=1;
                        pictureBox1.ImageLocation=img[current];
                    }
                    else if (around==true)
                    {
                        current=0;
                        pictureBox1.ImageLocation=img[current];
                    }
                    else timer1.Stop();
                } catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
