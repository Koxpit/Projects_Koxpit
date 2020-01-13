using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Галерея : Form
    {
        public Галерея()
        {
            InitializeComponent();
        }

        private int current = 0;
        private string dirName;
        public string DirName { get { return dirName; } set { dirName=value; } }

        private List<string> imgs = new List<string>();
        public List<string> Imgs { get { return imgs; } set { imgs=value; } }

        // Загружает выбранную картинку listbox в picturebox
        private void listBoxGallery_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                current = listBoxGallery.SelectedIndex;
                pictureBoxGallery.ImageLocation = dirName + @"\" + listBoxGallery.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Листает к предыдущему изображению
        private void PreviousImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgs.Count != 0)
                {
                    CurrentPrev();
                    listBoxGallery.SelectedItem = listBoxGallery.Items[current];
                    pictureBoxGallery.ImageLocation = dirName+@"\"+listBoxGallery.SelectedItem.ToString();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CurrentPrev()
        {
            current = listBoxGallery.SelectedIndex;
            if (current-1 >= 0)
                current--;
            else
                current = imgs.Count - 1;
        }

        // Листает к следующему изображению
        private void NextImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgs.Count != 0)
                {
                    CurrentNext();
                    listBoxGallery.SelectedItem = listBoxGallery.Items[current];
                    pictureBoxGallery.ImageLocation = dirName+@"\" + listBoxGallery.SelectedItem.ToString();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CurrentNext()
        {
            current = listBoxGallery.SelectedIndex;
            if (current + 1 < listBoxGallery.Items.Count)
                current++;
            else
                current = 0;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Печать текущей картинки
        private async void печатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintWork printWork = new PrintWork(Imgs, current);
            await System.Threading.Tasks.Task.Run(() => printWork.PrintImage(printDialogGallery));
        }
    }
}
