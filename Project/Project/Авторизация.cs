using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        public string Auto(string login, string pass)
        {
            string sql = $"select Роль from Пользователь where Логин='{login}' and Пароль='{pass}'";
            SqlConnection con = Connect.CreateConnection();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                return reader.GetValue(0).ToString();
            else
                return "Ошибка";
        }

        public bool ExPass(string pass)
        {
            Regex pravilo1 = new Regex(@"[A-Z]+");
            Regex pravilo2 = new Regex(@"[0-9]+");
            Regex pravilo3 = new Regex(@"[! @ # $ % ^]+");

            if (pass.Length >= 4 && pass.Length <= 16 && pravilo1.IsMatch(pass) && pravilo2.IsMatch(pass) && pravilo3.IsMatch(pass))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExPass(textBox2.Text))
            {
                if (Auto(textBox1.Text, textBox2.Text) == "Заказчик")
                {
                    Заказчик f1 = new Заказчик();
                    Hide();
                    f1.ShowDialog();
                    Show();
                }
                else if (Auto(textBox1.Text, textBox2.Text) == "Директор")
                {
                    Директор f2 = new Директор();
                    Hide();
                    f2.ShowDialog();
                    Show();
                }
                else if (Auto(textBox1.Text, textBox2.Text) == "Кладовщик")
                {
                    Кладовщик f3 = new Кладовщик();
                    Hide();
                    f3.ShowDialog();
                    Show();
                }
                else if (Auto(textBox1.Text, textBox2.Text) == "Менеджер")
                {
                    Менеджер f4 = new Менеджер();
                    Hide();
                    f4.ShowDialog();
                    Show();
                }
                else
                    MessageBox.Show("Логин или пароль неверны.");
            }
            else
                MessageBox.Show("Пароль не соответствует требованиям.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация reg = new Регистрация();
            Hide();
            reg.ShowDialog();
            Show();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
    }
}
