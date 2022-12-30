using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace T03_Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> neighborhood = input
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string command;
            int lastPosition = 0;
            while ((command = Console.ReadLine())!= "Love!")
            {
                string[] commandArg = command.Split(' ').ToArray();
                int jumpIndex = int.Parse (commandArg[1]);
                
                lastPosition += jumpIndex;
                if ( lastPosition > neighborhood.Count -1)
                {
                    lastPosition = 0;
                    
                }
                if (lastPosition >= 0 && lastPosition < neighborhood.Count)
                {
                    if (neighborhood[lastPosition] == 0)
                    {
                        Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                        continue;

                    }
                    neighborhood[lastPosition] -= 2;

                    if (neighborhood[lastPosition] == 0)
                    {
                        Console.WriteLine($"Place {lastPosition} has Valentine's day.");

                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (neighborhood.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count(x=> x > 0)} places.");
            }

        }
    }
}
