using System;
using System.Linq;

namespace SuperMarioExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int marioRow = 0;
            int marioCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                matrix[row] = new char[input.Length];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = input[col];
                    if (matrix[row][col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            bool marioWon = false;

            while (lives > 0)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direction = commands[0];
                int bRow = int.Parse(commands[1]);
                int bCol = int.Parse(commands[2]);
                matrix[bRow][bCol] = 'B';
                lives--;

                switch (direction)
                {
                    case "W":
                        if (marioRow - 1 < 0)
                        {
                            continue;
                        }
                        matrix[marioRow][marioCol] = '-';
                        marioRow--;
                        break;
                    case "S":
                        if (marioRow + 1 >= rows)
                        {
                            continue;
                        }
                        matrix[marioRow][marioCol] = '-';
                        marioRow++;
                        break;
                    case "A":
                        if (marioCol - 1 < 0)
                        {
                            continue;
                        }
                        matrix[marioRow][marioCol] = '-';
                        marioCol--;
                        break;
                    case "D":
                        if (marioCol + 1 >= matrix[marioRow].Length)
                        {
                            continue;
                        }
                        matrix[marioRow][marioCol] = '-';
                        marioCol++;
                        break;
                    default:
                        break;
                }
                if (matrix[marioRow][marioCol] == 'P')
                {
                    matrix[marioRow][marioCol] = '-';
                    marioWon = true;
                    break;
                }
                else if (matrix[marioRow][marioCol] == 'B')
                {
                    lives -= 2;

                    if (lives <= 0)
                    {
                        matrix[marioRow][marioCol] = 'X';
                        break;
                    }
                }
                if (lives <= 0)
                {
                    matrix[marioRow][marioCol] = 'X';
                    break;
                }
                matrix[marioRow][marioCol] = 'M';
            }

            if (marioWon)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}"); 
            }
            else
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
