namespace P03._Exact_Sum_of_Real_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int n = int.Parse(Console.ReadLine());
            //Save data verable
            decimal totalSum = 0;

            //For loop to read more input
            for (int i = 1; i <= n; i++)
            {
                decimal curentNumber = decimal.Parse(Console.ReadLine());


                totalSum += curentNumber;
            }

            //print
            Console.WriteLine(totalSum);
        }
    }
}
