using System;

namespace P11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int theNumberOfMultiplicationTable = int.Parse(Console.ReadLine());
            int startingPoint = int.Parse(Console.ReadLine());
            //for loop for printing and calculation
            for (int i = startingPoint; i <= 10; i++)
            {

                //print result
                Console.WriteLine($"{theNumberOfMultiplicationTable} X {i} = {theNumberOfMultiplicationTable * i}");
            }

            if (startingPoint > 10)
            {
                Console.WriteLine($"{theNumberOfMultiplicationTable} X {startingPoint} = {theNumberOfMultiplicationTable * startingPoint}");
            }


        }
    }
}
