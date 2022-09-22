using System;

namespace P06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            char synbol1 = char.Parse(Console.ReadLine());
            char synbol2 = char.Parse(Console.ReadLine());
            char synbol3 = char.Parse(Console.ReadLine());

            //print
            Console.WriteLine($"{synbol3} {synbol2} {synbol1}");
        }
    }
}
