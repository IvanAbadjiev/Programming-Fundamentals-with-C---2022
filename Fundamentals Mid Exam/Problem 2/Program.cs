namespace Problem_2
{
using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();


            string command;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Blacklist")
                {
                    string name = cmdArgs[1];
                    bool foundName = true;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            
                            names[i] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            foundName = false;
                        }

                    }
                    if (foundName)
                    {
                        Console.WriteLine($"{name} was not found.");
                    }


                }
                else if (action == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (ValidateIndex(names, index))
                    {
                        if (names[index] != "Blacklisted" && names[index] != "Lost")
                        {
                            Console.WriteLine($"{names[index]} was lost due to an error.");
                            names[index] = "Lost";
                        }


                    }

                }
                else if (action == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if (ValidateIndex(names, index))
                    { 
                        Console.WriteLine($"{names[index]} changed his username to {newName}."); //add blacklist and lost if else
                        names[index] = newName;
                    }

                }

            }

                int blackCount = 0;
                int lostCount = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == "Blacklisted")
                    {
                        blackCount++;
                    }
                    else if (names[i] == "Lost")
                    {
                        lostCount++;
                    }
                }
            Console.WriteLine($"Blacklisted names: {blackCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", names));

        }
        static bool ValidateIndex(string[] names, int index)
        {
            if (index < 0 || index > names.Length - 1)
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
