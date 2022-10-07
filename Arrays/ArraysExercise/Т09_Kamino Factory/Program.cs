using System;
using System.Linq;
using System.Reflection.Metadata;

namespace Т09_Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtSeq = int.Parse(Console.ReadLine());
              string input = Console.ReadLine();
            int seqOfOnes = 0;
            int bigestSeq = 0;
            int startIndex = 0;
            int sumSeq = 0;
            

            while (input != "Clone them")
            {
                if (input != "Clone them!")
                {
                    int[] currDna = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                    for (int i = 0; i < currDna.Length ; i++)
                    {
                        if (currDna[i] != 1)
                        {
                            seqOfOnes = 0;
                            sumSeq =+ currDna[i];
                            startIndex = i;
                            continue;
                        }
                        seqOfOnes++;
                        if (seqOfOnes > bigestSeq)
                        {
                            bigestSeq = seqOfOnes;
                            
                           

                        }
                    }
                    Console.WriteLine(startIndex);
                    
                }
               

                input = Console.ReadLine();
            }
           
        }
    }
}
