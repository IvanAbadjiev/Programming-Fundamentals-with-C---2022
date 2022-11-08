namespace P01._Count_Chars_in_a_String
{
using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (ch != ' ')
                {
                    if (!keyValuePairs.ContainsKey(ch))
                    {
                        keyValuePairs[ch] = 0;
                    }
                    keyValuePairs[ch] += 1;

                }

            }

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
