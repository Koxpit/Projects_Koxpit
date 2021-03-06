﻿using System;
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
    public partial class Teams : Form
    {
        SoccerContext db;
        public Teams()
        {
            InitializeComponent();
            db=new SoccerContext();
            db.Teams.Load();
            dataGridView1.DataSource=db.Teams.Local.ToBindingList();
        }

        private void Teams_Load(object sender, EventArgs e)
        {

        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            TeamForm tmForm = new TeamForm();
            DialogResult result = tmForm.ShowDialog(this);

            if (result==DialogResult.Cancel)
                return;

            Team team = new Team();
            team.Name=tmForm.textBox1.Text;
            team.Coach=tmForm.textBox2.Text;

            db.Teams.Add(team);
            db.SaveChanges();
            MessageBox.Show("Объект добавлен");
        }

        // просмотр списка игроков команды
        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted==false)
                    return;

                Team team = db.Teams.Find(id);
                listBox1.DataSource=team.Players.ToList();
                listBox1.DisplayMember="Name";
            }
        }

        // Delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted==false)
                    return;

                Team team = db.Teams.Find(id);
                team.Players.Clear();
                db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }

        //Edit
        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted==false)
                return;

            Team team = db.Teams.Find(id);

            TeamForm tmForm = new TeamForm();
            tmForm.textBox1.Text=team.Name;
            tmForm.textBox2.Text=team.Coach;

            DialogResult result = tmForm.ShowDialog(this);
            if (result==DialogResult.Cancel)
                return;

            team.Name=tmForm.textBox1.Text;
            team.Coach=tmForm.textBox2.Text;

            db.Entry(team).State=EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Объект обновлен");
        }
    }
}
