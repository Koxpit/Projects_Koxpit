using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10
{

    class A
    {
        public float a, b;

        public A(float x,float y)
        {
            a=x;
            b=y;
        }

        public A()
        {
            a=4;
            b=2;
        }

        public float div { get { return a/b; } set { a=value; b=value; } }
        public float dec { get { return a-b; } set { a=value; b=value; } }

        public float divSqr()
        {
            return div*div;
        }

        public float decSqr()
        {
            return dec*dec;
        }
    }

    class B:A
    {
        public float g;

        public B(float z, float x, float y):base(x,y)
        {
            g=z;
        }

        public float m { get { return a/b/g; } set { if ((a!=0)&&(b!=0)&&(g!=0)) { a=value; b=value; g=value; } else { MessageBox.Show("Ошибка: деление на 0."); } } }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A obj1 = new A(5, 7);
            B obj2 = new B(3, 7, 2);
            A obj3=new A();


            MessageBox.Show(obj1.a+"/"+obj2.b+"="+obj1.div.ToString()+Environment.NewLine+"Квадрат деления: "+obj1.divSqr(), "Divide");
            MessageBox.Show(obj1.a+"-"+obj2.b+"="+obj1.dec.ToString()+Environment.NewLine+"Квадрат разности: "+obj1.decSqr(), "Decrement");

            MessageBox.Show(obj2.a+"/"+obj2.b+"/"+obj2.g+"="+obj2.m, "Divide x2");
            MessageBox.Show(obj3.a+"/"+obj3.b+"="+obj3.div+Environment.NewLine+obj3.div+"*"+obj3.div+"="+obj3.divSqr()+
                Environment.NewLine+obj3.a+"-"+obj3.b+"="+obj3.dec+Environment.NewLine+obj3.dec+"*"+obj3.dec+"="+obj3.decSqr());
        }
    }
}
