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
    public partial class Кладовщик : Form
    {
        public Кладовщик()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ткани f = new Ткани();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Фурнитуры f = new Фурнитуры();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
