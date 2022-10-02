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
            string[] common = new string[first.Length + second.Length];
            for (int i = 0; i < first.Length; i++)
            {
                string currentFirst = first[i];
                for (int k = 0; k < second.Length; k++)
                {
                    string currentSecond = second[i];
                    if (currentFirst == currentSecond)
                    {
                       common[i] = currentFirst;
                    }
                }
                using System;
                using System.Linq;


public class Program
        {
            public static void Main()
            {

                int[] array1 = { 1, 4, 2, 8, 7 };
                int[] array2 = { 7, 5, 9, 1, 0, 2, 6 };
                // Call Intersect extension method.  
                var intersect = array1.Intersect(array2);

                foreach (int value in intersect)
                {
                    Console.WriteLine(value);
                }
            }
        }

    }



            Console.WriteLine(String.Join ( " ",common));
            



        }
    }
}
