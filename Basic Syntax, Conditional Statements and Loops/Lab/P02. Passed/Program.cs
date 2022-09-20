using System;

namespace P02._Passed
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
                //Print result
                Console.WriteLine("Passed!");
            }
            else
            {
                //No output
            }
        }
    }
}
