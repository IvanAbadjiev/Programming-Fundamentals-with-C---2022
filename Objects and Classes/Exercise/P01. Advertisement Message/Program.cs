namespace P01._Advertisement_Message
{
using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {

            string[] phrases = {
                      "Excellent product."
                    , "Such a great product."
                    , "I always use that product."
                    , "Best product of its category."
                    , "Exceptional product."
                    , "I can't live without this product." };

            string[] events = {
                "Now I feel good."
                , "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!"
                , "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied."
                , "I feel great!" };

            string[] authors = {
                "Diana"
                , "Petya"
                , "Stella"
                , "Elena"
                , "Katya"
                , "Iva"
                , "Annie"
                , "Eva" };

            string[] cities = {
                "Burgas"
                , "Sofia"
                , "Plovdiv"
                , "Varna"
                , "Ruse" };


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ",GetAdvertisementMessage(phrases, events, authors, cities))); 
            }

        }
        static string[] GetAdvertisementMessage(string[] phrases, string[] events,string[] authors, string[] cities)
        {
            Random rnd = new Random();
            string randomPhrases = phrases[rnd.Next(0, phrases.Length)];
            string randomEvents = events[rnd.Next(0, events.Length)];
            string randomAuthors = authors[rnd.Next(0, authors.Length)];
            string randomCities = cities[rnd.Next(0, cities.Length)];

            string[] advertisementMessage =
            {
                randomPhrases,
                randomEvents,
                randomAuthors,
                randomCities
            };
            return advertisementMessage;
            
        }
    }
}
