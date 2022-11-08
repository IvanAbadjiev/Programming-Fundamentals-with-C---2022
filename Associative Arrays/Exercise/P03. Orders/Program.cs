﻿namespace P03._Orders
{
    using System;
    using System.Collections.Generic;

    namespace Orders
    {
        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<string, decimal> price = new Dictionary<string, decimal>();
                Dictionary<string, decimal> quantity = new Dictionary<string, decimal>();
                string[] oneProduct = Console.ReadLine().Split(' ');

                while (oneProduct[0] != "buy")
                {

                    if (price.ContainsKey(oneProduct[0]) == false)
                    {
                        price.Add(oneProduct[0], decimal.Parse(oneProduct[1]));
                        quantity.Add(oneProduct[0], decimal.Parse(oneProduct[2]));

                    }
                    else
                    {
                        //if (price[oneProduct[0]] > decimal.Parse(oneProduct[1]))

                        price[oneProduct[0]] = decimal.Parse(oneProduct[1]);

                        quantity[oneProduct[0]] += decimal.Parse(oneProduct[2]);
                    }

                    oneProduct = Console.ReadLine().Split(" ");
                }

                foreach (var item in price)
                {
                    decimal sum = item.Value * quantity[item.Key];

                    Console.WriteLine($"{item.Key} -> {sum}");
                }

            }
        }
    }
}
    