using System;
using System.Linq;

namespace SumMatrixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++) // in this way we fill up the matrix
            {
                int[] arr = ReadArrayFromConsole();

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            for (int col = 0; col < sizes[1]; col++) // in this way go through the matrix (or each col specifically) to get the sum.
            {
                int sum = 0;

                for (int row = 0; row < sizes[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
