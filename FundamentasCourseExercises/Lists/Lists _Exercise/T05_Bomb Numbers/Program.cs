using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace T05_Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = command[0];
            int power = Math.Abs(command[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i >= 0)
                {
                    if (numbers[i] == command[0])
                    {
                        int start = i - power;
                        if (start < 0)
                        {
                            start = 0;
                        }
                        int finish = i + power;
                        if (finish > numbers.Count)
                        {
                            finish = numbers.Count;
                        }
                        for (int k = start; k <= finish; k++)
                        {
                            numbers.RemoveAt(start);
                            i--;
                        }
                    }
                }
                {


                }


                
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
