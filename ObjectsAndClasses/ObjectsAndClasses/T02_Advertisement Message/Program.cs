using System;
using System.Collections.Generic;

namespace T02_Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> phrase = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> author = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> city = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random random = new Random();
            for (int i = 0; i < input; i++)
            {
                int indexPhrase = random.Next(0, phrase.Count);
                int indexEvent = random.Next(0, events.Count);
                int indexAuthor = random.Next(0, author.Count);
                int indexCity = random.Next(0, city.Count);
                Console.WriteLine($"{phrase[indexPhrase]} {events[indexEvent]} {author[indexAuthor]} – {city[indexCity]}.");

            }

        }
    }

   

       

           
                
        
    
    

}
