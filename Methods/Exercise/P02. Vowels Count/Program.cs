namespace P02._Vowels_Count
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int vowels = GetVowelsLetars(word);

            Console.WriteLine(vowels);

        }

        static int GetVowelsLetars(string word)
        {
            int vowelsCount = 0;
            char[] vowelsLether = new char[]
            {
                'a',
                'e',
                'i',
                'o',
                'u',
            };

            foreach (char item in word.ToLower())
            {
                if (vowelsLether.Contains(item))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;


        }
    }
}
