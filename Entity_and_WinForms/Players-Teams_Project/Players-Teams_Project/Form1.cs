using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Players_Teams_Project
{
    public partial class Form1 : Form
    {
        SoccerContext db;
        public Form1()
        {
            InitializeComponent();
            db=new SoccerContext();
            db.Players.Load();
            dataGridView1.DataSource=db.Players.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForm PlForm = new PlayerForm();

            List<Team> teams = db.Teams.ToList();
            PlForm.comboBox2.DataSource=teams;
            PlForm.comboBox2.ValueMember="Id";
            PlForm.comboBox2.DisplayMember="Name";

            DialogResult result = PlForm.ShowDialog(this);

            if (result==DialogResult.Cancel)
                return;

            Player player = new Player();
            player.Age=(int)PlForm.numericUpDown1.Value;
            player.Name=PlForm.textBox1.Text;
            player.Position=PlForm.comboBox1.SelectedItem.ToString();
            player.Team=(Team)PlForm.comboBox2.SelectedItem;

            db.Players.Add(player);
            db.SaveChanges();

            MessageBox.Show("Новый футболист добавлен");
        }

        // Edit
        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted==false)
                return;

            Player player = db.Players.Find(id);

            PlayerForm plForm = new PlayerForm();
            plForm.numericUpDown1.Value=player.Age;
            plForm.comboBox1.Text=player.Position;
            plForm.textBox1.Text=player.Name;

            List<Team> teams = db.Teams.ToList();
            plForm.comboBox2.DataSource=teams;
            plForm.comboBox2.ValueMember="Id";
            plForm.comboBox2.DisplayMember="Name";

            if (player.Team!=null)
                plForm.comboBox2.SelectedValue=player.Team.Id;

            DialogResult result = plForm.ShowDialog(this);

            if (result==DialogResult.Cancel)
                return;

            player.Age=(int)plForm.numericUpDown1.Value;
            player.Name=plForm.textBox1.Text;
            player.Position=plForm.comboBox1.SelectedItem.ToString();
            player.Team=(Team)plForm.comboBox2.SelectedItem;

            db.Entry(player).State=EntityState.Modified;
            db.SaveChanges();

            MessageBox.Show("Объект обновлен");
        }

        // Delete
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted==false)
                    return;

                Player player = db.Players.Find(id);
                db.Players.Remove(player);
                db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }

        // Opened Form With Comands
        private void button4_Click(object sender, EventArgs e)
        {
            Teams team = new Teams();
            team.Show();
        }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public int? TeamId { get; set; }
        public virtual Team Team { get; set; } */
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public Team() {
            Players=new List<Player>();
        }
        public override string ToString()
        {
            return Name;
        }
    }


    public class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerDb") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
