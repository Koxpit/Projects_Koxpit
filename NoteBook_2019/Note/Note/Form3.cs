using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Note
{
    public partial class CartForm : Form
    {
        NoteBookForm f1;

        private List<Record> cart = new List<Record>();
        private List<Record> recoverList = new List<Record>();

        // Хранит записи корзины
        public List<Record> Cart
        {
            get { return cart; }
            set { cart = value; }
        }
        // Хранит восстановленные записи
        public List<Record> RecoverList
        {
            get { return recoverList; }
            set { recoverList = value; }
        }

        public CartForm()
        {
            InitializeComponent();
            f1 = (NoteBookForm)Owner;
        }

        // Удалить выбранные записи из корзины
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entries?",
                        "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (dataGridView.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("No records selected!");
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                                cart.RemoveAt(row.Index);

                            MessageBox.Show("Delete complete!");
                        }
                        OutputCartListToDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OutputCartListToDataGrid()
        {
            dataGridView.DataSource = cart.ToList();
        }

        // Удаление всех записей из корзины
        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete all records?",
                        "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        cart.Clear();
                        OutputCartListToDataGrid();
                        MessageBox.Show("Cart cleared successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Cart is empty!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // Восстановление выбранных записей
        private void RecoverButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to restore the selected records?",
                        "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (dataGridView.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("No records selected!");
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                            {
                                recoverList.Add(cart.ElementAt(row.Index));
                                cart.RemoveAt(row.Index);
                            }
                        }
                        OutputCartListToDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Восстановить все записи
        private void RecoverAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to restore all records?",
                        "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        recoverList.AddRange(cart);
                        cart.Clear();
                        OutputCartListToDataGrid();
                        MessageBox.Show("Cart cleared successfully!");
                    }
                }
                else {
                    MessageBox.Show("Cart is empty!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Подсказки
        private void Form3_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip( DeleteButton, "Delete one/few records");
            toolTip.SetToolTip( DeleteAllButton, "Delete all records");
            toolTip.SetToolTip( RecoverButton, "Recover one/few records");
            toolTip.SetToolTip( RecoverAllButton, "Recover all records");
        }
    }
}
