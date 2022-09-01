using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = FillingMatrix(rows, cols);

            int sum = SumMatrix(matrix);

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        public static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            return sum;
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
