using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripStatusLabel toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel1.BorderSides = ((ToolStripStatusLabelBorderSides)((((ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top)
                        | ToolStripStatusLabelBorderSides.Right)
                        | ToolStripStatusLabelBorderSides.Bottom)));
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Raised;
            toolStripStatusLabel1.IsLink = true;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(246, 20);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Alignment = ToolStripItemAlignment.Left;

            Text="VSTEdit - Новый документ";

            toolStripButton2.Checked = true;
            toolStripButton3.Checked = true;

            helpProvider1.HelpNamespace="vst_edit.chm";

            openFileDialog1.DefaultExt="txt";
            openFileDialog1.Filter="текстовый документ|*.txt";
            openFileDialog1.Title="Открыть документ";
            openFileDialog1.Multiselect=false;

            saveFileDialog1.DefaultExt="txt";
            saveFileDialog1.Filter="текстовый документ|*.txt";
            saveFileDialog1.Title="Сохранить документ";
        }

        private string fn = string.Empty;

        private void OpenDocument()
        {
            openFileDialog1.FileName=string.Empty;

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                fn=openFileDialog1.FileName;
                Text=fn;
                try
                {
                    StreamReader sr = new StreamReader(fn);
                    textBox1.Text=sr.ReadToEnd();
                    textBox1.SelectionStart=textBox1.TextLength;
                    sr.Close();
                } catch(Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла.\n"+
                        exc.ToString(), "VSTEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveDocument()
        {
            if(fn==string.Empty)
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    fn=saveFileDialog1.FileName;
                    Text=fn;
                }

            if(fn!=string.Empty)
                try
                {
                    FileInfo fi = new FileInfo(fn);

                    StreamWriter sw = fi.CreateText();

                    sw.Write(textBox1.Text);

                    sw.Close();
                } catch(Exception exc)
                {
                    MessageBox.Show("Ошибка доступа к файлу.\n"+
                        exc.ToString(), "MEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle r;

            r=new Rectangle(10, 10, textBox1.Width, textBox1.Height);

            if (r.Height+20>e.PageBounds.Height)
                r.Height=e.PageBounds.Height-20;
            if (r.Width+20>e.PageBounds.Width)
                r.Width=e.PageBounds.Width-20;

            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, r);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(toolStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0:
                    fn=string.Empty;
                    textBox1.Text=string.Empty;
                    Text="MEdit - Новый документ";
                    break;
                case 1:
                    OpenDocument();
                    break;
                case 2:
                    SaveDocument();
                    break;
                case 3:
                    printDocument1.Print();
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void выбратьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !toolStrip1.Visible;
            строкаСостоянияToolStripMenuItem.Checked = !строкаСостоянияToolStripMenuItem.Checked;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простой редактор текста. Создан в Visual Studio 2017 for the Microsoft .Net Framework",
                "О программе", MessageBoxButtons.OK);
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = string.Empty;
            textBox1.Text = "";
            Text = "VSTEdit - новый документ";
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void скрытьПанельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Панель инструментов скрыта";
            toolStrip1.Visible = false;
        }

        private void отобразитьПанельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Панель инструментов отображена";
            toolStrip1.Visible = true;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void выбратьШрифтToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбрать шрифт";
        }

        private void новыйToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Создать новый документ";
        }

        private void открытьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Открыть существующий документ";
        }

        private void сохранитьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сохранить набранный(отредактированный) документ";
        }

        private void печатьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Распечатать документ";
        }

        private void выходToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Завершить работу";
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void параметрыToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void скрытьСтрокуСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            скрытьПанельИнструментовToolStripMenuItem.Checked = false;
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void отобразитьСтрокуСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            отобразитьПанельИнструментовToolStripMenuItem.Visible = true;
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void справкаToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Справка";
        }

        private void оПрограммеToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "О программе";
        }
    }
}
