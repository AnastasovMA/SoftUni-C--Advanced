using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = FillingMatrix(rows, cols);
            int maxSum = int.MinValue;
            int wantedRow = 0;
            int wantedCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        wantedRow = row;
                        wantedCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[wantedRow, wantedCol]} {matrix[wantedRow, wantedCol + 1]}");
            Console.WriteLine($"{matrix[wantedRow + 1, wantedCol]} {matrix[wantedRow + 1, wantedCol + 1]}");
            Console.WriteLine(maxSum);

        }
        public static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        public static int[,] FillingMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] tempArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++) // -> this is how we fill in the matrix
                {
                    matrix[row, col] = tempArray[col];
                }
            }
            return matrix;
        }
    }
}
