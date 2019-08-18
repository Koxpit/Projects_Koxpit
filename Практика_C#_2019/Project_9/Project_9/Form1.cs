using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_9
{
    class A
    {
        private float a=5,b=7;
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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A obj = new A();
            MessageBox.Show("Деление a на b равно "+obj.div.ToString()+Environment.NewLine+"Квадрат деления: "+obj.delSqr().ToString(), "Выражение 1");
            MessageBox.Show("Вычитание a из b равно "+obj.dec.ToString()+Environment.NewLine+"Квадрат вычитания: "+obj.decSqr().ToString(), "Выражение 2");
        }
    }
}
