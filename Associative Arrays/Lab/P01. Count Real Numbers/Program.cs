namespace P01._Count_Real_Numbers
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> keyValuePairs = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(numbers[i]))
                {
                    keyValuePairs[numbers[i]] = 0;
                }

                keyValuePairs[numbers[i]]++;
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

