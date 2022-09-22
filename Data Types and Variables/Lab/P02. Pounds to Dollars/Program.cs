namespace P02._Pounds_to_Dollars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            double britishPound = int.Parse(Console.ReadLine());
            const double exchangeRate = 1.31; //1 British Pound = 1.31 Dollars

            //convert to usd
            double usd = britishPound * exchangeRate;

            //Printt result
            Console.WriteLine($"{usd:f3}");

        }
    }
}
