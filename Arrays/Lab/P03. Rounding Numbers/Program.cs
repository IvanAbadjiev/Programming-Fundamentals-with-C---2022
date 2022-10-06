namespace P03._Rounding_Numbers
{
    using System;
    using System.Linq;

    internal class Program
    {

        static void Main(string[] args)
        {
            //read an array of real numbers
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            //save celing data
            int[] celing = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                celing[i] = (int)Math.Ceiling(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {celing[i]}");
            }



        }
    }
}
