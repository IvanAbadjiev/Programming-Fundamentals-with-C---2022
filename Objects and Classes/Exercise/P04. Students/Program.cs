namespace P04._Students
{
using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
                    
            }

            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));

        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Grade { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";

        }
    }

}
