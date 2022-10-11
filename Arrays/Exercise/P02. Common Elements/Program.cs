
namespace P02._Common_Elements
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //read two arr
            string[] firstElement = Console.ReadLine()
                .Split();

            string[] secondElement = Console.ReadLine()
                .Split();
            //save item
            //string[] equal = new string[];

            //comparison of the two items
            for (int i = 0; i < secondElement.Length; i++)
            {
                string elementOne = secondElement[i];
                for (int j = 0; j < firstElement.Length; j++)
                {
                    if (elementOne == firstElement[j])
                    {

                        Console.Write(secondElement[i] + " ");

                    }
                }
            }


        }
    }
}
