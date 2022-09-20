using System;

namespace P03._Passed_or_Failed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            double grade = double.Parse(Console.ReadLine());

            // Validate result
            if (grade >= 3.00)
            {
                //Print result 1
                Console.WriteLine("Passed!");
            }
            else if (grade < 3.00)
            {
                //Print result 2
                Console.WriteLine("Failed!");
            }
        }
    }
}
