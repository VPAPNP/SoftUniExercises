using System;
using System.Collections.Generic;
using System.Linq;


namespace T03_Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Heroes> listHeroes = new List<Heroes>();
            CreateListHeroes(n, listHeroes);
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArg = command.Split(" - ");
                string action = commandArg[0];
                string heroName = commandArg[1];
                int indexOfHero = listHeroes.IndexOf(listHeroes.Single(i => i.HeroName == heroName));
                Heroes hero = listHeroes[indexOfHero];
                if (action == "CastSpell")
                {
                    CastSpell(commandArg, heroName, hero);

                }
                else if (action == "TakeDamage")
                {
                    TakeDemage(listHeroes, commandArg, heroName, hero);

                }
                else if (action == "Recharge")
                {
                    Recharge(commandArg, heroName, hero);

                }
                else if (action == "Heal")
                {
                    Heal(commandArg, heroName, hero);

                }
            }
            List<Heroes> sortedList = listHeroes;
            foreach (var hero in sortedList)
            {
                Console.WriteLine($"{hero.HeroName}");
                Console.WriteLine($"  HP: {hero.HealthPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        private static void CreateListHeroes(int n, List<Heroes> listHeroes)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroNames = input[0];
                int health = int.Parse(input[1]);
                int mana = int.Parse(input[2]);
                Heroes heroH = new Heroes(heroNames, health, mana);
                listHeroes.Add(heroH);
            }
        }

        private static void CastSpell(string[] commandArg, string heroName, Heroes hero)
        {
            int manaNeeded = int.Parse(commandArg[2]);
            string spellName = commandArg[3];
            int cuurentMana = hero.ManaPoints;
            if (cuurentMana >= manaNeeded)
            {
                hero.ManaPoints -= manaNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
        private static void TakeDemage(List<Heroes> listHeroes, string[] commandArg, string heroName, Heroes hero)
        {
            int damage = int.Parse(commandArg[2]);
            string attacker = commandArg[3];
            if (hero.HealthPoints > damage)
            {
                hero.HealthPoints -= damage;
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hero.HealthPoints} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                listHeroes.Remove(hero);
            }
        }
        private static void Heal(string[] commandArg, string heroName, Heroes hero)
        {
            int amount = int.Parse(commandArg[2]);
                if (amount + hero.HealthPoints > 100)
                {
                    amount = 100 - hero.HealthPoints;
                }
                hero.HealthPoints += amount;

                Console.WriteLine($"{heroName} healed for {amount} HP!");
        }
        private static void Recharge(string[] commandArg, string heroName, Heroes hero)
        {
            int amount = int.Parse(commandArg[2]);
                if (amount + hero.ManaPoints > 200)
                {
                    amount = 200 - hero.ManaPoints;
                }
                hero.ManaPoints += amount;
                Console.WriteLine($"{heroName} recharged for {amount} MP!");
        }
    }
    public class Heroes
    {
        public Heroes(string heroNames, int health, int mana)
        {
            HeroName = heroNames;
            HealthPoints = health;
            ManaPoints = mana;
        }

        public string HeroName { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }

    }

}   
