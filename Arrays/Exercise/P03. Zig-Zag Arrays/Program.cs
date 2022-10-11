namespace P03._Zig_Zag_Arrays
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            //read input n represent number to read
            int n = int.Parse(Console.ReadLine());

            //array save date
            int[] leftSum = new int[n];
            int[] rigthSum = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    leftSum[i - 1] = numbers[0];
                    rigthSum[i - 1] = numbers[1];
                }
                else
                {
                    rigthSum[i - 1] = numbers[0];
                    leftSum[i - 1] = numbers[1];
                }
            }

            Console.WriteLine(string.Join(" ", rigthSum));
            Console.WriteLine(string.Join(" ", leftSum));




        }
    }
}
