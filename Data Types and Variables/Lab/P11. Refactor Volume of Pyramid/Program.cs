using System;

namespace P11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double heihth = double.Parse(Console.ReadLine());

            heihth = (length * width * heihth) / 3;
            Console.WriteLine($"Pyramid Volume: {heihth:f2}");

        }
    }
}
