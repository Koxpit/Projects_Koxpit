using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Note
{
    public partial class Form2 : Form
    {
        public string login = string.Empty;
        private string password = string.Empty;
        private Users user = new Users();
        public int id = 0;

        public Form2()
        {
            InitializeComponent();
            
            LoadUsers();
        }

        // Загрузка данных пользователей из файла в список
        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                user=(Users)formatter.Deserialize(fs);

                fs.Close();
            }
            catch { return; }
        }

        // Вход в систему
        private void EnterToForm()
        {
            try
            {
                for (int i = 0; i < user.logins.Count; i++)
                {
                    if (user.logins[i]==textBox1.Text && user.passwords[i]==textBox2.Text)
                    {
                        login=user.logins[i];
                        password=user.passwords[i];
                        id=i+1;

                        Form1 f1 = new Form1();
                        f1.ID=id;
                        MessageBox.Show("You are logged in!");
                        Hide();
                        f1.label6.Text=login+"/id: "+id.ToString();
                        f1.ShowDialog();
                        this.Close();
                    }
                    else if (user.logins[i]==textBox1.Text && user.passwords[i]!=textBox2.Text)
                    {
                        login=user.logins[i];

                        MessageBox.Show("Invalid password!");
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Регистрация
        private void AddUser()
        {
            try
            {
                if (textBox1.Text==""||textBox2.Text=="") { MessageBox.Show("No login or password entered!"); return; }
                for (int i = 0; i < user.logins.Count; i++)
                    if (user.logins[i]==textBox1.Text)
                    {
                        MessageBox.Show("This login already exists!");
                        return;
                    }
                user.logins.Add(textBox1.Text);
                user.passwords.Add(textBox2.Text);
                user.id.Add(id);

                FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, user);

                fs.Close();

                login=textBox1.Text;

                MessageBox.Show("You have successfully registered!");
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Обработка кнопки входа в систему
        private void button1_Click(object sender, EventArgs e)
        {
            EnterToForm();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(checkBox1.Checked==false)
                textBox2.UseSystemPasswordChar=true;
        }

        // Обработка кнопки добавления нового пользователя(регистрция)
        private void button2_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Проверка, виден ли пароль или нет
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar=false;
            } else
            {
                textBox2.UseSystemPasswordChar=true;
            }
        }
    }

    [Serializable] // -  для работы с файлами
    public class Users
    {
        public List<string> logins = new List<string>();
        public List<string> passwords = new List<string>();
        public List<int> id = new List<int>();
    }
}
