using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ints[col];
                }
            }
            int maxSum = int.MinValue;
            int sumRow = 0;
            int sumCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currenSum = matrix[row, col] +       matrix[row,col +1]      + matrix[row, col + 2]+
                                    matrix[row + 1, col]+matrix[row+1, col + 1]+    matrix[row+1, col + 2]
                                  + matrix[row +2, col ]   + matrix[row+2, col + 1]+    matrix[row+2, col + 2];
                    if (currenSum > maxSum) 
                    {
                        maxSum = currenSum;
                        sumRow = row;
                        sumCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = sumRow; row < sumRow +3; row++)
            {
                for (int col = sumCol; col < sumCol+3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
