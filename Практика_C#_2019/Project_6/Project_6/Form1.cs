using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_6
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random rand = new Random();
            double[] array = new double[n];
            int min = Convert.ToInt32(textBox4.Text);
            int max = Convert.ToInt32(textBox5.Text);
            double sum = 0.0;
            double mul = 1.0;

            if (min<max)
            {
                for (int i = 0; i<array.Length; i++)
                {
                    array[i]=rand.Next(min, max);
                    listBox1.Items.Add(array[i] + Environment.NewLine);
                }
            } else
            {
                MessageBox.Show("Ошибка. Минимальное значение больше максимального.");
                Close();
            }
            Array.Sort(array);

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]<0) sum+=array[i];
                if((array[i]==min)||(array[i]==max))
                {
                    continue;
                } else
                {
                    mul=mul*array[i];
                }
                listBox2.Items.Add(array[i]+Environment.NewLine);
            }
            textBox2.Text=sum.ToString();
            textBox3.Text=mul.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
