namespace Problem_3
{
using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsDeck = Console.ReadLine()
                  .Split(", ")
                  .ToList();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                string action = cmdArgs[0];

                if (action == "Add")
                {
                    string cardName = cmdArgs[1];
                    if (cardsDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                    cardsDeck.Add(cardName);
                    Console.WriteLine("Card successfully added");

                    }
                }
                else if (action == "Remove")
                {
                    string cardName = cmdArgs[1];
                    if (!cardsDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card not found");
                    }
                    else
                    {
                        cardsDeck.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (action == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (!ValidateIndex(cardsDeck, index))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cardsDeck.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }

                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newCard = cmdArgs[2];

                    if (!ValidateIndex(cardsDeck, index))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        if (cardsDeck.Contains(newCard))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            cardsDeck.Insert(index, newCard);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                   
                }


            }
                Console.WriteLine(string.Join(", ", cardsDeck));


        }
        static bool ValidateIndex(List<string> cardDeck, int index)
        {
            if (index < 0 || index > cardDeck.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
