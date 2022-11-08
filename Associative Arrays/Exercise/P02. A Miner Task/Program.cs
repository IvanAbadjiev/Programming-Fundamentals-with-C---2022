namespace P02._A_Miner_Task
{
using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string resurce;

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            while ((resurce = Console.ReadLine()) != "stop")
            {
                int qty = int.Parse(Console.ReadLine());

                if (!keyValuePairs.ContainsKey(resurce))
                {
                    keyValuePairs[resurce] = 0;
                }
                keyValuePairs[resurce] += qty;
            }

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

            }
        }

    }
}
