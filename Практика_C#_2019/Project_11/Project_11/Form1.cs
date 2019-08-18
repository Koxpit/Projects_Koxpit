using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_11
{
    public partial class Form1 : Form
    {
        public class Student
        {
            private string FIO;
            private string fStudy;
            private int nGroup;
            private int[] valEx = new int[5];

            public string Fio { get { return FIO; } set { FIO=value; } }
            public string Fst { get { return fStudy; } set { fStudy=value; } }
            public int Ng { get { return nGroup; } set { nGroup=value; } }
            public int[] VE { get { return valEx; } set { valEx=value; } }

            public Student(string Name, string fst, int nGr, int[] val)
            {
                FIO = Name;
                fStudy=fst;
                nGroup = nGr;
                valEx = val;
            }

            public Student()
            {
                FIO = "Алиев А.А.";
                fStudy = "Очная";
                nGroup = 1;
                valEx = new int[5] { 5, 5, 5, 5, 5 };
            }

            int sumV = 0;
            public double Scount
            {
                get
                {
                    for (int i = 0; i < valEx.Length; i++)
                        if (valEx[i] > 2)
                            sumV += valEx[i];
                    return (double) sumV / valEx.Length;
                }
            }

            public string Info1()
            {
                return FIO +Environment.NewLine+ fStudy +Environment.NewLine+ nGroup.ToString() +Environment.NewLine+ nums(valEx);
            }

            public string Info2()
            {
                return FIO +Environment.NewLine+fStudy +Environment.NewLine+ nGroup.ToString() +Environment.NewLine+ Scount.ToString();
            }

            public string nums(int[] x)
            {
                string Nums="";
                for(int i = 0; i < x.Length; i++)
                {
                    Nums+=x[i].ToString()+" ";
                }
                return Nums;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int[] stud1Ex = { 3, 3, 3, 3, 3 };
                int[] stud2Ex = { 5, 5, 5, 5, 5 };
                int[] stud3Ex = { 4, 4, 5, 5, 4 };
                int[] stud4Ex = { 2, 3, 4, 4, 4 };
                Student stud1 = new Student("Прядкин Д С", "Очная", 2, stud1Ex);
                Student stud2 = new Student("Алиев А А", "Очная", 2, stud2Ex);
                MessageBox.Show(stud2.Info1(), "Информация о студенте 2");
                MessageBox.Show(stud2.Info2(), "Информация о студенте 2");
                Student stud3 = new Student("Котов Р Н", "Заочная", 1, stud3Ex);
                Student stud4 = new Student("Рыбкин Н П", "Очная", 3, stud4Ex);
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="")||(comboBox1.Text=="")||(comboBox7.Text=="")||(comboBox2.Text=="")||(comboBox3.Text=="")||(comboBox4.Text=="")||(comboBox5.Text=="")||(comboBox6.Text==""))
            {
                MessageBox.Show("Ошибка: заполнены не все поля.");
            }
            else
            {
                listBox1.Items.Add("ФИО: "+textBox1.Text);
                listBox1.Items.Add("Форма обучения: "+comboBox1.Text);
                listBox1.Items.Add("Номер группы: "+comboBox7.Text);
                listBox1.Items.Add("");
                listBox1.Items.Add("Результааты экзаменов:");
                listBox1.Items.Add("Математика(общ): "+comboBox2.Text);
                listBox1.Items.Add("Русский язык: "+comboBox3.Text);
                listBox1.Items.Add("Информатика: "+comboBox4.Text);
                listBox1.Items.Add("Физ-ра: "+comboBox5.Text);
                listBox1.Items.Add("Диск.Матем.: "+comboBox6.Text);
                listBox1.Items.Add("");
                listBox1.Items.Add("");
            }
        }
    }
}
