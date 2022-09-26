using System;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input 
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            //Operation with numbers
            int operationAdd = number1 + number2;
            int operationDivide = operationAdd / number3;
            long operationMyltiply = operationDivide * number4; //print this 

            //print 
            Console.WriteLine(operationMyltiply);
        }
    }
}
