using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class SocNet : Form
    {
        public SocNet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ecoteamservis");
        }

        private void label2_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCG5WU1Isv_CBQBERGgQwlsQ?view_as=subscriber");
        }
    }
}
