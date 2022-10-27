namespace P01._Randomize_Words
{
using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
              .Split()
              .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < word.Length; i++)
            {
                int rndNum = rnd.Next(0, word.Length);
                string currentWord = word[i];
                string randomWord = word[rndNum];
                word[i] = randomWord;
                word[rndNum] = currentWord;

            }
            Console.WriteLine(string.Join(Environment.NewLine, word));




        }
    }
}
