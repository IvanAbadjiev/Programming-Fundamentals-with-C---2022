using System;

namespace P01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input number 
            int number = int.Parse(Console.ReadLine());

            ChecksNumberPositiveNegativeOrZero(number);
        }
        static void ChecksNumberPositiveNegativeOrZero(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative. ");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive. ");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero. "
);
            }
        }
    }
}
