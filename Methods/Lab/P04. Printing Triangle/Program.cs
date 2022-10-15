namespace P04._Printing_Triangle
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthTriangle = int.Parse(Console.ReadLine());

            PrintFirstLine(lengthTriangle);
            PrintSecondLine(lengthTriangle);


        }

        static void PrintFirstLine(int l)
        {
            for (int i = 1; i <= l; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSecondLine(int l)
        {

            for (int i = l; i > 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

