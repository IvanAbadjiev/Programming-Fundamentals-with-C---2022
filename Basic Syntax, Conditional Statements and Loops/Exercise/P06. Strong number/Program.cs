namespace P06._Strong_number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int number = int.Parse(Console.ReadLine());


            //Varable to save date 
            int copyNumber = number;
            int sumFact = 0;
            while (copyNumber > 0)
            {
                int curentNumber = copyNumber % 10;
                copyNumber /= 10;
                int fact = 1;

                for (int i = fact; i <= curentNumber; i++)
                {
                    fact *= i;
                }
                sumFact += fact;
            }
            // validate print 
            if (sumFact == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
