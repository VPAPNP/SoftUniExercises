using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputCol = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputCol[col];
                }
            }
            int countRemoved = 0;
           
            while (true)
            {
                               
                int mostAttaked = 0;
                int mostAtRow = 0;
                int mostAtCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                   

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int knightsAtacked = 0;
                        if (matrix[row, col] == 'K')
                        {
                            //Vertical
                                //DownRight
                            if (IsValidCoordinate(matrix, row+2, col+1) && matrix[row+2, col+1] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //DownLeft
                            if (IsValidCoordinate(matrix, row + 2, col - 1) && matrix[row + 2, col -1] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //UpRight
                            if (IsValidCoordinate(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //UpLeft
                            if (IsValidCoordinate(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //Horizontal
                            //LeftDown
                            if (IsValidCoordinate(matrix, row  +1, col  -2) && matrix[row + 1, col - 2] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //RightDown
                            if (IsValidCoordinate(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //LeftUp
                            if (IsValidCoordinate(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                knightsAtacked++;
                            }
                            //RightUp
                            if (IsValidCoordinate(matrix, row -1, col + 2) && matrix[row -1, col + 2] == 'K')
                            {
                                knightsAtacked++;
                            }
                            if (mostAttaked < knightsAtacked)
                            {

                                mostAttaked = knightsAtacked;
                                mostAtRow = row;
                                mostAtCol = col;
                            }

                        }
                        
                    }
                }
                if(mostAttaked == 0)
                {

                    break;
                }
                else
                {
                    matrix[mostAtRow, mostAtCol] = '0';
                    countRemoved++;
                   
                }
                
            }
            Console.WriteLine(countRemoved);
            
              
        }
        public static bool IsValidCoordinate(char[,]matrix,int row,int col)
        {
            bool isVaild = false;
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col< matrix.GetLength(1) )
            {
                isVaild= true;
            }
            return isVaild;
        }
        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
        
    }
}
