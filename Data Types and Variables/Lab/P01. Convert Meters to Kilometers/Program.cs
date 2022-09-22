namespace P01._Convert_Meters_to_Kilometers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int meturs = int.Parse(Console.ReadLine());

            //Convert meters to kilometers
            double kilometurs = meturs * 0.001;

            //Print result
            Console.WriteLine($"{kilometurs:f2}");
        }
    }
}
