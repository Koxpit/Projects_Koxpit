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
    public partial class Фурнитуры : Form
    {
        public Фурнитуры()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = $"select * from Фурнитура";
            SqlConnection con = Connect.CreateConnection();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);
                for (int i = 0; i<7; i++)
                    data[data.Count-1][i]=reader[i].ToString();
            }

            reader.Close();
            con.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Фурнитуры_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount=7;
            dataGridView1.Columns[0].HeaderText="Артикул";
            dataGridView1.Columns[1].HeaderText="Наименование";
            dataGridView1.Columns[2].HeaderText="Тип";
            dataGridView1.Columns[3].HeaderText="Ширина";
            dataGridView1.Columns[4].HeaderText="Длина";
            dataGridView1.Columns[5].HeaderText="Вес";
            dataGridView1.Columns[6].HeaderText="Изображение";
            LoadData();
        }
    }
}
