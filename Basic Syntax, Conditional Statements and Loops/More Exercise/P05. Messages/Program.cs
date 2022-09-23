using System;

namespace P05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input n
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;
            //read input to message
            for (int i = 1; i <= n; i++)
            {
                string numberRepresentLetter = Console.ReadLine();

                int numberOfDigits = numberRepresentLetter.Length;

                int getNumber = int.Parse(numberRepresentLetter);
                int mainDigit = getNumber % 10;
                if (mainDigit == 0)
                {
                    word += " ";
                    continue;
                }

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int laterIndex = offset + numberOfDigits - 1;
                int asciiCodeA = (int)'a';

                char output = (char)(asciiCodeA + laterIndex);

                word += output;
            }
            Console.Write(word);
        }
    }
}
