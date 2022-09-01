using System;

namespace ExamReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool playerWon = false;

            for (int i = 0; i < numberOfCommands; i++)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        newPlayerRow--;
                        if (newPlayerRow < 0)
                        {
                            newPlayerRow = size - 1;
                        }
                        break;
                    case "down":
                        newPlayerRow++;
                        if (newPlayerRow >= size)
                        {
                            newPlayerRow = 0;
                        }
                        break;
                    case "left":
                        newPlayerCol--;
                        if (newPlayerCol < 0)
                        {
                            newPlayerCol = size - 1;
                        }
                        break;
                    case "right":
                        newPlayerCol++;
                        if (newPlayerCol >= size)
                        {
                            newPlayerCol = 0;
                        }
                        break;
                    default:
                        break;
                }
                if (matrix[newPlayerRow, newPlayerCol] == '-')
                {
                    matrix[playerRow, playerCol] = '-';
                    matrix[newPlayerRow, newPlayerCol] = 'f';
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    matrix[playerRow, playerCol] = '-';
                    switch (command)
                    {
                        case "up":
                            newPlayerRow--;
                            if (newPlayerRow < 0)
                            {
                                newPlayerRow = size - 1;
                            }
                            break;
                        case "down":
                            newPlayerRow++;
                            if (newPlayerRow >= size)
                            {
                                newPlayerRow = 0;
                            }
                            break;
                        case "left":
                            newPlayerCol--;
                            if (newPlayerCol < 0)
                            {
                                newPlayerCol = size - 1;
                            }
                            break;
                        case "right":
                            newPlayerCol++;
                            if (newPlayerCol >= size)
                            {
                                newPlayerCol = 0;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'F')
                {
                    playerWon = true;
                    matrix[playerRow, playerCol] = '-';
                    matrix[newPlayerRow, newPlayerCol] = 'f';
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'T')
                {
                    newPlayerRow = playerRow;
                    newPlayerCol = playerCol;
                }
                if (playerWon)
                {
                    Console.WriteLine("Player won!");
                    break;
                }
                playerRow = newPlayerRow;
                playerCol = newPlayerCol;
            }
            if (!playerWon)
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
