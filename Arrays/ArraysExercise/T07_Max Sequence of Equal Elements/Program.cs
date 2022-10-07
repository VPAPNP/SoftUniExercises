using System;
using System.Linq;

namespace T07_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray(); 
            int equalNumSum = 0;
            int maxSeq = 0;
            int seqElement = 0;
            
            for (int i = 0; i < inputArray.Length -1; i++)
            {

                
                if (inputArray[i] == inputArray[i+1] )
                {
                    equalNumSum++;
                    if (equalNumSum > maxSeq)
                    {
                        maxSeq = equalNumSum;
                        seqElement = inputArray[i];
                    }
                }
                else
                {
                    
                    equalNumSum = 0;
                }
                
                
            }
            for (int i = 0; i <= maxSeq; i++)
            {
                Console.Write($"{seqElement} ");
            }
            
        }
    }
}
