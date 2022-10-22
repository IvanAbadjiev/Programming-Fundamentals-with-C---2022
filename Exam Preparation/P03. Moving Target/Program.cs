using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ");
                string action = cmdArgs[0];

                if (action == "Shoot")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int power = int.Parse(cmdArgs[2]);
                    if (IndexValidator(targets, index))
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if (action == "Add")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if (IndexValidator(targets, index))
                    {
                        targets.Insert(index, value);

                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                }
                else if (action == "Strike")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int radius = int.Parse(cmdArgs[2]);
                    int startIndex = index - radius;
                    int endIndex = index + radius; 
                    if (IndexValidator(targets, index) && IndexValidator(targets, startIndex) && IndexValidator(targets, endIndex))
                    {

                        targets.RemoveRange(startIndex, (radius * 2) + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                 }
            }
            Console.WriteLine(string.Join("|", targets));


        }

        static bool IndexValidator(List<int> targets, int index )
        {
            if (index < 0 || index > targets.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
