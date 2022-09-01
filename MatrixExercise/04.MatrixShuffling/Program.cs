using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            // "swap row1 col1 row2 col2" 

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                if (tokens[0] != "swap" ||
                    tokens.Length != 5 ||
                    int.Parse(tokens[1]) < 0 ||
                    int.Parse(tokens[1]) >= sizes[0] ||
                    int.Parse(tokens[3]) < 0 ||
                    int.Parse(tokens[3]) >= sizes[0] ||
                    int.Parse(tokens[2]) < 0 ||
                    int.Parse(tokens[2]) >= sizes[1] ||
                    int.Parse(tokens[4]) < 0 ||
                    int.Parse(tokens[4]) >= sizes[0])
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;
                    PrintMatrix(matrix);
                }

                input = Console.ReadLine();
            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] tempArray = ReadArrayFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = tempArray[col];
                }
            }
            return matrix;
        }
    }
}
