using System;

namespace P09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int n = int.Parse(Console.ReadLine());
            //Verable for save date 
            int sumOddNumber = 0;



            //Create a target that reads the numbers
            for (int i = 1; i <= n; i++)
            {


                //check number odd/even
                if (i % 2 != 0)
                {
                    sumOddNumber += i;
                    //Print curent number
                    Console.WriteLine(i);

                }
                else
                {
                    n++;
                }



            }

            //print sum odd number
            Console.WriteLine($"Sum: {sumOddNumber}");
        }
    }
}
