namespace P01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList(); //integer represents the number of passengers 

            int maxCapacoty = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (comArgs[0] == "Add")
                {
                    int newWagondPeople = int.Parse(comArgs[1]);
                    wagons.Add(newWagondPeople);
                    continue;
                }

                for (int i = 0; i < wagons.Count; i++)
                {
                    int diff = maxCapacoty - wagons[i];
                    int peopleToIncom = int.Parse(comArgs[0]);
                    if (diff >= peopleToIncom)
                    {
                        wagons[i] = wagons[i] + peopleToIncom;
                        break;
                    }
                }


            }
            Console.WriteLine(string.Join(" ", wagons));




        }
    }
}
