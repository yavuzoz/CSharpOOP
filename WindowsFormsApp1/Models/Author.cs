using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Models
{
    internal class Author
    {
        public string AuthorName { get; set; }
        public string LastName { get; set; }

        public void Write(string BookName)
        {
            System.Windows.Forms.MessageBox.Show($"{BookName}{AuthorName} {LastName} is the work of a forensic author ");

        }
    }
}
