using System;
using System.Linq;

namespace ExamSuperMario
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

                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        matrix[playerRow, playerCol] = '-';
                        if (playerRow - 1 < 0)
                        {
                            playerRow = size - 1;
                        }
                        else
                        {
                            playerRow--;
                        }
                        break;
                    case "down":
                        matrix[playerRow, playerCol] = '-';
                        if (playerRow + 1 >= size)
                        {
                            playerRow = 0;
                        }
                        else
                        {
                            playerRow++;
                        }
                        break;
                    case "left":
                        matrix[playerRow, playerCol] = '-';
                        if (playerCol - 1 < 0)
                        {
                            playerCol = size - 1;
                        }
                        else
                        {
                            playerCol--;
                        }
                        break;
                    case "right":;
                        matrix[playerRow, playerCol] = '-';
                        if (playerCol + 1 >= size)
                        {
                            playerCol = 0;
                        }
                        else
                        {
                            playerCol++;
                        }
                        break;
                    default:
                        break;
                }
                if (matrix[playerRow, playerCol] == '-')
                {
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (matrix[playerRow, playerCol] == 'B')
                {
                    switch (command)
                    {
                        case "up":
                            matrix[playerRow, playerCol] = '-';
                            if (playerRow - 1 < 0)
                            {
                                playerRow = size - 1;
                            }
                            else
                            {
                                playerRow--;
                            }
                            break;
                        case "down":
                            matrix[playerRow, playerCol] = '-';
                            if (playerRow + 1 >= size)
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow++;
                            }
                            break;
                        case "left":
                            matrix[playerRow, playerCol] = '-';
                            if (playerCol - 1 < 0)
                            {
                                playerCol = size - 1;
                            }
                            else
                            {
                                playerCol--;
                            }
                            break;
                        case "right":
                            ;
                            matrix[playerRow, playerCol] = '-';
                            if (playerCol + 1 >= size)
                            {
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol++;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (matrix[playerRow, playerCol] == 'F')
                {
                    playerWon = true;
                    matrix[playerRow, playerCol] = 'f';
                    break;
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    continue;
                }

            }
            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(matrix);
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