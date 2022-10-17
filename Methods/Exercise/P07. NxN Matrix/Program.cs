namespace P07._NxN_Matrix
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNxnMatrix(n);
        }

        static void PrintNxnMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 2; k <= n; k++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine(n);
            }

        }
    }
}
