namespace P07._Equal_Arrays
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            //read two arrays
            int[] first = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] second = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();


            //save date
            bool isEqual = true;
            int index = 0;
            int sum = 0;
            //find arays rqual
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    sum += first[i];
                }
                else
                {
                    index = i;
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }



        }
    }
}
