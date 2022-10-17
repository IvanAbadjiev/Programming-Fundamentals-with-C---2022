namespace P01._Smallest_of_Three_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            int smallestNUmber = GetSmallestNumber(first, second, third);

            Console.WriteLine(smallestNUmber);

        }

        static int GetSmallestNumber(int one, int two, int thre)
        {
            if (one <= two && one <= thre)
            {
                return one;
            }
            else if (two <= one && two <= thre)
            {
                return two;
            }
            else if (thre <= one && thre <= two)
            {
                return thre;
            }

            return 0;

        }
    }
}
