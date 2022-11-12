namespace P03._Extract_File
{
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string[] fileDate = filePath[filePath.Length - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {fileDate[0]}");
            Console.WriteLine($"File extension: {fileDate[1]}");


        }
    }
}
