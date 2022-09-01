using System;
using System.Linq;

namespace TextProcessingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', ',', '.' };
            string text = "Hello, I am John";
            string[] words = text.Split(separators);
            ;
        }
    }
}
