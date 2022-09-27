using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decryptingMesage = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char curentChar = char.Parse(Console.ReadLine());

                int decrypting = (int)curentChar + key;

                curentChar = (char)decrypting;

                decryptingMesage += curentChar;

            }
            Console.Write(decryptingMesage);
        }
    }
}
