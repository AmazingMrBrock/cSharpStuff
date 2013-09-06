using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RpgEngine
{
    public partial class Form1 : Form
    {
        Character bob;

        public Form1()
        {
            InitializeComponent();
            bob = new Character() { Name = "Bob", CurrentXp = 22000};
            bob.Update();
            xpLabel.Text = "Xp " + bob.CurrentXp;
            levelLabel.Text = "Level " + bob.Level;
            nextLevelLabel.Text = bob.NextXp + " Till next Level";
            
        }
        

        private void LevelSystemTest_Click(object sender, EventArgs e)
        {
            bob.Update();
            MessageBox.Show("My next level is in " + bob.NextXp + " xp");
            nextLevelLabel.Text = bob.NextXp + " Till next Level";
            
        }

        private void currentLevel_Click(object sender, EventArgs e)
        {
            bob.Update();
            MessageBox.Show("My current level is " + bob.Level);
            levelLabel.Text = "Level " + bob.Level;
        }

        private void addXp_Click(object sender, EventArgs e)
        {
            bob.Update();
            bob.CurrentXp = bob.CurrentXp + 100;
            xpLabel.Text = "Xp " + bob.CurrentXp;
            levelLabel.Text = "Level " + bob.Level;
            nextLevelLabel.Text = bob.NextXp + " Till next Level";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'levelingListDataSet.XpLevelList' table. You can move, or remove it, as needed.
            this.xpLevelListTableAdapter.Fill(this.levelingListDataSet.XpLevelList);

        }


    }
}
