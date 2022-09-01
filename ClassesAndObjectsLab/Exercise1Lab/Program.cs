using System;

namespace Exercise1Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(words.Length); // returns a non-negative integer in the Range we put it

                string word = words[i];
                words[i] = words[pos];
                words[pos] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
            //Environment.NewLine - gets the string at a new Line
        }
    }
}
