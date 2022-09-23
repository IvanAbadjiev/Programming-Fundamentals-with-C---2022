namespace P04._Reverse_String
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input 
            string word = Console.ReadLine();
            //verable to save reverse string
            string reversWord = string.Empty;

            //for loop to reverse string 
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char currentCh = word[i];
                reversWord += currentCh;

            }

            //print reverse string
            Console.WriteLine(reversWord);
        }
    }
}
