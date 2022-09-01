using System;
using System.Numerics;

namespace SecondExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ");
            Random rnd = new Random(); // Класа рандом

            for (int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(words.Length); // Слага числото на случайна позиция
                // .Next() - Метод на класа Random, връща винаги 1 число по-малко от дължината.


                string word = words[i]; 
                words[i] = words[pos];
                words[pos] = word; 
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
