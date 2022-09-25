using System;

namespace P07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            string midle = Console.ReadLine();

            // print 
            Console.WriteLine($"{name}{midle}{lastName}");
        }
    }
}
