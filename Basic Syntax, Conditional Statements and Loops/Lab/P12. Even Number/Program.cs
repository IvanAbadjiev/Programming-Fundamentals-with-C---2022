using System;

namespace P12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int curentNumber = Math.Abs(int.Parse(Console.ReadLine()));

                if (curentNumber % 2 == 0)
                {
                    Console.WriteLine($"The number is: {curentNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
