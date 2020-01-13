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

        private void Показ_слайдов_Load(object sender, EventArgs e)
        {
            SetSliderSize();

            if (img.Count != 0)
            {
                timer.Interval = interval * 1000;
                timer.Start();
            }
            else MessageBox.Show("Изображений нет!");
        }

        // Загружает картинку на весь экран
        private void SetSliderSize()
        {
            Size s = Screen.PrimaryScreen.Bounds.Size;
            Size = s;
            pictureBoxAllScreen.Size = s;
        }

        // Листает к следующему изображению
        private void timer_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        private void NextImage()
        {
            try
            {
                if (img.Count!=0)
                {
                    if (current + 1 < img.Count)
                    {
                        current += 1;
                        pictureBoxAllScreen.ImageLocation = img[current];
                    }
                    else if (around==true)
                    {
                        current=0;
                        pictureBoxAllScreen.ImageLocation = img[current];
                    }
                    else timer.Stop();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
