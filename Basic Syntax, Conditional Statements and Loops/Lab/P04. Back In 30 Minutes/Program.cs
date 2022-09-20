using System;

namespace P04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //Convert all for minutes and add 30 minutes
            int minToAdd = 30;
            int allMinets = (hours * 60) + minutes + minToAdd; ;

            //Convert to hours and minutes after add 30 minutes

            int hoursAfterAdd = allMinets / 60;
            int minutesAfterAdd = allMinets % 60;

            //Validate
            if (hoursAfterAdd > 23)
            {
                hoursAfterAdd = 0;
            }
            if (minutesAfterAdd > 59)
            {
                hoursAfterAdd++;
            }

            //Print result
            Console.WriteLine($"{hoursAfterAdd}:{minutesAfterAdd:d2}");
        }
    }
}
