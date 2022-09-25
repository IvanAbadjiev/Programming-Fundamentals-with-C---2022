using System;

namespace P08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            //print
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
