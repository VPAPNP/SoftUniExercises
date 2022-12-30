using System;

namespace T08_Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            for (int row = 1; row <= n; row++)
            {
                if (type == "triangle")
                {
                    int spCount = n - row;
                    for (int spaces = 1; spaces <= spCount; spaces++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int col = 1; col <= row ; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
        }
    }
}
