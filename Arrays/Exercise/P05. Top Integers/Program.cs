namespace P05._Top_Integers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                int currNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }

                }
                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }



            }

        }
    }
}
