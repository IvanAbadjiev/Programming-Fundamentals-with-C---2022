namespace P03._Elevator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            //read input 
            int numberOfPersone = int.Parse(Console.ReadLine());
            int capacityOfpersons = int.Parse(Console.ReadLine());

            //calculate courses
            int courses = (int)Math.Ceiling((double)numberOfPersone / capacityOfpersons);



            Console.WriteLine(courses);

        }
    }
}
