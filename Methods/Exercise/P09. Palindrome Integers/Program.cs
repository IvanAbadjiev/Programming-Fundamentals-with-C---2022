namespace P09._Palindrome_Integers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CheksIntigerIsPalindrome(input);

        }

        static void CheksIntigerIsPalindrome(string input)
        {

            while (input != "END")
            {
                string reverseInput = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += input[i];
                }
                string normalNumber = input;
                string reverseNumber = reverseInput;

                if (normalNumber == reverseNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }


        }
    }
}
