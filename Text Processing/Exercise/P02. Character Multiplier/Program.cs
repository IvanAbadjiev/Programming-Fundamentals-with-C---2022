namespace P02._Character_Multiplier
{
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int result = GetCharecterValue(input[0], input[1]);
            Console.WriteLine(result);

        }

        private static int GetCharecterValue(string strOne, string strTwo)
        {
            int minLength = Math.Min(strOne.Length , strTwo.Length);
            int sum = 0;
            for (int i = 0; i < minLength; i++)
            {
                sum += strOne[i] * strTwo[i];
            }

            string bigestStr = strOne;

            if (strTwo.Length > bigestStr.Length)
            {
                bigestStr = strTwo;
            }

            for (int i = minLength; i < bigestStr.Length; i++)
            {
                sum += bigestStr[i];
            }

            return sum;
        }
    }
}
