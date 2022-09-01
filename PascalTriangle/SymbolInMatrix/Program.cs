using System;

namespace symbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char wantedChar = char.Parse(Console.ReadLine());
            bool isFound = false;
            int wantedRow = 0;
            int wantedCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == wantedChar)
                    {
                        wantedRow = row;
                        wantedCol = col;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{wantedChar} does not occur in the matrix");
            }
            else
            {
                Console.WriteLine($"({wantedRow}, {wantedCol})");
            }
        }
    }
}