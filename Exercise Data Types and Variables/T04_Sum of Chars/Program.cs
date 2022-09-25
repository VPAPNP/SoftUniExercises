using System;

namespace T04_Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                input = (char)(int)input;
                sum += input;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
