namespace P02._English_Name_of_the_Last_Digit
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetEnglishNameOfTheLastDigit(number));

        }

        static string GetEnglishNameOfTheLastDigit(int number)
        {
            //Get last digit 
            int lastDIgit = number % 10;
            //varable to save date 
            string englishName = string.Empty;

            // validate
            switch (lastDIgit)
            {
                case 0:
                    englishName = "zero";
                    break;
                case 1:
                    englishName = "one";
                    break;
                case 2:
                    englishName = "two";
                    break;
                case 3:
                    englishName = "three";
                    break;
                case 4:
                    englishName = "four";
                    break;
                case 5:
                    englishName = "five";
                    break;
                case 6:
                    englishName = "six";
                    break;
                case 7:
                    englishName = "seven";
                    break;
                case 8:
                    englishName = "eight";
                    break;
                case 9:
                    englishName = "nine";
                    break;

                default:
                    break;
            }

            return englishName;
        }
    }
}
