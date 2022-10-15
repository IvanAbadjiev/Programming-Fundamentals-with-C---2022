using System;

namespace P11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int numbeerB = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(numberA, @operator, numbeerB));
        }

        static double Calculate(int numberA, string @operator, int numberB)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
                default:
                    break;

            }
            return result;
        }




    }
}
