namespace P06._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] commandArgs = commands.Split();
                string move = commandArgs[0];

                if (move == "Add")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Add(value);

                }
                else if (move == "Remove")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Remove(value);
                }
                else if (move == "RemoveAt")
                {
                    int index = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (move == "Insert")
                {
                    int value = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, value);
                }


                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
