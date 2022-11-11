namespace P03._Substring
{
using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digit = new StringBuilder();
            StringBuilder later = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    digit.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    later.Append(item);
                }
                else
                {
                    other.Append(item);
                }
                
                

                

            }
            Console.WriteLine($"{digit}{Environment.NewLine}{later}{Environment.NewLine}{other}");


        }
    }
}
