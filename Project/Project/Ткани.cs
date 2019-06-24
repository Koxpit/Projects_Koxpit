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
    public partial class Ткани : Form
    {
        public Ткани()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = $"select * from Ткань";
            SqlConnection con = Connect.CreateConnection();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);
                for (int i = 0; i<9; i++)
                    data[data.Count-1][i]=reader[i].ToString();
            }

            reader.Close();
            con.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Ткани_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount=9;
            dataGridView1.Columns[0].HeaderText="Артикул";
            dataGridView1.Columns[1].HeaderText="Наименование";
            dataGridView1.Columns[2].HeaderText="Рисунок";
            dataGridView1.Columns[3].HeaderText="Изображение";
            dataGridView1.Columns[4].HeaderText="Состав";
            dataGridView1.Columns[5].HeaderText="Ширина";
            dataGridView1.Columns[6].HeaderText="Длина";
            dataGridView1.Columns[7].HeaderText="Цена";
            dataGridView1.Columns[8].HeaderText="Цвет";
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_ткань f = new Добавить_ткань();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
