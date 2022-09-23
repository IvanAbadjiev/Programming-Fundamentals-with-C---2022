using System;

namespace P03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input 
            double currentBalanceMoney = double.Parse(Console.ReadLine());

            double totalSum = 0;
            bool isPrint = true;
            // read game
            string game = Console.ReadLine();
            while (game != "Game Time")
            {


                switch (game)
                {
                    case "OutFall 4":
                        if (currentBalanceMoney >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 39.99;
                            totalSum += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }


                        break;
                    case "CS: OG":
                        if (currentBalanceMoney >= 15.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 15.99;
                            totalSum += 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalanceMoney >= 19.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 19.99;
                            totalSum += 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalanceMoney >= 59.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 59.99;
                            totalSum += 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalanceMoney >= 29.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 29.99;
                            totalSum += 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalanceMoney >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            currentBalanceMoney -= 39.99;
                            totalSum += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalanceMoney <= 0)
                {
                    Console.WriteLine("Out of money!");
                    isPrint = false;
                    break;
                }
                game = Console.ReadLine();
            }

            if (isPrint)
            {
                Console.WriteLine($"Total spent: ${totalSum:f2}. Remaining: ${currentBalanceMoney:f2}");
            }
        }
    }
}
