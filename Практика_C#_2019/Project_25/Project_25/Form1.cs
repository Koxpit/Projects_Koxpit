using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_25
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        class Dat
        {
            int day, month, year;

            public Dat(int Month, int Day, int Year)
            {
                month = Month;
                day = Day;
                year = Year;
            }

            public int mon()
            {
                return month;
            }
            public int da()
            {
                return day;
            }
            public int yer() {
                return year;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo path = new DirectoryInfo(textBox1.Text);
                FileInfo[] files = null;

                if (radioButton1.Checked)
                    files=path.GetFiles("*.jpg");
                else if (radioButton2.Checked)
                    files=path.GetFiles("*.png");
                else
                {
                    MessageBox.Show("Выберите формат");
                    return;
                }

                for(int i = 0; i < files.Length; i++)
                    for(int j = i+1; j < files.Length; j++)
                        if (files[i].Name==files[j].Name||files[i].Length==files[j].Length)
                            files[j].Delete();

                MessageBox.Show("Удаление дублирующихся файлов закончено");
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MM/dd";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Dat d = new Dat(dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker1.Value.Year);
                string month=""; string dat;
                string[] nmonth = new string[10];
                FileInfo[] files=null;

                string path = textBox1.Text;
                DirectoryInfo di = new DirectoryInfo(path);

                if (radioButton1.Checked)
                    files=di.GetFiles("*.jpg");
                else if (radioButton2.Checked)
                    files=di.GetFiles("*.png");
                else
                {
                    MessageBox.Show("Выберите формат");
                    return;
                }

                if (dateTimePicker1.Value.Month < 10)
                        dat = d.da().ToString() + "." + "0"+dateTimePicker1.Value.Month + "." + d.yer().ToString();
                else dat = d.da().ToString() + "." + dateTimePicker1.Value.Month + "." + d.yer().ToString();

                switch (dateTimePicker1.Value.Month)
                {
                    case 9:
                        month = "сентября";
                        break;
                    case 10:
                        month = "октября";
                        break;
                    case 11:
                        month = "ноября";
                        break;
                    case 12:
                        month = "декабря";
                        break;
                    case 1:
                        month = "января";
                        break;
                    case 2:
                        month = "февраля";
                        break;
                    case 3:
                        month = "марта";
                        break;
                    case 4:
                        month = "апреля";
                        break;
                    case 5:
                        month = "мая";
                        break;
                    case 6:
                        month = "июня";
                        break;
                    case 7:
                        month = "июля";
                        break;
                    case 8:
                        month = "августа";
                        break;
                }

                string newDirect = "";
                for (int i = 0; i < files.Length; i++)
                    if (dat == files[i].CreationTime.ToShortDateString())
                        if (path==@"C:\"||path==@"F:\"||path==@"D:\"||path==@"E:\")
                        {
                            if (Directory.Exists(path+month))
                            {
                                newDirect=path+month;
                                di=new DirectoryInfo(newDirect);
                                di.CreateSubdirectory(d.da().ToString());
                                files[i].MoveTo(newDirect+@"\"+d.da().ToString()+@"\"+files[i].Name);
                                MessageBox.Show("Сортировка закончена");
                            }
                            else
                            {
                                di.CreateSubdirectory(month);
                                newDirect=path+month;
                                di=new DirectoryInfo(newDirect);
                                di.CreateSubdirectory(d.da().ToString());
                                files[i].MoveTo(newDirect+@"\"+d.da().ToString()+@"\"+files[i].Name);
                                MessageBox.Show("Сортировка закончена");
                            }
                        }
                        else
                        {
                            if (Directory.Exists(path+@"\"+month))
                            {
                                newDirect=path+@"\"+month;
                                di=new DirectoryInfo(newDirect);
                                di.CreateSubdirectory(d.da().ToString());
                                files[i].MoveTo(newDirect+@"\"+d.da().ToString()+@"\"+files[i].Name);
                                MessageBox.Show("Сортировка закончена");
                            }
                            else
                            {
                                di.CreateSubdirectory(month);
                                newDirect=path+@"\"+month;
                                di=new DirectoryInfo(newDirect);
                                di.CreateSubdirectory(d.da().ToString());
                                files[i].MoveTo(newDirect+@"\"+d.da().ToString()+@"\"+files[i].Name);
                                MessageBox.Show("Сортировка закончена");
                            }
                        }
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }

    public static class FilesExtens
    {
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
        {
            if (extensions==null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }
    }
}
