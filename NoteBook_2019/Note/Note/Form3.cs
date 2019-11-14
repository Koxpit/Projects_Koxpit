using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Note
{
    public partial class Form3 : Form
    {
        Form1 f1;

        private List<Record> bas = new List<Record>();
        public List<Record> Bas
        {
            get { return bas; }
            set { bas=value; }
        }

        private List<Record> recover = new List<Record>();
        public List<Record> Recover
        {
            get { return recover; }
            set { recover=value; }
        }

        public Form3()
        {
            InitializeComponent();
            f1 = (Form1)this.Owner;
        }

        private void DelRecord(int n)
        {
            bas.RemoveAt(n);
            dataGridView1.DataSource=bas.ToList();
        }

        private void DelAllRec()
        {
            if (dataGridView1.Rows.Count!=0)
            {
                DialogResult result;
                result=MessageBox.Show("Are you sure you want to delete all records?",
                    "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result==DialogResult.Yes)
                {
                    bas.Clear();
                    dataGridView1.DataSource=bas.ToList();

                    MessageBox.Show("Cart cleared successfully!");
                }
            } else { MessageBox.Show("Cart is empty!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                DialogResult result;
                result=MessageBox.Show("Are you sure you want to delete the selected entries?",
                    "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result==DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count==0)
                    {
                        MessageBox.Show("No records selected!");
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            bas.RemoveAt(row.Index);

                        MessageBox.Show("Delete complete!");
                    }

                    dataGridView1.DataSource=bas.ToList();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelAllRec();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                DialogResult result;
                result=MessageBox.Show("Do you want to restore the selected records?",
                    "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result==DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count==0)
                    {
                        MessageBox.Show("No records selected!");
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            recover.Add(bas.ElementAt(row.Index));
                            bas.RemoveAt(row.Index);
                        }
                    }
                    dataGridView1.DataSource=bas.ToList();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0)
            {
                DialogResult result;
                result=MessageBox.Show("Do you want to restore all records?",
                    "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result==DialogResult.Yes)
                {
                    recover.AddRange(bas);
                    bas.Clear();
                    dataGridView1.DataSource=bas.ToList();
                    MessageBox.Show("Cart cleared successfully!");
                }
            }
            else { MessageBox.Show("Cart is empty!"); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Delete one/few records");
            toolTip1.SetToolTip(button2, "Delete all records");
            toolTip1.SetToolTip(button3, "Recover one/few records");
            toolTip1.SetToolTip(button4, "Recover all records");
        }
    }
}
