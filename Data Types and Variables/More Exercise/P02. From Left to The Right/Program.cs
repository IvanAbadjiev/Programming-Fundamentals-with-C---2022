namespace P02._From_Left_to_The_Right
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //number that represents how many lines we will get as input
            int n = int.Parse(Console.ReadLine());
            //varable to save date 

            for (int i = 0; i < n; i++)
            {
                string[] arrNumber = Console.ReadLine().Split(' ');

                long number1 = long.Parse(arrNumber[0]);
                long number2 = long.Parse(arrNumber[1]);


                if (number1 > number2)
                {
                    long numberOneSum = 0;
                    while (number1 != 0)
                    {
                        long currentLastDigit = number1 % 10;
                        number1 /= 10;
                        numberOneSum += currentLastDigit;
                    }
                    Console.WriteLine(Math.Abs(numberOneSum));
                }
                else
                {
                    long numberTwoSum = 0;
                    while (number2 != 0)
                    {
                        long currentLastDigit = number2 % 10;
                        number2 /= 10;
                        numberTwoSum += currentLastDigit;
                    }
                    Console.WriteLine(Math.Abs(numberTwoSum));

                }

            }


        }
    }
}
