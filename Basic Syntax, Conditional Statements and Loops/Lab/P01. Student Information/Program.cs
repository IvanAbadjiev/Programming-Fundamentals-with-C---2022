using System;

namespace P01._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            //Print output
            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");

        }
    }
}
