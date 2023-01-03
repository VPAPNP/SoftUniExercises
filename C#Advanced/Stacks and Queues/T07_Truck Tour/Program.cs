using System;
using System.Collections.Generic;
using System.Linq;

namespace T07_Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();
            
            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int liters = data[0];
                int distance = data[1];
                PetrolPump currPetrolPump = new PetrolPump(liters, distance);
                pumps.Enqueue(currPetrolPump);
               
            }
            int counter = 0;
            while(true)
            {
                bool isValid = true;
                int liters = 0;
                
                for (int b = 0; b < pumps.Count; b++)
                {
                    PetrolPump cuur = pumps.Dequeue();
                    liters += cuur.Liters;
                    if (liters < cuur.Distance)
                    {
                        isValid= false;
                    }
                    liters -= cuur.Distance;
                    pumps.Enqueue(cuur);
                   
                    
                }
                if (isValid)
                {
                    break;

                }
                counter++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(counter);

            
            
                     
                
            
        }
        public class PetrolPump
        {
            public PetrolPump(int liters, int distance)
            {
                Liters = liters;
                Distance = distance;
            }

            public int Liters { get; set; }
            public int Distance { get; set; }
        }

    }
}