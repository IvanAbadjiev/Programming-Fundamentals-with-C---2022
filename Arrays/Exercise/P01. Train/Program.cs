namespace P01._Train
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // n -> number of wagons
            int n = int.Parse(Console.ReadLine());
            //save data 
            int sum = 0;
            int[] peopleInwagons = new int[n];

            //wagine people
            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                peopleInwagons[i] = curr;
                sum += curr;
            }
            Console.WriteLine(string.Join(" ", peopleInwagons));
            Console.WriteLine(sum);


        }
    }
}
