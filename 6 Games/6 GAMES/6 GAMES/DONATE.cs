using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class DONATE : Form
    {
        public DONATE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
