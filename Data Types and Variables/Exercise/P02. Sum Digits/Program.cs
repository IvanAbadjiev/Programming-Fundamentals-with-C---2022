namespace P02._Sum_Digits
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            int number = int.Parse(Console.ReadLine());
            //save date
            int sum = 0;

            //algo for sum digit
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            //print result
            Console.WriteLine(sum);

        }
    }
}
