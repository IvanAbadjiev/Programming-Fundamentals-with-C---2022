namespace P06._Equal_Sum
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEqual = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                int leftSum = 0;
                int rigthSum = 0;
                for (int j = 0; j <= i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int k = i; k <= numbers.Length - 1; k++)
                {
                    rigthSum += numbers[k];
                }
                if (leftSum == rigthSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }



            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }


        }
    }
}
