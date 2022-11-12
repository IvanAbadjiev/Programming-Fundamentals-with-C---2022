
namespace P04._Caesar_Cipher
{
using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var criptedText = new StringBuilder();
            foreach (char ch in text)
            {
                
                
                    int value = ch + 3;
                    char crip = (char)value;
                    criptedText.Append(crip);
                
               
            }
           string result = criptedText.ToString();
            Console.WriteLine(result);


        }
    }
}
