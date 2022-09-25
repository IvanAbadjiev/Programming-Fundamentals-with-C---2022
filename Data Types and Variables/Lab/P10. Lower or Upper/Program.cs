using System;

namespace P10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            char letter = char.Parse(Console.ReadLine());

            //validate uper of lower
            if (letter >= 65 && letter <= 90)
            {
                //uper print
                Console.WriteLine("upper-case");
            }
            else if (letter >= 97 && letter <= 122)
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
