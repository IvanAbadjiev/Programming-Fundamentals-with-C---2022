namespace P03._House_Party
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> persone = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                // name is going
                if (cmdArgs.Length == 3)
                {
                    if (persone.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    persone.Add(name);
                }//name is not going
                else if (cmdArgs.Length == 4)
                {
                    if (!persone.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    persone.Remove(name);

                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, persone));

        }
    }
}
