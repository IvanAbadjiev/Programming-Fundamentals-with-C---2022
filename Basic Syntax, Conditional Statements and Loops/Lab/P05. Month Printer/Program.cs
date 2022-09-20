using System;

namespace P05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int numberOfMonth = int.Parse(Console.ReadLine());
            // Variable to save the data
            string month = string.Empty;

            //Swich statmant for select month
            switch (numberOfMonth)
            {
                case 1:
                    month = "January";
                    break;

                case 2:
                    month = "February";
                    break;

                case 3:
                    month = "March";
                    break;

                case 4:
                    month = "April";
                    break;

                case 5:
                    month = "May";
                    break;

                case 6:
                    month = "June";
                    break;

                case 7:
                    month = "July";
                    break;

                case 8:
                    month = "August";
                    break;

                case 9:
                    month = "September";
                    break;

                case 10:
                    month = "October";
                    break;

                case 11:
                    month = "November";
                    break;

                case 12:
                    month = "December";
                    break;

                default:
                    // if number out ot range 1-12
                    month = "Error!";

                    break;
            }

            //Print result 
            Console.WriteLine(month);
        }
    }
}
