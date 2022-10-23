namespace Problem_1
{
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal singleEggPrice = decimal.Parse(Console.ReadLine());
            decimal sigleAprons = decimal.Parse(Console.ReadLine());

            decimal studentMoreAprons = Math.Ceiling(students * 0.20m + students);
            

            decimal allApronsPrice = sigleAprons * studentMoreAprons;
            decimal allEggPrce = (singleEggPrice * 10) * students;

            int flourDiscount = students -  (students / 5);

            decimal allFlourPrice = flourDiscount * flourPrice;


            decimal allMoneyCost = allApronsPrice + allEggPrce + allFlourPrice;

            if (allMoneyCost <= budget)
            {
                Console.WriteLine($"Items purchased for {allMoneyCost:f2}$.");
            }
            else
            {
                decimal diff = Math.Abs(budget - allMoneyCost);
                Console.WriteLine($"{diff:f2}$ more needed.");
            }


        }
    }
}
