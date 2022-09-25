using System;

namespace P09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());

            // print 
            Console.WriteLine($"{symbol1}{symbol2}{symbol3}");
        }
    }
}
