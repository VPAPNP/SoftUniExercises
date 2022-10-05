using System;
using System.Linq;


public class Program
{
    public static void Main()
    {

        string[] array1 = Console.ReadLine()
            .Split(" ");
        string[] array2 = Console.ReadLine()
            .Split(" ");
        // Call Intersect extension method.  
        var intersect = array1.Intersect(array2);

        foreach (string value in intersect)
        {
            Console.WriteLine(value);
        }
    }

}   
