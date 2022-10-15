namespace P02._Grades
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //receves grade 
            double grade = double.Parse(Console.ReadLine());

            string printGradeLevel = ChecksGradeLevel(grade);

            Console.WriteLine(printGradeLevel);

        }

        static string ChecksGradeLevel(double grade)
        {
            string gradeLevel = string.Empty;
            if (grade >= 2.00 && grade <= 2.99)
            {
                gradeLevel = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                gradeLevel = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                gradeLevel = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                gradeLevel = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeLevel = "Excellent";
            }

            return gradeLevel;


        }
    }
}
