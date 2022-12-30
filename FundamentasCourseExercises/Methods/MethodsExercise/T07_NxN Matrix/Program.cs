using System;
using System.Linq;

namespace T07_NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
            
            
            
        }
        static void PrintMatrix(int input)
        {
            
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine();


                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                    
                    
                }
            }     
            
            
        }

    }
}
