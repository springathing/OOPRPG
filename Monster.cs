using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{

    public class Monster
    {

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }
        
        public Monster()
        {
            Name = "Goblin";
            Strength = 5;
            Defense = 5;
            OriginalHP = 20;
            CurrentHP = 20;
            Gold = 100;
        }

        public Monster(string name, int strength, int defense, int originalhp, int gold)
        {
            Name = name;
            Strength = strength;
            Defense = defense;
            OriginalHP = originalhp;
            CurrentHP = originalhp;
            Gold = gold;

        }
    }
}
