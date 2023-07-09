using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Baby
    {
        //public Baby()
        //{
        //    BirthDate = DateTime.Now;
        //}
        public Baby(string _Name)
        {
            Name = _Name;
            BirthDate = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
