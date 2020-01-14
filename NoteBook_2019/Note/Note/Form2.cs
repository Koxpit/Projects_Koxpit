using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class LoginForm : Form
    {
        internal string login { get; set; }
        private string password { get; set; }
        private Users users = new Users();
        internal int ID { get; set; }

        public LoginForm()
        {
            InitializeComponent();

            LoadUsers();
            ID = users.id.Count;
        }

        // Загрузка логинов и паролей пользователей
        private void LoadUsers()
        {
            try
            {
                using (FileStream fs = new FileStream("Users.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    users = (Users)formatter.Deserialize(fs);

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
                if (ValidLoginSuccessful())
                {
                    NoteBookForm form1 = new NoteBookForm();
                    form1.ID = ID;
                    MessageBox.Show("You are logged in!");

                    Hide();
                    form1.LoginUserDataLabel.Text = login + "/id: " + ID.ToString();
                    form1.ShowDialog();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidLoginSuccessful()
        {
            if (FieldsAreVoid())
                return false;

            for (int i = 0; i < users.logins.Count; i++)
            {
                if (users.logins[i] == LoginTextBox.Text && users.passwords[i] == PasswordTextBox.Text)
                {
                    login = users.logins[i];
                    password = users.passwords[i];
                    ID = i + 1;

                    return true;
                }
                else if (users.logins[i] == LoginTextBox.Text && users.passwords[i] != PasswordTextBox.Text)
                {
                    login = users.logins[i];
                    MessageBox.Show("Invalid password!");

                    return false;
                }
            }

            return false;
        }

        private bool FieldsAreVoid()
        {
            if (LoginTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("No login or password entered!");

                return true;
            }

            return false;
        }

        // Добавление нового пользователя (регистрция)
        private async void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidRegistrationSuccessful())
                {
                    AddNewUser();
                    await Task.Run(() => UpdateUsersData());
                    MessageBox.Show("You have successfully registered!");
                    login = LoginTextBox.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidRegistrationSuccessful()
        {
            if (FieldsAreVoid())
                return false;

            for (int i = 0; i < users.logins.Count; i++)
                if (users.logins[i] == LoginTextBox.Text)
                {
                    MessageBox.Show("This login already exists!");

                    return false;
                }

            if (PasswordTextBox.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters!");

                return false;
            }

            return true;
        }

        private void AddNewUser()
        {
            users.logins.Add(LoginTextBox.Text);
            users.passwords.Add(PasswordTextBox.Text);
            users.id.Add(ID);
        }

        private void UpdateUsersData()
        {
            using (FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, users);

                fs.Close();
            }
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
    class Users
    {
        internal List<string> logins = new List<string>();
        internal List<string> passwords = new List<string>();
        internal List<int> id = new List<int>();
    }
}
