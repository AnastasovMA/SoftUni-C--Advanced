using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
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

                if (line == "end")
                {
                    break;
                }

                string[] command = line.Split();

                switch (command[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(command[1]);
                        numbers.RemoveAll(n => n == numberToDelete);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int positionToInsert = int.Parse(command[2]);
                        numbers.Insert(positionToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
