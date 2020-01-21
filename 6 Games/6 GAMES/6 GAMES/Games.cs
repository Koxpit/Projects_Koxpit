using System;
using System.Windows.Forms;

namespace _6_GAMES
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            listBox1.Items.Add(" 6 GAMES - компьютерная игра");
            listBox1.Items.Add("Цель, которой – показать, что компьютер нужен не только для работы.");
            listBox1.Items.Add("- Что компьютерные игры могут быть очень полезны при изучении компьютерной грамотности");
            listBox1.Items.Add("- Что компьютерные игры не всегда сложные и однообразные");
            listBox1.Items.Add("Автор проекта искренне надеется, что вам понравятся представленные игры.");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
            listBox1.Items.Add("Любые пожелания можете писать в любом удобном виде в одной из предложенных ");
            listBox1.Items.Add("Соц. cетей в пункте  “Мы в соц.сетях”");
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Close();
            Form1 newForm = new Form1();
            newForm.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
            SocNet newForm = new SocNet();
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
            DONATE newForm = new DONATE();
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
            settings newForm = new settings();
            newForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
            HELP newForm = new HELP();
            newForm.Show();
        }
    }
}
