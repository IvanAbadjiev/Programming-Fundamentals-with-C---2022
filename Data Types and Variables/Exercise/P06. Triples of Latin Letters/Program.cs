using System;

namespace P06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                //Console.Write(firstChar);
                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);
                    // Console.Write(secondChar);
                    for (int k = 0; k < n; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        //Console.Write(thirdChar);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }

                }




            }
        }


    }
}

