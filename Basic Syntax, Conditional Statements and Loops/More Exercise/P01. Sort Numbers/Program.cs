using System;
using System.Collections.Generic;

namespace P01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());


            //sort number 
            List<double> numbers = new List<double>
            {
                number1,
                number2,
                number3
            };
            numbers.Sort();

            //print list
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
