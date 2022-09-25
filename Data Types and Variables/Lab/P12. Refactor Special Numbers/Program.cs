using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            bool isSpecialNumber = false;
            for (int ch = 1; ch <= number; ch++)
            {
                counter = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", counter, isSpecialNumber);
                sum = 0;
                ch = counter;
            }


        }
    }
}
