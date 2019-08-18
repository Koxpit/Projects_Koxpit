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

namespace Project_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int x, y;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pr = new Pen(Color.Red, 2);

            pr.DashStyle=DashStyle.Dash;
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.DarkBlue, 0, 0, 1000, 100);
            g.DrawLine(Pens.Black, 0, 300, 1000, 300);
            g.FillRectangle(Brushes.Green, 0, 300, 1000, 300);
            g.FillRectangle(Brushes.LightBlue, 0, 100, 1000, 200);
            g.DrawRectangle(Pens.Black, 200, 200-y, 50, 100);
            g.FillRectangle(Brushes.Gray, 200, 200-y, 50, 100);
            Point p1 = new Point(200, 200-y);
            Point p2 = new Point(225, 175-y);
            Point p3 = new Point(250, 200-y);
            Point[] p = { p1, p2, p3 };
            g.FillPolygon(Brushes.Black, p);

            g.DrawRectangle(Pens.Black, 175, 275-y, 25, 40);
            g.FillRectangle(Brushes.DarkGray, 175, 275-y, 25, 40);

            g.DrawRectangle(Pens.Black, 250, 275-y, 25, 40);
            g.FillRectangle(Brushes.DarkGray, 250, 275-y, 25, 40);

            g.FillRectangle(Brushes.Red, 175, 315-y, 25, 0+y);
            g.FillRectangle(Brushes.Red, 250, 315-y, 25, 0+y);
            g.FillRectangle(Brushes.Yellow, 200, 300-y, 50, 0+y);
            g.DrawString("Корабль 'Восток'", Font = new Font("Arial",16, FontStyle.Bold|FontStyle.Underline), Brushes.Gray, 400, 100);
            g.DrawString("Экипаж: Юрий Алексеевич Гагарин", DefaultFont, Brushes.Gray, 400, 130);
            g.DrawString("Дата взлета: 12 апреля, 1961 год", DefaultFont, Brushes.Gray, 400, 150);
            g.DrawString("Страна: СССР", DefaultFont, Brushes.Gray, 400, 170);
            g.DrawString("Время полета: 1 час 48 минут", DefaultFont, Brushes.Gray, 400, 190);
            g.DrawLine(pr, 25, 405, 190, 405);
            g.DrawLine(pr, 25, 405, 25, 360);
            g.DrawLine(pr, 25, 360, 190, 360);
            g.DrawLine(pr, 190, 405, 190, 360);
            pr=new Pen(Color.Brown, 2);
            pr.DashStyle=DashStyle.DashDot;
            g.DrawEllipse(pr, 10, 190, 100, 100);
            g.DrawArc(pr, 40, 100, 100, 100, 80, 90);
            g.FillPie(Brushes.BlueViolet, 10, 10, 40, 60, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y+=5;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
