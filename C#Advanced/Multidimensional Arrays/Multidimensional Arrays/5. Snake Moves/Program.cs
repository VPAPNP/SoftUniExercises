using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            char[,] matrix = new char[rows, cols];
            int textIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row %2 == 0)
                {
                    
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (textIndex == text.Length)
                        {
                            textIndex = 0;
                        }
                        matrix[row, col] = text[textIndex];
                        textIndex++;
                    }
                    
                }
                else
                {
                    
                    for (int col = matrix.GetLength(1) -1; col >= 0 ; col--)
                    {
                        if (textIndex == text.Length)
                        {
                            textIndex = 0;
                        }
                        matrix[row, col] = text[textIndex];
                        textIndex++;
                    }
                    
                }
                

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
