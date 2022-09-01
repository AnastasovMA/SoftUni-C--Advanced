using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Bloom Bloom Plow")
                {
                    break;
                }
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[0]);
                int col = int.Parse(tokens[1]);

                if (row < 0 || row >= matrix.GetLength(0) && col < 0 || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[row, i]++;
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, col]++;
                }
                matrix[row, col]--;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
