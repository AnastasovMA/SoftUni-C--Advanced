using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrix =
            {
                {1,2}, // -> row 0 
                {3,4}  // -> row 1
            };

            int element1 = intMatrix[1, 1]; // --> Getting Element Value
            Console.WriteLine(element1);

            int[,] matrix = new int[3, 4];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row + col; // -> Setting Element Value
                    //Console.Write($"{ matrix[row, col]} "); // -> Printing Matrix
                }
                //Console.WriteLine();
            }
        }
    }
}
