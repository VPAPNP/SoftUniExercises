using System;

namespace T07_Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow (radius,2)  * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegModel = model;
                }
               


            }
            Console.WriteLine($"{biggestKegModel}");
        }
    }
}
