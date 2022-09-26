using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startMining = int.Parse(Console.ReadLine());

            int aliveSpice = 0;
            int dayWork = 0;
            bool mainIsWork = startMining >= 100;
            while (mainIsWork)
            {
                aliveSpice += startMining;

                if (aliveSpice >= 26)
                {
                    aliveSpice -= 26;
                }
                else
                {
                    mainIsWork = startMining >= 100;
                    break;
                }
                startMining -= 10;
                mainIsWork = startMining >= 100;
                dayWork++;
            }

            if (!mainIsWork)
            {

                if (aliveSpice >= 26)
                {
                    aliveSpice -= 26;

                }
            }
            Console.WriteLine(dayWork);
            Console.WriteLine(aliveSpice);

        }
    }
}
