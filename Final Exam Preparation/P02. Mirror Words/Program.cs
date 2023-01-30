namespace P02._Mirror_Words
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patturn = "([@|#])(?<wordOne>[A-Za-z]{3,})(\\1){2}(?<wordTwo>[A-Za-z]{3,})(\\1)";
            var dictionary = new Dictionary<string, string>();
            Regex regex = new Regex(patturn);

            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match word in matchCollection)
            {
                string wordOne = word.Groups["wordOne"].Value;
                string wordTwo = word.Groups["wordTwo"].Value;



                if (WordYesOrNot(wordOne, wordTwo))
                {

                    dictionary.Add(wordOne, wordTwo);

                }


            }
            if (dictionary.Count > 0)
            {

                Console.WriteLine($"{matchCollection.Count} word pairs found!");
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach (var kvp in dictionary)
                {

                    count++;
                    Console.Write(kvp.Key + " <=> " + kvp.Value);
                    if (count < dictionary.Count)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                if (matchCollection.Count > 0)
                {
                    Console.WriteLine($"{matchCollection.Count} word pairs found!");

                }
                else
                {
                    Console.WriteLine("No word pairs found!");
                }
                Console.WriteLine("No mirror words!");
            }

        }




        static bool WordYesOrNot(string wordOne, string wordTwo)
        {
            wordOne = string.Join("", wordOne.Reverse());
            if (wordOne == wordTwo)
            {
                return true;
            }
            else
            {
                return false;
            }

            wordOne = string.Join("", wordOne.Reverse());
            wordTwo = string.Join("", wordTwo.Reverse());
            if (wordOne == wordTwo)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
