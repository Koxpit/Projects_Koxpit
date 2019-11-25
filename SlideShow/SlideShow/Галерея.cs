using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Галерея : Form
    {
        public Галерея()
        {
            InitializeComponent();
        }

        private string dirName;
        private int current = 0;
        public string DirName { get { return dirName; } set { dirName=value; } }

        private List<string> imgs = new List<string>();
        public List<string> Imgs { get { return imgs; } set { imgs=value; } }

        // Загружает выбранной картинки listbox в picturebox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                current=listBox1.SelectedIndex;
                pictureBox1.ImageLocation = dirName+@"\"+listBox1.SelectedItem.ToString();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Листает к предыдущему изображению
        private void PreviousImage_Click(object sender, EventArgs e)
        {
            if (imgs.Count!=0)
            {
                try
                {
                    int current = listBox1.SelectedIndex;
                    if (current-1 >= 0)
                    {
                        current--;
                        listBox1.SelectedItem = listBox1.Items[current];
                    }
                    else { current = imgs.Count-1; listBox1.SelectedItem=listBox1.Items[current]; }
                    pictureBox1.ImageLocation = dirName+@"\"+listBox1.SelectedItem.ToString();
                } catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // Листает к следующему изображению
        private void NextImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgs.Count!=0)
                {
                    int current = listBox1.SelectedIndex;
                    if (current+1 < listBox1.Items.Count)
                    {
                        current++;
                        listBox1.SelectedItem = listBox1.Items[current];
                    }
                    else { current=0; listBox1.SelectedItem=listBox1.Items[current]; }
                    pictureBox1.ImageLocation = dirName+@"\"+listBox1.SelectedItem.ToString();
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        // Печать текущей картинки
        public void Print()
        {
            if (imgs.Count!=0)
            {
                try
                {
                    System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
                    Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
                    DialogResult result = printDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Document.Print();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Добавьте изображение!");
        }
        void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(imgs[current]), e.PageBounds); //Картинка на печать
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Галерея_Load(object sender, EventArgs e)
        {
            
        }
    }
}
