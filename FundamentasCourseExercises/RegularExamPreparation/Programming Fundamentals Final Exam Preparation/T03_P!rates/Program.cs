using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T03_P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] commandInfo = command.Split("||");
                string name = commandInfo[0];
                int population = int.Parse(commandInfo[1]);
                int gold = int.Parse(commandInfo[2]);
                City city = new City(name, population, gold);
                if (!cities.Exists(x=> x.Name == name))
                {
                    cities.Add(city);
                }
                else if(cities.Any(x=> x.Name == name))
                {
                    for (int i = 0; i < cities.Count; i++)
                    {
                        if (cities[i].Name == name)
                        {
                            cities[i].Population += population;
                            cities[i].Gold += gold;
                        }
                    }
                }
            }
            string commandSecond;
            while ((commandSecond = Console.ReadLine())!= "End")
            {
                string[] commandInfo = commandSecond.Split("=>");
                string action = commandInfo[0];
                string town = commandInfo[1];
                if (action == "Plunder")
                {
                    int people = int.Parse(commandInfo[2]);
                    int gold = int.Parse(commandInfo[3]);
                    for (int i = 0; i < cities.Count; i++)
                    {
                        if (cities[i].Name == town)
                        {
                            cities[i].Population -= people;
                            cities[i].Gold -= gold;
                            if (cities[i].Population <= 0 || cities[i].Gold <= 0)
                            {
                                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                                Console.WriteLine($"{town} has been wiped off the map!");
                                cities.RemoveAt(i);
                            }
                            else
                            {
                                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                            }
                            break;
                        }
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(commandInfo[2]);
                    for (int i = 0; i < cities.Count; i++)
                    {
                        if (cities[i].Name == town)
                        {
                            if (gold >= 0)
                            {
                                cities[i].Gold += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[i].Gold} gold.");
                            }
                            else
                            {
                                Console.WriteLine("Gold added cannot be a negative number!");
                            }
                        }
                    }
                }
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
    public class City
    {
        public City(string name,int population, int gold) 
        {
            Name= name;
            Population= population;
            Gold= gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

    }

}
