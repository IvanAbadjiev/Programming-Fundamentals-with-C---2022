using System;

namespace P07._Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            //accumulates coins 
            //0.1, 0.2, 0.5, 1 and 2 - Valid coin 
            string coin = Console.ReadLine();


            //Verable to save date
            double moneyAlive = 0.0;
            while (coin != "Start")
            {
                switch (coin)
                {
                    case "0.1":
                        moneyAlive += double.Parse(coin);
                        break;
                    case "0.2":
                        moneyAlive += double.Parse(coin);
                        break;
                    case "0.5":
                        moneyAlive += double.Parse(coin);
                        break;
                    case "1":
                        moneyAlive += double.Parse(coin);
                        break;
                    case "2":
                        moneyAlive += double.Parse(coin);
                        break;
                    default:
                        //Print for a invalid coin
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                coin = Console.ReadLine();
            }

            //Read and receiving products
            string products = Console.ReadLine();
            while (products != "End")
            {
                switch (products)
                {
                    case "Nuts":
                        if (moneyAlive >= 2.00)
                        {
                            moneyAlive -= 2.00;
                            Console.WriteLine($"Purchased nuts");
                            products = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            products = Console.ReadLine();
                            break;
                        }


                        break;
                    case "Water":
                        if (moneyAlive >= 0.70)
                        {
                            moneyAlive -= 0.70;
                            Console.WriteLine($"Purchased water");
                            products = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            products = Console.ReadLine();
                            break;
                        }

                        break;
                    case "Crisps":
                        if (moneyAlive >= 1.50)
                        {
                            moneyAlive -= 1.50;
                            Console.WriteLine($"Purchased crisps");
                            products = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            products = Console.ReadLine();
                            break;
                        }

                        break;
                    case "Soda":
                        if (moneyAlive >= 0.80)
                        {
                            moneyAlive -= 0.80;
                            Console.WriteLine($"Purchased soda");
                            products = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            products = Console.ReadLine();
                            break;
                        }

                        break;
                    case "Coke":
                        if (moneyAlive >= 1.00)
                        {
                            moneyAlive -= 1.00;
                            Console.WriteLine($"Purchased coke");
                            products = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            products = Console.ReadLine();
                            break;
                        }

                        break;


                    default:
                        Console.WriteLine("Invalid product");
                        products = Console.ReadLine();
                        break;
                }


                // products = Console.ReadLine();
            }

            Console.WriteLine($"Change: {moneyAlive:f2}");
        }
    }
}
