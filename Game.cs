using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPRPG;

namespace OOPRPG
{
    public class Game
    {
        public Hero hero { get; set; }   // the game will have these properties
        public Shop shop { get; set; }
        public Settings settings { get; set; }


        public Game()                    // constructor "this" refers to the instance of game
        {
            this.hero = new Hero();
            this.shop = new Shop(this, this.hero);
            this.settings = new Settings(shop);
        }

        public void Start()              // method
        {
            Console.WriteLine("Welcome Hero!");
            Console.WriteLine("Please enter your name: ");
            this.hero.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("May your battles be glorious " + hero.Name + "!");
            this.Main();
        }

        public void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose an option by entering a number.");
            Console.WriteLine("1. View Stats");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Fight Monster");
            Console.WriteLine("4. Visit Shop");
            Console.WriteLine("5. Settings");
            var input = Console.ReadLine();             // implicit // string input = Console.ReadLine(); is explicit
            if (input == "1")
            {
                this.Stats();
            }
            else if (input == "2")
            {
                this.Inventory();
            }
            else if (input == "3")
            {
                this.Fight();
            }
            else if (input == "4")
            {
                this.VisitShop();
            }
            else if (input == "5")
            {
                this.VisitSettings();
            }
            else
            {
                return;
            }
        }

        public void Stats()
        {
            this.hero.ShowStats();
            Console.ReadKey(true);
            this.Main();
        }

        public void Inventory()
        {
            this.hero.ShowInventory();
            Console.WriteLine();
            Console.WriteLine("Enter the item that you want to equip or press the enter key to return to the main menu");
            var input = Console.ReadLine();
            if (input == "")
            {
                this.Main();
            }
            else if (input.Substring(input.Length - 1, 1) == "a" && Convert.ToInt32(input.Substring(0, 1)) <= hero.Armors.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var armor = hero.Armors[number - 1];
                hero.EquipArmor(armor);
            }
            else if (input.Substring(input.Length - 1, 1) == "w" && Convert.ToInt32(input.Substring(0, 1)) <= hero.Weapons.Count())
            {
                var number = Convert.ToInt32(input.Substring(0, 1));
                var weapon = hero.Weapons[number - 1];
                hero.EquipWeapon(weapon);
            }
            this.Main();
        }

        public void VisitShop()
        {
            shop.ShowItems();
            this.Main();
        }

        public void VisitSettings()
        {           
            settings.ShowSettings();
            this.Main();
        }
        public void Fight()
        {
            Fight fight = new Fight(this.hero, this, this.settings);
            fight.Start();
        }

    }
}
