using System;

namespace _01.RandomiseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int wordIndex = random.Next(words.Length);

                string word = words[i];
                words[i] = words[wordIndex];
                words[wordIndex] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
