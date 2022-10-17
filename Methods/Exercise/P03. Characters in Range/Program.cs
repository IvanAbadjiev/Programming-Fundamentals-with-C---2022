namespace P03._Characters_in_Range
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            PrintCharInRange(one, two);
        }

        static void PrintCharInRange(char start, char end)
        {

            if (end < start)
            {
                int change = end;
                end = start;
                start = (char)change;
            }
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
