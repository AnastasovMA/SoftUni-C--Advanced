using System;
using System.Linq;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = ReadArrayFromConsole(); // !!!! array of arrays
            }

            string command = Console.ReadLine().ToUpper();

            while (command != "END")
            {
                string[] tokens = command.Split();
                int row = int.Parse(tokens[1]);           // prepare all elements
                int col = int.Parse(tokens[2]);           // prepare all elements
                int value = int.Parse(tokens[3]);         // prepare all elements

                if (row < 0 || row >= n || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().ToUpper();

                    continue;
                }

                switch (tokens[0])
                {
                    case "ADD":
                        jagged[row][col] += value;
                        break;
                    case "SUBTRACT":
                        jagged[row][col] -= value;
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().ToUpper();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        static private int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;
        }
    }
}
