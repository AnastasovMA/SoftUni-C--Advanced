using System;
using System.Linq;
using System.Text;

namespace DigitLettersOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder charr = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (char.IsDigit(currentChar))
                {
                    digits.Append($"{currentChar}");
                }
                else if (char.IsLetter(currentChar))
                {
                    letters.Append($"{currentChar}");
                }
                else
                {
                    charr.Append(currentChar);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(charr);
        }
    }
}
