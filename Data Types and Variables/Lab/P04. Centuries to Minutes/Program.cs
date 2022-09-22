using System;
using System.Numerics;

namespace P04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            long centuroes = long.Parse(Console.ReadLine());

            //Convert to year
            long year = centuroes * 100;

            //Convert to days 
            long days = (long)(year * 365.2422);

            //Convert to hours 
            long hours = days * 24;

            //Convert to minutes
            long minutes = hours * 60;

            //Print result 
            Console.WriteLine($"{centuroes} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
