using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int afterAdd = Add(first, second);
            int afterSubtract = Subtract(afterAdd, third);

            Console.WriteLine(afterSubtract);
        }

        static int Add(int one, int two)
        {
            return one + two;
        }

        static int Subtract(int aferAdd, int three)
        {
            return aferAdd - three;
        }
    }
}
