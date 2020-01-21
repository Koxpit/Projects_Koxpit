using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class HELP : Form
    {
        public HELP()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
