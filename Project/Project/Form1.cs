using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OutputText()
        {
            string sql = $"select * from Ткань where Артикул='16314397'";
            SqlConnection con = Connect.CreateConnection();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader.GetValue(1).ToString();
            } else MessageBox.Show("Нет данных");
            con.Close();
        }

        public void Output()
        {
            SqlCommand command = new SqlCommand("select * from Ткань", Connect.CreateConnection());
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.HasRows)
            {
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            else MessageBox.Show("Нет данных");
            Connect.CreateConnection().Close();
        }

        public void Output_Image()
        {

        }

        public void AddNote()
        {

        }

        public void DelNote()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Output();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputText();
        }
    }
}
