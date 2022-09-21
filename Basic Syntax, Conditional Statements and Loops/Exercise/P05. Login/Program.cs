namespace P05._Login
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input
            string username = Console.ReadLine();
            string password = string.Empty; //Password get or username


            //reverse username 
            for (int i = username.Length - 1; i >= 0; i--)
            {
                Char CurentCh = username[i];
                password += CurentCh;
            }

            //Validate login
            int counter = 0; //counter for login
            while (counter < 4)
            {
                //Read password 
                string passwordЕntered = Console.ReadLine();
                if (password == passwordЕntered)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (counter < 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    counter++;
                }

            }

            //validate for block user
            if (counter >= 4)
            {
                Console.WriteLine($"User {username} blocked!");
            }


        }
    }
}
