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

namespace Project_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"F:\src\Project_7\File.txt";
            StreamReader st = new StreamReader(path, Encoding.Default);
            string s = "", str = "", str2="",str3="";
            while ((s=st.ReadLine())!=null)
            {
                str+=s;
            }
            st.Close();
            string[] split = str.Split('.', '!', '?');
            for (int i = 0; i<3; ++i)
            {
                str2+=".";
                string[] split2 = split[i].Split();
                for (int j = split2.Length-1; j>=0; --j)
                    str2+=split2[j]+" ";
            }
            textBox1.Text=str2;
        }
    }
}
