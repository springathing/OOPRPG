using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    public class Fight
    {
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Settings Settings { get; set; }
        public Monster Monster { get; set; }

        public Fight(Hero hero, Game game, Settings settings)
        {
            this.hero = hero;
            this.game = game;
            this.Settings = settings;
        }

        public void Start()
        {
            if (Settings.Monsters.Count() > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(1, Settings.Monsters.Count() + 1);
                this.Monster = Settings.Monsters[index - 1];
                Console.WriteLine();
                Console.WriteLine("You've encountered a " + Monster.Name + "!");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine(Monster.Name + "'s Combat Stats");
                Console.WriteLine("Strength: " + Monster.Strength);
                Console.WriteLine("Defense: " + Monster.Defense);
                Console.WriteLine("HP: " + Monster.CurrentHP);
                Console.WriteLine("-------------------");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("Your Combat Stats");
                Console.WriteLine("Strength " + hero.Strength);
                Console.WriteLine("Defense " + hero.Defense);
                Console.WriteLine("HP: " + hero.CurrentHP);
                Console.WriteLine("-------------------");
                Console.WriteLine();
                Console.WriteLine("Choose your own fate, " + hero.Name + ":");
                Console.WriteLine("1. Fight the " + Monster.Name + "!");
                Console.WriteLine("2. Run!");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    this.FightMonster();
                }
                else if (input == "2")
                {
                    this.Run();
                }
            }
            else
            {
                Console.WriteLine("There are no more monsters to fight! Press any key to return to the main menu");
                Console.WriteLine();
                Console.ReadKey(true);
                game.Main();
            }
        }

        public void FightMonster()
        {
            Random rnd = new Random();
            Console.WriteLine();
            Console.WriteLine("The Battle Begins!");
            while ((hero.CurrentHP > 0) && (Monster.CurrentHP > 0))
            {
                int damage = rnd.Next(1, hero.Strength);
                Console.WriteLine();
                Console.WriteLine(hero.Name + " does " + damage + " points of damage to " + Monster.Name + "!");
                HeroAttack(damage);
                if (Monster.CurrentHP > 0)
                {
                    Console.WriteLine(Monster.Name + "'s current HP is: " + Monster.CurrentHP);
                }
                else if (Monster.CurrentHP < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(Monster.Name + " has been defeated!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to go back to the main menu!");
                    Console.ReadKey(true);
                    game.Main();
                }
                

                int damage2 = rnd.Next(1, Monster.Strength);
                Console.WriteLine();
                Console.WriteLine(Monster.Name + " does " + damage2 + " points of damage to " + hero.Name + "!");
                MonsterAttack(damage2);
                if (hero.CurrentHP > 0)
                {
                    Console.WriteLine(hero.Name + "'s current HP is: " + hero.CurrentHP);
                }
                else if (hero.CurrentHP <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(hero.Name + " has died!");
                    Console.WriteLine();
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey(true);
                    return;
                }
            }
            Console.ReadLine();
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("You fled the area giving up half of your gold");
            hero.Gold = hero.Gold / 2;
            Console.WriteLine("Remaining Gold: " + hero.Gold);
            Console.ReadKey(true);
            game.Main();
        }

        public void HeroAttack(int heroDamage)
        {
            Monster.CurrentHP -= heroDamage;
        }

        public void MonsterAttack(int monsterDamage)
        {
            hero.CurrentHP -= monsterDamage;
        }

    }
}
