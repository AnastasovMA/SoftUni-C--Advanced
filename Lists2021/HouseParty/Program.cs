using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
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
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] commands = line.Split();
                int count = int.Parse(commands[2]); 

                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int num = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        numbers.Insert(index, num);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "Shift left":
                        for (int i = 0; i < count; i++)
                        {
                            int firstElement = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstElement);
                        }
                        break;

                    case "Shift right":
                        int lastElement = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastElement);
                        numbers.RemoveAt(numbers.Count-1);

                        break;
                        //2 3 4 1 - 1 2 3 4 - right 4 1 2 3
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
