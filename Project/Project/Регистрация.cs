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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
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

        public void AddNewNote(string login, string password)
        {
            if (ExPass(password))
            {
                string sql = $"insert into Пользователь values('{login}','{password}','Заказчик',NULL)";
                SqlConnection con = Connect.CreateConnection();
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Успешная регистрация.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else MessageBox.Show("Пароль не соответствует требованиям.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewNote(textBox1.Text, textBox2.Text);
        }
    }
}
