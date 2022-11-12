namespace P01._Valid_Usernames
{
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (username.Length > 3 && username.Length <= 16)
                {
                        bool isValid = true;
                    foreach (char ch in username)
                    {
                        if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                        {
                            isValid = false;
                            break;
                        }
                        

                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }

                }
                

            }


        }
    }
}
