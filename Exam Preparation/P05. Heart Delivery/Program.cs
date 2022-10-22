namespace P05._Heart_Delivery
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                   .Split("@", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();

            int cupidIndex = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int jumpLength = int.Parse(cmdArgs[1]);
                cupidIndex += jumpLength;
                if (cupidIndex >= neighborhood.Count)
                {
                    cupidIndex = 0;
                    if (neighborhood[cupidIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                        continue;
                    }
                    neighborhood[cupidIndex] -= 2;
                    if (neighborhood[cupidIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                        continue;
                    }
                }
                else
                {
                    if (neighborhood[cupidIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                        continue;
                    }
                    neighborhood[cupidIndex] -= 2;
                    if (neighborhood[cupidIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                        continue;
                    }
                }


            }
            Console.WriteLine($"Cupid's last position was {cupidIndex}.");

            if (!neighborhood.Any(x => x > 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                List<int> houseCount = new List<int>();
                foreach (var item in neighborhood)
                {
                    if (item > 0)
                    {
                        houseCount.Add(item);
                    }
                }
                Console.WriteLine($"Cupid has failed {houseCount.Count} places.");
            }
                


        }
    }
}
