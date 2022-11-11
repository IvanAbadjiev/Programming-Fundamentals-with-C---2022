using System;
using System.Text;

namespace P02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int repeatTime = word.Length;
                for (int i = 0; i < repeatTime; i++)
                {
                    result.Append(word);
                }


            }
            Console.WriteLine(result);


        }
    }
}
