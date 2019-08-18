using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder sb;
        
        private Bitmap Captcha(int width, int height)
        {
                sb=new StringBuilder();
                Random random = new Random();
                Bitmap bitmap = new Bitmap(width, height);
                string alf = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int n = random.Next(3, 6);
                for (int i = 0; i<n; i++)
                    sb.Append(alf[random.Next(alf.Length)]);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.Aqua);
                g.SmoothingMode=SmoothingMode.None;
                g.RotateTransform(random.Next(-8, 8));
                g.DrawString(sb.ToString(), new Font("", height/2, FontStyle.Bold),
                    Brushes.Red, new RectangleF(0, 0, width, height));
                g.DrawLine(Pens.Black, new Point(0, 0), new Point(width-1, height-1));
                for (int i = 0; i<width; i++)
                    for (int j = 0; j<height; j++)
                        if (random.Next()%10==0)
                            bitmap.SetPixel(i, j, Color.White);
                return bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image=Captcha(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Captcha(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==sb.ToString())
                MessageBox.Show("Правильно");
            else MessageBox.Show("Не правильно");
        }
    }
}
