namespace P07._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            int sequence = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNums = numbers[i];
                int thisSequence = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (currNums == nextNum)
                    {
                        thisSequence++;

                    }
                    else
                    {
                        break;
                    }

                    if (thisSequence > sequence)
                    {

                        start = i;
                        end = j;
                        sequence = thisSequence;
                    }
                }

            }
            //Console.WriteLine(start);
            //Console.WriteLine(end);
            //Console.WriteLine(sequence);
            for (int i = start; i <= end; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
