namespace P05._Courses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string corseName = cmdArgs[0];
                string memberName = cmdArgs[1];

                if (!register.ContainsKey(corseName))
                {
                    register[corseName] = new List<string>();
                }
                register[corseName].Add(memberName);
            }


            foreach (var kvp in register)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }

            }
        }
    }
}