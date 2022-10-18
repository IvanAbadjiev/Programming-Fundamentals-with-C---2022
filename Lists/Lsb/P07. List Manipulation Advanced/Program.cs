using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isChange = false;
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] commandArgs = commands.Split();
                string move = commandArgs[0];

                if (move == "Add")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Add(value);
                    isChange = true;
                }
                else if (move == "Remove")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Remove(value);
                    isChange = true;
                }
                else if (move == "RemoveAt")
                {
                    int index = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(index);
                    isChange = true;
                }
                else if (move == "Insert")
                {
                    int value = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, value);
                    isChange = true;
                }
                else if (move == "Contains")
                {
                    int value = int.Parse(commandArgs[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (move == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (move == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (move == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (move == "Filter")
                {
                    string condition = commandArgs[1];
                    int value = int.Parse(commandArgs[2]);
                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));

                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }


                }


                commands = Console.ReadLine();
            }


            if (isChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
