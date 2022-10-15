namespace P08._Math_Power
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            GetPower(@base, power);
        }

        static void GetPower(double @base, double power)
        {
            double result = Math.Pow(@base, power);
            Console.WriteLine(result);

        }
    }
}
