using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    public class Armor
    {
        public string name { get; set; }
        public int defense { get; set; }
        public int cost { get; set; }
        public int sellprice { get; set; }

        public Armor()
        {
            this.name = "Bronze Armor";
            this.defense = 10;
            this.cost = 50;
            this.sellprice = 25;
        }

        public Armor(string name, int defense, int cost, int sellprice) // overloaded constructor (polymorphiism) // dynamic passing name and defense
        {
            this.name = name;
            this.defense = defense;
            this.cost = cost;
            this.sellprice = sellprice;
        }
        
    }
}