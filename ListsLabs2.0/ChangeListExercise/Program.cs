using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split(" ");

                if (token.Length == 2)
                {
                    int numberOfInterest = int.Parse(token[1]);
                    numbers.RemoveAll(n => n == numberOfInterest);
                }
                else if (token.Length == 3)
                {
                    int numberToAdd = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    numbers.Insert(index, numberToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
