using System;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));


            int evenNumber = GetSumOfEvenDigits(number);
            int oddNumber = GetSumOfOddDigits(number);


            Console.WriteLine(GetMultipleOfEvenAndOdd(evenNumber, oddNumber));
        }

        static int GetSumOfEvenDigits(int number)
        {

            int sumEvenDigit = 0;
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    sumEvenDigit += currentDigit;
                }
                number = number / 10;


            }
            return sumEvenDigit;



        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOddDigit = 0;
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    sumOddDigit += currentDigit;
                }
                number = number / 10;


            }
            return sumOddDigit;

        }

        static int GetMultipleOfEvenAndOdd(int even, int odd)
        {
            return even * odd;

        }
    }
}
