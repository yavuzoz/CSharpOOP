using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppGame.Models;

namespace WindowsFormsAppGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Wizard player1= new Wizard();
        int soul;

        private void btnChoice_Click(object sender, EventArgs e)
        {
            player1.PlayerName= txtPlayer.Text;
            player1.Branch= txtBranch.Text;  
            player1.Race= txtRace.Text;
            player1.Gun= txtGun.Text;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soul = enemySoul.Width;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EnemySoul_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player1.Attack();

            soul -= player1.AttackPower;
            enemySoul.Width = soul;
            MessageBox.Show($" you have to the enemy  {player1.AttackPower} attacked !");
            if (soul <= 0)
            {
                MessageBox.Show("you won è! ");
            }

        }
    }
}
