using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());


            BigInteger snowbalBest = BigInteger.Zero;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > snowbalBest)
                {
                    snowbalBest = snowballValue;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {snowbalBest} ({bestSnowballQuality})");
        }
    }
}
