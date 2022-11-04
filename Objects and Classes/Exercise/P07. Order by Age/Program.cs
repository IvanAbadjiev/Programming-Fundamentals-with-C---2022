namespace P07._Order_by_Age
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Person> persons = new List<Person>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string nameOfThePerson = cmdArgs[0];
                string idOfThePersone = cmdArgs[1];
                int ageOfThePersone = int.Parse(cmdArgs[2]);

                Person person = new Person(nameOfThePerson, idOfThePersone, ageOfThePersone);


                if (persons.Any(x => x.Id == idOfThePersone))
                {
                foreach (Person p in persons.Where(x => x.Id == idOfThePersone) )
                {
                    persons.Remove(p);
                    persons.Add(person);
                }

                }
                else
                {
                    persons.Add(person);
                }



            }


            List<Person> ordaredList = persons.OrderBy(x => x.Age).ToList();
            foreach (Person pers in ordaredList)
            {
                Console.WriteLine($"{pers.Name} with ID: {pers.Id} is {pers.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; private set; }
        public string Id { get; private set; }
        public int Age { get; private set; }
    }
}
