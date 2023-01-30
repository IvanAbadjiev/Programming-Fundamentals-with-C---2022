namespace P01._Secret_Chat
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string messages = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    messages = messages.Insert(index, " ");
                    Console.WriteLine(messages);

                }
                else if (action == "Reverse")
                {
                    string substring = cmdArgs[1];
                    int starIndex = messages.IndexOf(substring);
                    int count = substring.Length;
                    if (messages.Contains(substring))
                    {
                        messages = messages.Remove(starIndex, count);
                        messages += string.Join("", substring.Reverse());
                        Console.WriteLine(messages);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (messages.Contains(substring))
                    {
                        messages = messages.Replace(substring, replacement);
                        Console.WriteLine(messages);
                    }

                }
            }
            Console.WriteLine($"You have a new text message: {messages}");


        }
    }
}
