using System;

namespace T09_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nPokePower = int.Parse(Console.ReadLine());
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaustion = int.Parse(Console.ReadLine());
            int nPokeStart = nPokePower;
            int targetCount = 0;
            while (nPokePower >= mDistance)
            {
                if (nPokePower == nPokeStart/2 && nPokeStart%2 == 0 && yExhaustion != 0)
                {
                   nPokePower /= yExhaustion;
                }
                if(nPokePower >= mDistance)
                {
                    nPokePower -= mDistance;
                    targetCount++;
                }
                
                
                
            }
            Console.WriteLine(nPokePower);
            Console.WriteLine(targetCount);
        }
    }
}
