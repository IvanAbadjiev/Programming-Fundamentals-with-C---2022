using System;

namespace P10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int theNumberOfMultiplicationTable = int.Parse(Console.ReadLine());

            //for loop for printing and calculation
            for (int i = 1; i <= 10; i++)
            {

                //print result
                Console.WriteLine($"{theNumberOfMultiplicationTable} X {i} = {theNumberOfMultiplicationTable * i}");
            }

        }
    }
}
