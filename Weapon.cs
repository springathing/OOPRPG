using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    public class Weapon
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int cost { get; set; }
        public int sellprice { get; set; }

        public Weapon()
        {
            this.name = "Bronze Sword";
            this.strength = 10;
            this.cost = 50;
            this.sellprice = 25;
        }

        public Weapon(string name, int strength, int cost, int sellprice)
        {
            this.name = name;
            this.strength = strength;
            this.cost = cost;
            this.sellprice = sellprice;
        }  
      
    }
}
