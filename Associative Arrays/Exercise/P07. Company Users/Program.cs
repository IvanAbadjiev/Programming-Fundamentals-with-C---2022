namespace P07._Company_Users
{
using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {

            string command;

            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string id = cmdArgs[1];

                if (!register.ContainsKey(companyName))
                {
                    register[companyName] = new List<string>();
                }
               
                    if (!register[companyName].Any(x => x == id))
                    {
                        register[companyName].Add(id);
                    }
                

               

            }

            foreach (var kvp in register)
            {
                string companyName = kvp.Key;
                List<string> id = kvp.Value;

                Console.WriteLine(companyName);
                foreach (var item in id)
                {
                    Console.WriteLine($"-- {item}");
                }

            }

        }
    }
}
