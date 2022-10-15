namespace P03._Calculations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //line of input 
            string command = Console.ReadLine(); //add, multiply, subtract, divide
            int a = int.Parse(Console.ReadLine()); //firstNumber
            int b = int.Parse(Console.ReadLine()); //secondNumber

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
                default:
                    break;
            }

        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
