namespace P07._Water_Overflow
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int n = int.Parse(Console.ReadLine());
            //varable to save date for water tank  liters
            int sumWaterTank = 0;
            const int capacitiWaterTank = 255;

            //read water tank lite
            //water tank  capacity 255 l.
            for (int i = 0; i < n; i++)
            {
                int curentWaterLitrs = int.Parse(Console.ReadLine());

                if ((curentWaterLitrs + sumWaterTank) <= capacitiWaterTank)
                {
                    sumWaterTank += curentWaterLitrs;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

            }
            Console.WriteLine(sumWaterTank);


        }
    }
}
