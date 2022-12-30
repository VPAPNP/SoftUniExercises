using System;
using System.Numerics;

 namespace T11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
              int nnumBalls = int.Parse(Console.ReadLine());
              BigInteger snowBallValueMax = BigInteger.MinusOne;
            int snowBallSnowMax = int.MinValue;
            int snowBallTimeMax = int.MinValue;
            int snowBallQualityMax = int.MinValue;

            for (int i = 0; i < nnumBalls; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow (snowBallSnow / snowBallTime,snowBallQuality);
                if (snowBallValue > snowBallValueMax)
                {
                    snowBallValueMax = snowBallValue;
                    snowBallQualityMax = snowBallQuality;
                    snowBallTimeMax = snowBallTime;
                    snowBallSnowMax = snowBallSnow;
                }

                
            }
            Console.WriteLine($"{snowBallSnowMax} : {snowBallTimeMax} = {snowBallValueMax} ({snowBallQualityMax})");


        }
    }
}
