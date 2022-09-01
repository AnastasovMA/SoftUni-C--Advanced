using System;
using System.Linq;

namespace ExamSuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            var lives = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            char[][] maze = new char[rows][];
            var currRow = 0;
            var currCol = 0;

            bool isMarioWon = false;

            for (int row = 0; row < maze.GetLength(0); row++)
            {
                var mazeRow = Console.ReadLine();
                maze[row] = new char[mazeRow.Length];
                for (int col = 0; col < mazeRow.Length; col++)
                {
                    maze[row][col] = mazeRow[col];
                    if (maze[row][col] == 'M')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var moveCommand = char.Parse(input[0]);
                int bRow = int.Parse(input[1]);
                int bCol = int.Parse(input[2]);
                maze[bRow][bCol] = 'B';
                lives--;
                switch (moveCommand)
                {
                    case 'W':
                        if (currRow - 1 < 0)
                        {
                            continue;
                        }
                        maze[currRow][currCol] = '-';
                        currRow--;
                        break;
                    case 'S':
                        if (currRow + 1 >= rows)
                        {
                            continue;
                        }
                        maze[currRow][currCol] = '-';
                        currRow++;
                        break;
                    case 'A':
                        if (currCol - 1 < 0)
                        {
                            continue;
                        }
                        maze[currRow][currCol] = '-';
                        currCol--;
                        break;
                    case 'D':
                        if (currCol + 1 >= maze[currRow].Length)
                        {
                            continue;
                        }
                        maze[currRow][currCol] = '-';
                        currCol++;
                        break;
                    default:
                        break;
                }
                if (lives <= 0)
                {
                    maze[currRow][currCol] = 'X';
                    break;
                }
                if (maze[currRow][currCol] == 'B')
                {
                    lives -= 2;

                    if (lives <= 0)
                    {
                        maze[currRow][currCol] = 'X';
                        break;
                    }
                }
                else if (maze[currRow][currCol] == 'P')
                {
                    maze[currRow][currCol] = '-';
                    isMarioWon = true;
                    break;
                }
                maze[currRow][currCol] = 'M';
            }

            if (isMarioWon)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {currRow};{currCol}.");
            }


            foreach (var row in maze)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
        static bool IsValid(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
        public static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}