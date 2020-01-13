using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlideShow
{
    public class PrintWork
    {
        private List<string> Imgs { get; set; }
        private int Current { get; set; }

        public PrintWork(List<string> Imgs, int Current)
        {
            this.Imgs = Imgs;
            this.Current = Current;
        }

        // Печать текущей картинки
        public void PrintImage(PrintDialog printDialog)
        {
            if (Imgs.Count != 0)
            {
                try
                {
                    System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
                    Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
                    DialogResult result = printDialog.ShowDialog();
                    if (result == DialogResult.OK)
                        Document.Print();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Добавьте изображение!");
        }

        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Imgs[Current]), e.PageBounds);
        }
    }
}
