using System;

namespace P11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input
            int n = int.Parse(Console.ReadLine());

            //save date
            double sum = 0;

            //for loop calculate the price
            for (int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double total = ((days * capsuleCount) * pricePerCapsule);
                sum += total;

                //print
                Console.WriteLine($"The price for the coffee is: ${total:f2}");
            }

            //print
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
