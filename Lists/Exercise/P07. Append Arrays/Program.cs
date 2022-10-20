namespace P07._Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> number = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<int> output = new List<int>();
            foreach (var str in number)
            {
                output.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }
            Console.WriteLine(string.Join(" ", output));

        }
    }
}
