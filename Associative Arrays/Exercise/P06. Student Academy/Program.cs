namespace P06._Student_Academy
{
using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double value = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(value);
            }

            foreach (var kvp in students)
            {
                string studentsName = kvp.Key;
                List<double> grade = kvp.Value;
                double avrgGrade = 0;
                foreach (var grd in grade)
                {
                    avrgGrade += grd;
                }
                avrgGrade /= grade.Count;

                if (avrgGrade >= 4.50)
                {
                    Console.WriteLine($"{studentsName} -> {avrgGrade:f2}");
                }
            }

        }
    }
}
