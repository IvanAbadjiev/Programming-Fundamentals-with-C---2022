namespace P05._Students_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] data = command
                    .Split()
                    .ToArray();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];
                //Student newStudent = new Student(firstName, lastName, age, homeTown);
                Student student = students
                   .FirstOrDefault(x => x.FirstName == firstName
                       && x.LastName == lastName);


                if (student != null)
                {
                    student.HomeTown = homeTown;
                    student.Age = age;
                }
                else
                {
                    student = new Student(
                        firstName,
                        lastName,
                        age,
                        homeTown);

                    students.Add(student);
                }



                command = Console.ReadLine();
            }

            string city = Console.ReadLine();
            foreach (Student currentStudent in students
                 .Where(x => x.HomeTown == city))
            {
                Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
            }


        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
