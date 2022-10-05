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
            foreach(string str in second)
            {
                if (first.Contains(str))
                {
                    Console.Write($"{str} ");
                }
            }




              

        





    


        }
    }
 }
