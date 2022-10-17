namespace P08._Factorial_Division
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            float fact1 = CalculateFactorialOneNumber(one);
            float fact2 = CalculateFactorialTwoNumber(two);

            Console.WriteLine($"{fact1 / fact2:f2}");
        }

        static float CalculateFactorialOneNumber(int one)
        {
            float fact = 1;
            for (int i = 1; i <= one; i++)
            {
                fact = fact * i;
            }
            return fact;


        }
        static float CalculateFactorialTwoNumber(int two)
        {
            float fact = 1;
            for (int i = 1; i <= two; i++)
            {
                fact = fact * i;
            }
            return fact;


        }

    }
}
