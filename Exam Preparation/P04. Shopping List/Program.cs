namespace P04._Shopping_List
{
using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceriesSeparated = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Urgent")
                {
                    string item = cmdArgs[1];
                    AddItemFirstPosition(groceriesSeparated, item);
                   

                }
                else if (action == "Unnecessary")
                {
                    string item = cmdArgs[1]; 
                    RemoveItemToTheList(groceriesSeparated, item);
                }
                else if (action == "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];
                    ChangeItem(groceriesSeparated, oldItem, newItem);
                }
                else if (action == "Rearrange")
                {
                    string item = cmdArgs[1];
                    MoveList(groceriesSeparated, item);

                }
            }
            Console.WriteLine(string.Join(", ", groceriesSeparated));
        }

        static void  AddItemFirstPosition(List<string> list, string item)
        {
            if (!list.Contains(item))
            {
                list.Insert(0, item);
            }
        }
        static void RemoveItemToTheList (List<string> list, string item)
        {
            list.Remove(item);
        }
        
        static void ChangeItem(List<string> list, string oldItem, string newItem)
        {
            if (list.Contains(oldItem))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == oldItem)
                    {
                        list[i] = newItem;
                    }
                }
            }
        }

        static void MoveList(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                list.Add(item);
            }
        }
    }
}
