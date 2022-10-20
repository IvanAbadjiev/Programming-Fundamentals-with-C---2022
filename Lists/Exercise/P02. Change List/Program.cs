namespace P02._Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string move = cmdArgs[0];
                int element = int.Parse(cmdArgs[1]);

                if (move == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (move == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, element);
                }


            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
