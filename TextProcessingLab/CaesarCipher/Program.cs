using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (char letter in text)
            {
                char encryptedChar = (char)(letter + 3);

                encryptedText.Append(encryptedChar);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
