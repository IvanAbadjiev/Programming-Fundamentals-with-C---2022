namespace P05._Orders
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read inpput 
            string order = Console.ReadLine(); //represent product coffee, water, coke, snacks
            int quantity = int.Parse(Console.ReadLine());

            PrintResult(order, quantity);


        }
        static double CalculatesPrice(string product, int qty)
        {
            double total = 0.00;
            double productPrice = 0.00;
            switch (product)
            {
                case "coffee":
                    productPrice = 1.50;
                    total = qty * productPrice;
                    break;
                case "water":
                    productPrice = 1.00;
                    total = qty * productPrice;
                    break;

                case "coke":
                    productPrice = 1.40;
                    total = qty * productPrice;
                    break;

                case "snacks":
                    productPrice = 2.00;
                    total = qty * productPrice;
                    break;

                default:
                    break;
            }
            return total;

        }

        static void PrintResult(string product, int qty)
        {
            double result = CalculatesPrice(product, qty);
            Console.WriteLine($"{result:f2}");
        }
    }
}
