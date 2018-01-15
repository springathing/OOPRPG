using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    public class Settings
    {
        public List<Monster> Monsters { get; set; }
        public Shop myShop { get; set; }

        public Settings(Shop shop)
        {
            this.Monsters = new List<Monster>();
            myShop = shop;
            Monster monster = new Monster();
            Monsters.Add(monster);

            AddDefaultMonster("Giant Snake", 10, 10, 25, 50);
            AddDefaultMonster("Raptor", 15, 15, 50, 150);
            AddDefaultMonster("Chomper", 20, 20, 75, 200);
            AddDefaultMonster("Scipher", 30, 30, 100, 250);
            AddDefaultMonster("Mega Bear", 50, 50, 125, 300);
        }
        public void ShowSettings()
        {
            Console.WriteLine();
            Console.WriteLine("***** Settings *****");
            Console.WriteLine("1. Add more monsters");
            Console.WriteLine("2. Add more items to the shop");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter name of a monster");
                var name = Console.ReadLine();
                Console.WriteLine("Enter strength of a monster (1 - 50)");
                var strength = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter defense of a monster (1 - 50)");
                var defense = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter original health points of a monster (25 - 100)");
                var originalhp = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter gold carried by a monster");
                var gold = int.Parse(Console.ReadLine());

                AddMonster(name, strength, defense, originalhp, gold);
            }
            else if (input == "2")
            {
                Console.WriteLine("Which would you like to add?");
                Console.WriteLine("1. Weapon");
                Console.WriteLine("2. Armor");
                var input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter name of a weapon");
                    var wname = Console.ReadLine();
                    Console.WriteLine("Enter strength of a weapon");
                    var str = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter cost of a weapon");
                    var cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter sell price of a weapon");
                    var sellprice = Convert.ToInt32(Console.ReadLine());
                    myShop.AddWeapons(wname, str, cost, sellprice);
                }
                if (input2 == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter name of armor");
                    var aname = Console.ReadLine();
                    Console.WriteLine("Enter defense of armor");
                    var def = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter cost of armor");
                    var cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter sell price of armor");
                    var sellprice = Convert.ToInt32(Console.ReadLine());

                    myShop.AddArmors(aname, def, cost, sellprice);
                }
                    
            }

        }

        public void AddMonster(string name, int strength, int defense, int originalhp, int gold)
        {
            Monster monster = new Monster(name, strength, defense, originalhp, gold);
            Monsters.Add(monster);

            Console.WriteLine();
            Console.WriteLine("Here are available monsters");
            int counter = 1;
            foreach (var mon in Monsters)
            {
                Console.WriteLine(counter + ". " + mon.Name);
                counter++;
            }
        }

        public void AddDefaultMonster(string name, int strength, int defense, int originalhp, int gold)
        {
            Monster monster = new Monster(name, strength, defense, originalhp, gold);
            Monsters.Add(monster);
        }
        
    }
}