using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> rawNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>();

            int startIndex = 0;
            int lastIndex = rawNumber.Count - 1;
            for (int i = 0; i <= lastIndex / 2; i++)
            {
                int sum = rawNumber[startIndex] + rawNumber[lastIndex];

                numbers.Add(sum);

                startIndex++;
                lastIndex--;

            }

            if (rawNumber.Count % 2 != 0)
            {
                numbers.Add(rawNumber[rawNumber.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
