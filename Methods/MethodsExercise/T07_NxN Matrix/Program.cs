using System;
using System.Linq;

namespace T07_NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] result = PrintMatrix(n);
            Console.WriteLine(result);
            
            
        }
        static int[][] PrintMatrix(int input)
        {
            int[][] matrix = new int[input][];
            
            for (int i = 0; i < input; i++)
            {
                
                
                for (int j = 0; j < input; j++)
                {
                    matrix[i][j] = i;
                    
                    
                }
            }     
            
            return matrix;
        }

    }
}
