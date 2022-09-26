using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double halfN = n / 2.00;
            int deadPokemon = 0;
            while (n >= m)
            {
                n = n - m;
                deadPokemon++;

                if (n == halfN)
                {
                    if (y > 0)
                    {
                        n = n / y;
                    }

                }

            }

            Console.WriteLine(n);
            Console.WriteLine(deadPokemon);
        }
    }
}
