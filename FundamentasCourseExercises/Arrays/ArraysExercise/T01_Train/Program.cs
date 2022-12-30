using System;

namespace T01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsNum = int.Parse(Console.ReadLine());

            int[] peopleNum = new int[wagonsNum];
            int sum = 0;
            for (int i = 0; i < wagonsNum; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleNum[i] = people;
                sum += people;
            }
            Console.WriteLine(String.Join(" ", peopleNum));
            Console.WriteLine(sum);
        }
    }
}
