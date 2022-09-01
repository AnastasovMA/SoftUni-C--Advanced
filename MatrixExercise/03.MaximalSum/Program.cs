using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            int maxSum = int.MinValue;
            int wantedRow = 0;
            int wantedCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = 0;
                    int first = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int second = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int third = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    sum += first + second + third;
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        wantedRow = row;
                        wantedCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[wantedRow, wantedCol]} {matrix[wantedRow, wantedCol + 1]} {matrix[wantedRow, wantedCol + 2]}");
            Console.WriteLine($"{matrix[wantedRow + 1, wantedCol]} {matrix[wantedRow + 1, wantedCol + 1]} {matrix[wantedRow + 1, wantedCol + 2]}");
            Console.WriteLine($"{matrix[wantedRow + 2, wantedCol]} {matrix[wantedRow + 2, wantedCol + 1]} {matrix[wantedRow + 2, wantedCol + 2]}");


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
