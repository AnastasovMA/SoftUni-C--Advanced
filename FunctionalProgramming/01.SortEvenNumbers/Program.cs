using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> isUpperCase = word => char.IsUpper(word[0]);
            
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                if (isUpperCase(currentWord))
                {
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}
