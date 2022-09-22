using System;

namespace P05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Read input
            int n = int.Parse(Console.ReadLine());

            //Save date to print
            string trueOrFalse = string.Empty;

            //for loop to find special number -> A number is special when its sum of digits is 5, 7 or 11.
            for (int i = 1; i <= n; i++)
            {
                int copyI = i;
                int sum = 0;
                while (copyI != 0)
                {
                    int curentNumber = copyI % 10;
                    sum += curentNumber;
                    copyI /= 10;

                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    trueOrFalse = "True";
                }
                else
                {
                    trueOrFalse = "False";
                }

                //print
                Console.WriteLine($"{i} -> {trueOrFalse}");

            }
        }
    }
}
