namespace P04._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string move = cmdArgs[0];

                if (move == "Add")
                {
                    int value = int.Parse(cmdArgs[1]);
                    number.Add(value);
                }
                else if (move == "Insert")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    if (ValidateIndex(number, index))
                    {
                        number.Insert(index, value);

                    }


                }
                else if (move == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (ValidateIndex(number, index))
                    {
                        number.RemoveAt(index);

                    }
                }
                else if (move == "Shift")
                {
                    string girection = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    if (girection == "left")
                    {
                        ShiftLeft(number, girection, count);
                    }
                    else if (girection == "right")
                    {
                        ShiftRigth(number, girection, count);
                    }



                }



            }
            Console.WriteLine(string.Join(" ", number));
        }

        static bool ValidateIndex(List<int> numbers, int index)
        {
            if (index < 0 || index > numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return false;
            }
            return true;
        }
        static void ShiftLeft(List<int> numbers, string girection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Add(firstNumber);
                numbers.RemoveAt(0);
            }

        }

        static void ShiftRigth(List<int> numbers, string girection, int count)
        {
            for (int i = 0; i < count; i++)
            {

                int lastNumber = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNumber);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
