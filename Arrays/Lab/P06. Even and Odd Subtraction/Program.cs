namespace P06._Even_and_Odd_Subtraction
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {

            //read input number 
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //save date for sum even umber
            int sumEven = 0;
            int sumOdd = 0;
            // sort even or odd 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
