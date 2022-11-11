namespace P05._Digits__Letters_and_Other
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
                int startIndex = text.IndexOf(word);
               text = text.Remove(startIndex, word.Length);


            }
            Console.WriteLine(text);

        }
    }
}
