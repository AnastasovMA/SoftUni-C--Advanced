using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
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

                string[] tokens = command.Split(" "); // масив с елементи от командата 
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]); // превръщаме елемента в число
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index); // добавяме на мястото на индекса
                        break;
                    case "Insert":
                        int number = int.Parse(tokens[1]);
                        int insertAtIndex = int.Parse(tokens[2]);
                        numbers.Insert(insertAtIndex, number); // означаваме индекса, добавяме число
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
