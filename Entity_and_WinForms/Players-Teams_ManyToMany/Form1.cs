using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Players_Teams_ManyToMany
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

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForm plForm = new PlayerForm();

            List<Team> teams = db.Teams.ToList();
            plForm.listBox1.DataSource=teams;
            plForm.listBox1.ValueMember="Id";
            plForm.listBox1.DisplayMember="Name";

            DialogResult result = plForm.ShowDialog(this);
            if (result==DialogResult.Cancel)
                return;

            Player pl = new Player();
            pl.Name=plForm.textBox1.Text;
            pl.Age=(int)plForm.numericUpDown1.Value;

            teams.Clear();
            foreach(var item in plForm.listBox1.SelectedItems)
            {
                teams.Add((Team)item);
            }

            pl.Teams=teams;
            db.Players.Add(pl);
            db.SaveChanges();

            MessageBox.Show("Новый игрок добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count<1)
                return;

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted==false)
                return;

            Player player = db.Players.Find(id);

            PlayerForm plForm = new PlayerForm();
            plForm.textBox1.Text=player.Name;
            plForm.numericUpDown1.Value=player.Age;

            List<Team> teams = db.Teams.ToList();
            plForm.listBox1.DataSource=teams;
            plForm.listBox1.ValueMember="Id";
            plForm.listBox1.DisplayMember="Name";
            foreach (Team t in player.Teams)
                plForm.listBox1.SelectedItem=t;


            DialogResult result = plForm.ShowDialog(this);
            if (result==DialogResult.Cancel)
                return;

            player.Age=(int)plForm.numericUpDown1.Value;
            player.Name=plForm.textBox1.Text;

            foreach(var team in teams)
            {
                if(plForm.listBox1.SelectedItems.Contains(team))
                {
                    if (!player.Teams.Contains(team))
                        player.Teams.Add(team);
                }
                else
                {
                    if (player.Teams.Contains(team))
                        player.Teams.Remove(team);
                }
            }

            db.Entry(player).State=EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Информация обновлена");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count<1)
                return;

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted==false)
                return;

            Player player = db.Players.Find(id);

            db.Players.Remove(player);
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeamForm tmForm = new TeamForm();

            DialogResult result = tmForm.ShowDialog(this);
            if (result==DialogResult.Cancel)
                return;

            Team team = new Team();
            team.Name=tmForm.textBox1.Text;
            team.Coach=tmForm.textBox2.Text;
            team.Players=new List<Player>();

            db.Teams.Add(team);
            db.SaveChanges();
            MessageBox.Show("Команда добавлена");
        }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public Player()
        {
            Teams=new List<Team>();
        }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public Team()
        {
            Players=new List<Player>();
        }
    }

    public class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerDB2") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
