using System;

namespace T02_Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(" ");
            string[] second = Console.ReadLine()
                .Split(" ");



            Console.WriteLine(String.Join ( " ",first));
            Console.WriteLine(String.Join(" ",second));



        }
    }
}
