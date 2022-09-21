namespace P04._Print_and_sum
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            //Varable for seva sum date
            int sumAllNumber = 0;

            //Print all number and sum of all number 
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i} ");
                sumAllNumber += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumAllNumber}");
        }
    }
}
