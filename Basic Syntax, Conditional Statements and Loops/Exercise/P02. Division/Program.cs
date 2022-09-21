namespace P02._Division
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int number = int.Parse(Console.ReadLine());
            //Verable for save date
            string output = string.Empty;


            //Validate number divide by 10 7 6 3 2
            if (number % 10 == 0)
            {
                output = "The number is divisible by 10";
            }
            else if (number % 7 == 0)
            {
                output = "The number is divisible by 7";
            }
            else if (number % 6 == 0)
            {
                output = "The number is divisible by 6";
            }
            else if (number % 3 == 0)
            {
                output = "The number is divisible by 3";
            }
            else if (number % 2 == 0)
            {
                output = "The number is divisible by 2";
            }
            else
            {
                output = "Not divisible";
            }

            //Print result 
            Console.WriteLine(output);

        }
    }
}
