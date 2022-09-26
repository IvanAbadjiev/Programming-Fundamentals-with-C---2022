using System;

namespace P04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input 
            int n = int.Parse(Console.ReadLine()); // number of  the input char
            //save date
            int sumOfChars = 0;

            //for loop to print char 
            for (int i = 1; i <= n; i++)
            {
                char currCh = char.Parse(Console.ReadLine());

                sumOfChars += (int)currCh;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
