using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = ReadArrayFromConsole();

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;     // there will be MaxNumber at 0,0;
            int maxCol = 0;     // there will be MaxNumber at 0,0;

            for (int row = 0; row < sizes[0] - 1; row++) // to protect ourselves from getting out of the Matrix, we need to cycles until row -1
            {
                for (int col = 0; col < sizes[1] - 1; col++) // !!!!!!!
                {
                    int sum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];

                    if (sum > maxSum) // we save the maximum sum
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]}, {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]}, {matrix[maxRow+1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
