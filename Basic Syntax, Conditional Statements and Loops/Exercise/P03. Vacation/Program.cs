using System;

namespace P03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int coutOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            //Price data save
            double totalPrice = 0;

            //price calculation
            switch (dayOfTheWeek)
            {
                case "Friday":
                    if (typeOfGroup == "Students")
                    {
                        totalPrice = coutOfPeople * 8.45;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        if (coutOfPeople >= 100)
                        {
                            coutOfPeople -= 10;
                        }

                        totalPrice = coutOfPeople * 10.90;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        totalPrice = coutOfPeople * 15;
                    }
                    break;
                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        totalPrice = coutOfPeople * 9.80;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        if (coutOfPeople >= 100)
                        {
                            coutOfPeople -= 10;
                        }
                        totalPrice = coutOfPeople * 15.60;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        totalPrice = coutOfPeople * 20;
                    }
                    break;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        totalPrice = coutOfPeople * 10.46;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        if (coutOfPeople >= 100)
                        {
                            coutOfPeople -= 10;
                        }
                        totalPrice = coutOfPeople * 16;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        totalPrice = coutOfPeople * 22.50;
                    }
                    break;
                default:
                    break;
            }

            // calculation discounts 
            if (typeOfGroup == "Students" && coutOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeOfGroup == "Regular" && coutOfPeople >= 10 && coutOfPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            //Print result 
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
