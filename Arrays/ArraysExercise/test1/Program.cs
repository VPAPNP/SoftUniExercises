using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string[] arr1 = Console.ReadLine().Split();
        string[] arr2 = Console.ReadLine().Split();
        foreach (string str in arr2)
        {
            if (arr1.Contains(str))
            {
                Console.Write(str + " ");
            }
        }
    }
}