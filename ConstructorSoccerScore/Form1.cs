using ConstructorSoccerScore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorSoccerScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Tor tor;
        Player player1;
                            

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string Country = cmdCountry.SelectedItem.ToString();
            player1 = new Player(txtName.Text, Country);
            MessageBox.Show($"{player1.Name} and {player1.Country} choosed ");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            player1.Motivation = rnd.Next(0, 10);

            player1.ShootPower += player1.Motivation;

            tor= new Tor();

            tor.Defense = rnd.Next(20,25);
            if (player1.ShootPower > tor.Defense)
            {
                MessageBox.Show("Goooolllll !!! ");
            }
            else
            {
                MessageBox.Show("Tor is gut ! ");
            }
        }
    }
}
