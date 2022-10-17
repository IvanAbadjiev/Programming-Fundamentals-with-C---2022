namespace P10._Top_Number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CheckNumberIsTopInt(n);
        }

        static void CheckNumberIsTopInt(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                int copyI = i;
                bool isDivide8 = false;
                bool isOddNumber = false;
                int sum = 0;
                while (copyI != 0)
                {
                    int lastDigit = copyI % 10;
                    sum += lastDigit;
                    if (lastDigit % 2 != 0)
                    {
                        isOddNumber = true;
                    }
                    copyI /= 10;
                }
                if (sum % 8 == 0)
                {
                    isDivide8 = true;
                }


                if (isDivide8 && isOddNumber)
                {
                    Console.WriteLine(i);
                }

            }

        }


    }
}
