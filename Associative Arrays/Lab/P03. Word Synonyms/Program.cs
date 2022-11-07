namespace P03._Word_Synonyms
{
using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordAndSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!wordAndSynonyms.ContainsKey(word))
                {
                    wordAndSynonyms.Add(word, new List<string>());
                    
                }

                    wordAndSynonyms[word].Add(synonyms);
                
                
             

            }

            foreach (var item in wordAndSynonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
                
            }

        }
    }
}
