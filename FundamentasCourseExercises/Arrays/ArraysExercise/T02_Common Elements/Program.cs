using System;
using System.Linq;

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
            string[] newArr1 = " "
                .Split(" ");


            for (int i = 0; i < first.Length; i++)
            {
                string curr = first[i];
            }

            Console.WriteLine(String.Join(" ",first));
            Console.WriteLine(String.Join("", newArr1));
        }
    }
}
