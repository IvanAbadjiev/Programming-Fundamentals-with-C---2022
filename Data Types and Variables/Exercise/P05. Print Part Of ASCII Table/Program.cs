using System;

namespace P05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            //for loop to print char with ASCII  code 
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
