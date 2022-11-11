using System;

namespace P04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();


            foreach (var danWord in banedWords)
            {
                if (text.Contains(danWord))
                {
                    text = text.Replace(danWord, new string('*', danWord.Length));
                }

            }
            Console.WriteLine(text);


        }
    }
}
