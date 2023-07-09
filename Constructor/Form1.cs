using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Baby baby = new Baby();
            //baby.Name = txtBaby.Text;
            //MessageBox.Show($"{baby.Name} this baby {baby.BirthDate} this date born ");

            Baby baby2 = new Baby(txtBaby.Text);
            MessageBox.Show($"{baby2.Name} this baby {baby2.BirthDate} this date born ");
        }
    }
}
