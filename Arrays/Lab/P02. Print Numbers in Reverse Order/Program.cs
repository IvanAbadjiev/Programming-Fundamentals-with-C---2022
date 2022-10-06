namespace P02._Print_Numbers_in_Reverse_Order
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // qty number
            int n = int.Parse(Console.ReadLine());

            //array to save date to for loop
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentDygit = int.Parse(Console.ReadLine());
                numbers[i] = currentDygit;
            }
            //revers data 
            int[] reverse = new int[numbers.Length];

            //reverse array
            for (int i = 0; i < numbers.Length; i++)
            {
                reverse[i] = numbers[numbers.Length - 1 - i];
            }

            //print reverse
            Console.WriteLine(string.Join(" ", reverse));
        }
    }
}
