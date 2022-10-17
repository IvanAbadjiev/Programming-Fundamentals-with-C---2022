namespace P06._Middle_Characters
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            PrintTheMidleChar(word);
        }

        static void PrintTheMidleChar(string word)
        {
            if (word.Length % 2 != 0)
            {
                char lether = word[word.Length / 2];
                Console.WriteLine(lether);
            }
            else
            {
                char lether = word[word.Length / 2];
                char lether2 = word[word.Length / 2 - 1];
                Console.Write(lether2);
                Console.Write(lether);
            }

        }
    }
}
