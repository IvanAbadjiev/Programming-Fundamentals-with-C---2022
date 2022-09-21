using System;

namespace P09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPriceForOne = double.Parse(Console.ReadLine());
            double robesPriceForOne = double.Parse(Console.ReadLine());
            double beltsPriceForOne = double.Parse(Console.ReadLine());


            //Price and discount calcolate 
            double addLightsabers = Math.Ceiling(countOfStudents + countOfStudents * 0.10);
            double priceForAllLightsabers = addLightsabers * lightsabersPriceForOne;

            double freeBelt = countOfStudents / 6;
            double priceForAllBelt = (countOfStudents - freeBelt) * beltsPriceForOne;

            double priceForAllRobers = countOfStudents * robesPriceForOne;


            double total = priceForAllBelt + priceForAllLightsabers + priceForAllRobers;



            if (amountOfMoney >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(amountOfMoney - total):f2}lv more."
);
            }
        }
    }
}
