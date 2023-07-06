using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.AuthorName = "Agatha";
            author.LastName = "Christie";
            author.Write("Death on the Nile");

            Author author1 = new Author();
            author1.AuthorName = "Paulo";
            author1.LastName = "Coelho";
            author1.Write("The Alchemist");
        }
    }
}
