using System;
using System.Collections.Generic;
using System.Linq;

namespace T06_Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            int sum = 0;
            
            while (first.Sum() > 0 || second.Sum() > 0)
            {
                if (first.Sum() == 0 || second.Sum() == 0)
                {
                    break;
                }
                
                    if (first[0] > second[0])
                    {
                        first.Add(second[0]);
                        second.RemoveAt(0);
                    first.Add(first[0]);
                        first.RemoveAt(0);
                    }
                    else if (first[0] < second[0])
                    {
                        second.Add(first[0]);
                        first.RemoveAt(0);
                    second.Add(second[0]);
                        second.RemoveAt(0);
                    }
                    else if (first[0] == second[0])
                    {
                        first.RemoveAt(0);
                        second.RemoveAt(0);
                    }
                    if (first.Sum() == 0 || second.Sum() == 0)
                    {
                        if (first.Sum() == 0)
                        {
                            sum = second.Sum();
                            Console.WriteLine($"Second player wins! Sum: {sum}");
                        }
                        else
                        {
                            sum = first.Sum();
                            Console.WriteLine($"First player wins! Sum: {sum}");
                        }

                    }
                
                
            }
        }
    }
}
