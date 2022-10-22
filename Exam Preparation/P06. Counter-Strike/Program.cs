namespace P06._Counter_Strike
{
using System;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks.Dataflow;

    internal class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());

            string command;
            int batlleCount = 0;    
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int costEnergi = int.Parse(command);
                if (energy < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {batlleCount} won battles and {energy} energy");
                    Environment.Exit(0);
                }
               
                    energy -= costEnergi;
                    batlleCount++;
                
                if (batlleCount % 3 == 0)
                {
                    energy += batlleCount;
                }
            }

            Console.WriteLine($"Won battles: {batlleCount}. Energy left: {energy}");

        }
    }
}
