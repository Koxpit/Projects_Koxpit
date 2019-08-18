using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_13
{
    public partial class Form1 : Form
    {
        Label lb1 = new Label();
        Label lb2 = new Label();
        Label lb3 = new Label();
        Label lb4 = new Label();
        TextBox tb1 = new TextBox();
        TextBox tb2 = new TextBox();
        TextBox tb3 = new TextBox();
        PictureBox pb = new PictureBox();
        ListBox lb = new ListBox();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.Parent=this;
            lb1.Text="Фамилия";
            lb1.Location=new Point(10, 20);

            lb2.Parent=this;
            lb2.Text="Имя";
            lb2.Location=new Point(10, 60);

            lb3.Parent=this;
            lb3.Text="Отчество";
            lb3.Location=new Point(10, 100);

            lb4.Parent=this;
            lb4.Text="Фото";
            lb4.Location=new Point(10, 250);

            tb1.Parent=this;
            tb1.Size=new Size(100, 20);
            tb1.Location=new Point(110, 20);

            tb2.Parent=this;
            tb2.Size=new Size(100, 20);
            tb2.Location=new Point(110, 60);

            tb3.Parent=this;
            tb3.Size=new Size(100, 20);
            tb3.Location=new Point(110, 100);

            lb.Parent=this;
            lb.Size=new Size(200, 150);
            lb.Location=new Point(350, 20);

            pb.Parent=this;
            pb.Size=new Size(150, 150);
            pb.Location=new Point(120, 200);
            pb.BackColor=Color.Black;

            btn1.Parent=this;
            btn1.Size=new Size(140, 20);
            btn1.Text="Загрузить фото";
            btn1.Location=new Point(120, 375);

            btn2.Parent=this;
            btn2.Size=new Size(140, 20);
            btn2.Text="Добавить в список";
            btn2.Location=new Point(300, 250);

            btn3.Parent=this;
            btn3.Size=new Size(140, 20);
            btn3.Text="Удалить из списка";
            btn3.Location=new Point(450, 250);

            btn1.Click+=new EventHandler(btn1_Click);
            btn2.Click+=new EventHandler(btn2_Click);
            btn3.Click+=new EventHandler(btn3_Click);

            openFileDialog1.Filter="Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
        }

        private void btn1_Click(object Sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.Cancel) return;
            Bitmap image = new Bitmap(openFileDialog1.FileName);
            pb.SizeMode=PictureBoxSizeMode.StretchImage;
            pb.Image=image;
            pb.Invalidate();
        }

        private void btn2_Click(object Sender, EventArgs e)
        {
            lb.Items.Add(tb1.Text+" "+tb2.Text+" "+tb3.Text);
        }

        private void btn3_Click(object Sender, EventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem);
        }
    }
}
