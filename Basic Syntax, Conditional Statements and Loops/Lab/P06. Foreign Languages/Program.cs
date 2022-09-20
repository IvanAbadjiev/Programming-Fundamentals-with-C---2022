using System;

namespace P06._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            string country = Console.ReadLine();
            //Variable to save the data
            string language = string.Empty;

            //Select languge for country with swich case
            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    // if it is none of the above
                    language = "unknown";
                    break;
            }
            //Print result
            Console.WriteLine(language);
        }
    }
}
