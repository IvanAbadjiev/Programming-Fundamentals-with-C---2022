namespace P04_Refactoring_Prime_Checker
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 && j % 1 == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (!isPrimeNumber)
                {
                    Console.WriteLine($"{i} -> false");

                }
                else
                {
                    Console.WriteLine($"{i} -> true");
                }
            }

        }
    }
}
