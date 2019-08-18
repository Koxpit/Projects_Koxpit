using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12
{
    public partial class Form1 : Form
    {
        public delegate float Operation();

        public Form1()
        {
            InitializeComponent();
        }

        class A
        {
            private float a = 5, b = 7;
            public float div { get { return a/b; } set { a=value; b=value; } }
            public float dec { get { return a-b; } set { a=value; b=value; } }

            public float delSqr()
            {
                return div*div;
            }

            public float decSqr()
            {
                return dec*dec;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A obj = new A();
            Operation result1 = obj.delSqr;
            float del = result1();
            MessageBox.Show("Деление a на b равно "+obj.div.ToString()+Environment.NewLine+"Квадрат деления: "+del, "Выражение 1");
            Operation result2 = obj.decSqr;
            float dec = result2();
            MessageBox.Show("Вычитание a из b равно "+obj.dec.ToString()+Environment.NewLine+"Квадрат вычитания: "+dec, "Выражение 2");
            Operation result3 = result1+result2;
            MessageBox.Show(result3().ToString(), "Вызов объединенного делегата");
        }
    }
}
