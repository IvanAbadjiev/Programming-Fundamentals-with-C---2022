namespace P03._Floating_Equality
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;

            decimal diff = Math.Abs(number2 - number1);

            if (diff >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
