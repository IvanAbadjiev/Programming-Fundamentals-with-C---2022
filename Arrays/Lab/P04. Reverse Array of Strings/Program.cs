namespace P04._Reverse_Array_of_Strings
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read console date 
            string[] input = Console.ReadLine()
                .Split();

            // save reverse date
            string[] reverseString = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reverseString[i] = input[input.Length - 1 - i];
            }
            //print reverse
            Console.WriteLine(string.Join(" ", reverseString));


        }
    }
}
