﻿namespace P02._Big_Factorial
{
using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
