using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSoccerScore.Models
{
    public class Player
    {

        public Player(string _Name, string _Country)
        {
            Name = _Name;
            Country = _Country;
            switch (Country)
            {
                case "England":
                    ShootPower = 20;
                    break;
                case "Turkey":
                    ShootPower = 15;
                    break;
                case "Switzerland":
                    ShootPower = 15;
                    break;
            }
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public int ShootPower  { get; set; }
        public int Motivation { get; set; }

    }
}
