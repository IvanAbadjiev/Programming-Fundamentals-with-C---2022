namespace P07._Repeat_String
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeatTime = int.Parse(Console.ReadLine());

            string repeatWord = RepeatWord(word, repeatTime);

            Console.WriteLine(repeatWord);

        }

        static string RepeatWord(string word, int repeatTime)
        {
            string result = string.Empty;
            for (int i = 1; i <= repeatTime; i++)
            {
                result += word;
            }
            return result;

        }
    }
}
