using System;
using System.Linq;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string rmWord = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(rmWord))
            {
                int index = word.IndexOf(rmWord);
                word = word.Remove(index, rmWord.Length);

            }

            Console.WriteLine(word);
        }
    }
}
