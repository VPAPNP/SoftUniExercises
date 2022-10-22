using System;

namespace T04_SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCapacity = int.Parse(Console.ReadLine());
            int secondCapacity = int.Parse(Console.ReadLine());
            int thirdCapacity = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int sumCapacity = firstCapacity + secondCapacity + thirdCapacity;
            int neededHours = 0;
            while (students > 0)
            {
               students -= sumCapacity;
                neededHours++;
                if (neededHours% 4 == 0)
                {
                    neededHours++;
                }

            }

            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
