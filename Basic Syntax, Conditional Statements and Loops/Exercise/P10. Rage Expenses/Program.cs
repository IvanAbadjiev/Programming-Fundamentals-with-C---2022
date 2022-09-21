using System;

namespace P10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //Counter for broken product
            int headset = 0;
            int mouse = 0;
            int keybord = 0;
            int display = 0;

            // for loop to fint broken product
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headset++;
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keybord++;
                }
                if (i % 12 == 0)
                {
                    display++;
                }

            }
            //calcolate price
            double total =
                (headset * headsetPrice) +
                (mouse * mousePrice) +
                (keybord * keybordPrice) +
                (display * displayPrice);

            //print result
            Console.WriteLine($"Rage expenses: {total:f2} lv.");

        }
    }
}
