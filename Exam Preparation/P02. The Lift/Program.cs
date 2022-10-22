namespace P02.The_Lift
{
using System;
    using System.Collections.Generic;
    using System.Diagnostics.SymbolStore;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            const int maxCapa = 4;
            for (int i = 0; i < lift.Length; i++) //i represent lift wagons  // 
            {
                int curentWagons = lift[i];

                if (curentWagons < maxCapa)
                {
                    int dif = maxCapa - curentWagons;
                    if (people > dif)
                    {
                    lift[i] += dif;
                        people -= dif;
                    }
                    else
                    {
                        lift[i] += people;
                        people -= people;
                    }
                }

            }
            bool isFull = true;
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] == maxCapa)
                {

                }
                else
                {
                    isFull = false;
                }
            }

            if (people <= 0 && isFull)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people <= 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));

            }
            
          
            

            
        }
    }
}
