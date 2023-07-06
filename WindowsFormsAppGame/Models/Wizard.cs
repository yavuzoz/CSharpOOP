using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppGame;

namespace WindowsFormsAppGame.Models
{
    public class Wizard
    {
        public string PlayerName { get; set; }
        public string Branch { get; set; }
        public string Race { get; set; }
        public string Gun { get; set; }
        public int AttackPower { get; set; }


        public void Attack()
        {
            switch (Branch)
            {
                case " Darkwizard":
                    AttackPower = 50;
                    break;
                case "Defansif":
                    AttackPower = 10;
                    break;
                default:
                    AttackPower = 30;
                    break;
            }
        }
    }
}
