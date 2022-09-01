using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int rows = sizes[0];
            //int cols = sizes[1];

            int[,] matrix = FillingMatrix(rows, rows);
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row, row];
            }
            Console.WriteLine(sum);
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
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
