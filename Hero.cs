using System;
using System.Collections.Generic;

namespace OOPRPG
{
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }

        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }

        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armors { get; set; }

        public Hero()
        {
            this.Strength = 20;
            this.Defense = 20;
            this.OriginalHP = 75;
            this.CurrentHP = 75;
            this.Gold = 50;

            Armor armor = new Armor();
            this.Armors = new List<Armor>();
            this.EquippedArmor = armor;
            Armors.Add(armor);

            Weapon weapon = new Weapon();
            this.Weapons = new List<Weapon>();
            this.EquippedWeapon = weapon;
            Weapons.Add(weapon);
        }

        public void ShowInventory()
        {
            Console.WriteLine();
            Console.WriteLine("Inventory of Warrior " + this.Name);
            Console.WriteLine("Equipped Weapon: " + EquippedWeapon.name + " (+" + EquippedWeapon.strength + " Strength)");
            Console.WriteLine("Weapons: ");
            int aLabel = 1;
            int wLabel = 1;
            foreach (var wep in this.Weapons)
            {
                Console.WriteLine(wLabel + "w. " + wep.name + " (+" + wep.strength + " Strength+)");
                wLabel++;
            }
            Console.WriteLine();
            Console.WriteLine("Equipped Armor: " + EquippedArmor.name + " (+" + EquippedArmor.defense + " Defense)");
            Console.WriteLine("Armors: ");
            foreach (var armo in this.Armors)
            {
                Console.WriteLine(aLabel + "a. " + armo.name + " (+" + armo.defense + " Defense)");
                aLabel++;
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            this.Weapons.Add(this.EquippedWeapon);
            this.EquippedWeapon = weapon;
            this.Strength += weapon.strength;
            this.Weapons.Remove(weapon);
        }

        public void EquipArmor(Armor armor)
        {
            this.Armors.Add(this.EquippedArmor);
            this.EquippedArmor = armor;
            this.Defense += armor.defense;
            this.Armors.Remove(armor);
        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine("Current Stats of Warrior: " + this.Name);
            Console.WriteLine("Strength: " + this.Strength);
            Console.WriteLine("Defense: " + this.Defense);
            Console.WriteLine("Health Points: " + this.CurrentHP + " / " + this.OriginalHP);
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu");
        }
        
    }
}