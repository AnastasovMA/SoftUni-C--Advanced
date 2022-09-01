using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|'); // създава нов масив

            List<string> result = new List<string>(); // добавяме масива в нов лист

            for (int i = arrays.Length - 1; i >= 0; i--) // чете от последния масив към първия
            {
                string[] elements = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                result.AddRange(elements); // добавяме елементите в нашия списък
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
