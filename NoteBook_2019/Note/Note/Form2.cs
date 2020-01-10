using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Note
{
    public partial class LoginForm : Form
    {
        public string login = string.Empty;
        private string password = string.Empty;
        private Users user = new Users();
        public int id = 0;

        public LoginForm()
        {
            InitializeComponent();

            LoadUsers();
        }

        // Загрузка логинов и паролей пользователей
        private void LoadUsers()
        {
            try
            {
                using (FileStream fs = new FileStream("Users.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    user = (Users)formatter.Deserialize(fs);

                    fs.Close();
                }
            }
            catch { return; }
        }

        // Вход в систему
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationLogin())
                {
                    NoteBookForm f1 = new NoteBookForm();
                    f1.ID = id;
                    MessageBox.Show("You are logged in!");

                    Hide();
                    f1.LoginUserDataLabel.Text = login + "/id: " + id.ToString();
                    f1.ShowDialog();

                    Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool ValidationLogin()
        {
            if (CheckFieldsForVoid())
                return false;

            for (int i = 0; i < user.logins.Count; i++)
            {
                if (user.logins[i] == LoginTextBox.Text && user.passwords[i] == PasswordTextBox.Text)
                {
                    login = user.logins[i];
                    password=user.passwords[i];
                    id = i+1;

                    return true;
                }
                else if (user.logins[i] == LoginTextBox.Text && user.passwords[i] != PasswordTextBox.Text)
                {
                    login = user.logins[i];
                    MessageBox.Show("Invalid password!");

                    return false;
                }
            }

            return false;
        }

        private bool CheckFieldsForVoid()
        {
            if (LoginTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("No login or password entered!");

                return true;
            }

            return false;
        }

        // Добавление нового пользователя (регистрция)
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidationRegistration())
                    return;

                user.logins.Add(LoginTextBox.Text);
                user.passwords.Add(PasswordTextBox.Text);
                user.id.Add(id);

                using (FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, user);

                    MessageBox.Show("You have successfully registered!");
                    login = LoginTextBox.Text;

                    fs.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool ValidationRegistration()
        {
            if (CheckFieldsForVoid())
                return false;

            for (int i = 0; i < user.logins.Count; i++)
                if (user.logins[i] == LoginTextBox.Text)
                {
                    MessageBox.Show("This login already exists!");

                    return false;
                }

            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == false)
                PasswordTextBox.UseSystemPasswordChar = true;
        }

        // Проверка, виден ли пароль или нет
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
                PasswordTextBox.UseSystemPasswordChar = false;
            else
                PasswordTextBox.UseSystemPasswordChar = true;
        }
    }

    [Serializable]
    public class Users
    {
        public List<string> logins = new List<string>();
        public List<string> passwords = new List<string>();
        public List<int> id = new List<int>();
    }
}
