using System;
using System.Linq;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(rows, rows);
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < rows; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[rows - 1 - row, row];
            }
            Console.WriteLine($"{Math.Abs(primaryDiagonal - secondaryDiagonal)}");
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
