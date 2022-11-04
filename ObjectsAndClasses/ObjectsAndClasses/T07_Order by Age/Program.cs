using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T07_Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArg = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = inputArg[0];
                string id = inputArg[1];
                int age = int.Parse(inputArg[2]);
                
                if (people.Any(x=> x.Id == id))
                {
                    for (int i = people.Count -1 ; i > 0; i--)
                    {
                        if (people[i].Id == id)
                        {
                            people[i].Age = age;
                            people[i].Name = name;
                            
                        }
                    }
                    continue;
                }
                Person newPerson = new Person(name,id,age);
                people.Add(newPerson);
            }
            List<Person> oreder = people.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, oreder));
            
        }
    }
    public class Person

    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; } 
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
