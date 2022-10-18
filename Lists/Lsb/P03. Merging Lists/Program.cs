namespace P03._Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> merging = new List<int>();

            int smallList = Math.Min(first.Count, second.Count);
            for (int i = 0; i < smallList; i++)
            {
                merging.Add(first[i]);
                merging.Add(second[i]);
            }

            int bigList = Math.Max(first.Count, second.Count);
            for (int i = smallList; i < bigList; i++)
            {
                if (first.Count > second.Count)
                {
                    merging.Add(first[i]);
                }
                else if (second.Count > first.Count)
                {
                    merging.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", merging));


        }
    }
}
