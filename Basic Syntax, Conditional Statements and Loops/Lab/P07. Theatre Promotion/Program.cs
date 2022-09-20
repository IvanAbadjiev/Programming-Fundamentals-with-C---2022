using System;

namespace P07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //Variable to save the data
            string priceOfTickets = string.Empty;

            //Validate price of tickets
            switch (typeOfDay)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        priceOfTickets = "12$";
                    }
                    else if (age > 18 && age <= 64)
                    {
                        priceOfTickets = "18$";
                    }
                    else if (age > 64 && age <= 122)
                    {
                        priceOfTickets = "12$";
                    }
                    else
                    {
                        // if age out of range 0-122
                        priceOfTickets = "Error!";
                    }


                    break;

                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        priceOfTickets = "15$";
                    }
                    else if (age > 18 && age <= 64)
                    {
                        priceOfTickets = "20$";
                    }
                    else if (age > 64 && age <= 122)
                    {
                        priceOfTickets = "15$";
                    }
                    else
                    {
                        // if age out of range 0-122
                        priceOfTickets = "Error!";
                    }


                    break;

                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        priceOfTickets = "5$";
                    }
                    else if (age > 18 && age <= 64)
                    {
                        priceOfTickets = "12$";
                    }
                    else if (age > 64 && age <= 122)
                    {
                        priceOfTickets = "10$";
                    }
                    else
                    {
                        // if age out of range 0-122
                        priceOfTickets = "Error!";
                    }

                    break;
                default:
                    // if type of day not valid
                    priceOfTickets = "Error!";
                    break;
            }

            //Print result
            Console.WriteLine(priceOfTickets);

        }
    }
}
