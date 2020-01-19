using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calculator_Pay
{
    public class PrintWork
    {
        private string CurrentPrint { get; set; }

        public PrintWork(string print)
        {
            CurrentPrint = print;
        }

        public void PrintToDocument()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(CurrentPrint, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
