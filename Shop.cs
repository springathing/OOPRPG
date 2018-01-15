using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    public class Shop
    {
        public Game game { get; set; }
        public Hero hero { get; set; }
        public List<Armor> Armors { get; set; }
        public List<Weapon> Weapons { get; set; }

        public Shop(Game game, Hero hero)
        {
            this.game = game;
            this.hero = hero;
            Armors = new List<Armor>();
            Weapons = new List<Weapon>();

            AddArmors("Bronze Armor", 10, 50, 25);
            AddArmors("Iron Armor", 15, 100, 50);
            AddArmors("Steel Armor", 20, 150, 75);
            AddArmors("Elven Armor", 25, 200, 100);
            AddArmors("Dragon Armor", 30, 250, 125);

            AddWeapons("Bronze Sword", 10, 50, 25);
            AddWeapons("Iron Sword", 15, 100, 50);
            AddWeapons("Steel Sword", 20, 150, 75);
            AddWeapons("Elven Sword", 25, 200, 100);
            AddWeapons("Dragon Sword", 30, 250, 125);
        }

        public void ShowItems()
        {
            int aLabel = 1;
            int wLabel = 1;
            Console.WriteLine();
            Console.WriteLine("Buy From Shop");
            Console.WriteLine();
            Console.WriteLine("Armor: ");
            foreach (var a in this.Armors)
            {
                Console.WriteLine(aLabel + "a. " + a.name + " (+" + a.defense + " Defense)");
                aLabel++;
            }
            Console.WriteLine();
            Console.WriteLine("Weapons: ");
            foreach (var w in this.Weapons)
            {
                Console.WriteLine(wLabel + "w. " + w.name + " (+" + w.strength + " Strength)");
                wLabel++;
            }
            Console.WriteLine();
            Console.WriteLine("Enter item that you want to buy or any other key to return to the main menu.");
            if (hero.Armors.Count() > 0 || hero.Weapons.Count() > 0)
            {
                Console.WriteLine("Enter 's' if you would like to sell any of your items.");
            }
            var input = Console.ReadLine();
            if (input == "")
            {
                game.Main();
            }
            else if (input.Substring(input.Length - 1, 1) == "a" && Convert.ToInt32(input.Substring(0, 1)) <= this.Armors.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var armor = this.Armors[number - 1];
                this.BuyArmor(armor);
            }
            else if (input.Substring(input.Length - 1, 1) == "w" && Convert.ToInt32(input.Substring(0, 1)) <= this.Weapons.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var weapon = this.Weapons[number - 1];
                this.BuyWeapon(weapon);
            }
            else if (input == "s" && (hero.Armors.Count() > 0 || hero.Weapons.Count() > 0))
            {
                this.SellItems();
            }
            game.Main();

        }
        
        public void SellItems()
        {
            int aLabel = 1;
            int wLabel = 1;
            Console.WriteLine();
            Console.WriteLine("Sell To Shop");
            Console.WriteLine();
            Console.WriteLine("Armor: ");
            foreach (var a in hero.Armors)
            {
                Console.WriteLine(aLabel + "a. " + a.name + " (+" + a.defense + " Defense)");
                aLabel++;
            }
            Console.WriteLine();
            Console.WriteLine("Weapons: ");

            foreach (var w in hero.Weapons)
            {
                Console.WriteLine(wLabel + "w. " + w.name + " (+" + w.strength + " Strength)");
                wLabel++;
            }
            Console.WriteLine();
            Console.WriteLine("Enter item that you want to sell or any other key to return to the main menu.");
            Console.WriteLine("Enter 'b' if you would like to buy any items");
            var input = Console.ReadLine();
            if (input == "")
            {
                game.Main();
            }
            else if (input.Substring(input.Length - 1, 1) == "a" && Convert.ToInt32(input.Substring(0, 1)) <= hero.Armors.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var armor = hero.Armors[number - 1];
                this.SellArmor(armor);
            }
            else if (input.Substring(input.Length - 1, 1) == "w" && Convert.ToInt32(input.Substring(0, 1)) <= hero.Weapons.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var weapon = hero.Weapons[number - 1];
                this.SellWeapon(weapon);
            }
            else if (input == "b")
            {
                this.ShowItems();
            }
            game.Main();
        }

        public void AddArmors(string name, int defense, int cost, int sellprice)
        {
            Armor armor = new Armor(name, defense, cost, sellprice);
            Armors.Add(armor);
        }

        public void AddWeapons(string name, int strength, int cost, int sellprice)
        {
            Weapon weapon = new Weapon(name, strength, cost, sellprice);
            Weapons.Add(weapon);
        }

        public void BuyWeapon(Weapon weapon)
        {
            if (hero.Gold > weapon.cost)
            {
                this.Weapons.Remove(weapon);
                this.hero.Weapons.Add(weapon);
                hero.Gold -= weapon.cost;
            }
            else
            {
                Console.WriteLine("You can't afford this Weapon!");
            }
            
        }

        public void SellWeapon(Weapon weapon)
        {
            this.Weapons.Add(weapon);
            this.hero.Weapons.Remove(weapon);
            hero.Gold += weapon.sellprice;
        }

        public void BuyArmor(Armor armor)
        {
            if (hero.Gold > armor.cost)
            {
                this.Armors.Remove(armor);
                this.hero.Armors.Add(armor);
                hero.Gold -= armor.cost;
            }
            else
            {
                Console.WriteLine("You can't afford this Armor!");
            }

        }

        public void SellArmor(Armor armor)
        {
            this.Armors.Add(armor);
            this.hero.Armors.Remove(armor);
            hero.Gold += armor.sellprice;
        }
    }
}
