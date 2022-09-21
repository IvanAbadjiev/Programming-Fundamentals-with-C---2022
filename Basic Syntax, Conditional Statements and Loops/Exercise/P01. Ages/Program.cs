using System;

namespace P01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int year = int.Parse(Console.ReadLine());
            //Verable for save date
            string typePerson = string.Empty; //Output

            //Validate result
            if (year >= 0 && year <= 2)
            {
                typePerson = "baby";
            }
            else if (year >= 3 && year <= 13)
            {
                typePerson = "child";
            }
            else if (year >= 14 && year <= 19)
            {
                typePerson = "teenager";
            }
            else if (year >= 20 && year <= 65)
            {
                typePerson = "adult";
            }
            else if (year >= 65)
            {
                typePerson = "elder";
            }

            //print result
            Console.WriteLine(typePerson);

        }
    }
}
