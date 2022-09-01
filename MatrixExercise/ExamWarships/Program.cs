using System;
using System.Linq;

namespace ExamWarships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] attackInfo = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];
            int playerOneShips = 0;
            int playerTwoShips = 0;
            int totalShipsDestroyed = 0;

            bool playerOneWon = false;
            bool playerTwoWon = false;

            for (int row = 0; row < size; row++)
            {
                char[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = array[col];
                    if (matrix[row, col] == '<')
                    {
                        playerOneShips++;
                    }
                    if (matrix[row, col] == '>')
                    {
                        playerTwoShips++;
                    }
                }
            }

            for (int i = 0; i < attackInfo.Length; i++)
            {
                string[] coordinates = attackInfo[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                if (isValidCoordinates(row, col, size))
                {
                    if (matrix[row, col] == '*')
                    {
                        continue;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        matrix[row, col] = 'X';
                        playerTwoShips--;
                        totalShipsDestroyed++;
                    }
                    else if (matrix[row, col] == '<')
                    {
                        matrix[row, col] = 'X';
                        playerOneShips--;
                        totalShipsDestroyed++;
                    }
                    else if (matrix[row, col] == '#')
                    {
                        matrix[row, col] = 'X';
                        if (isValidCoordinates(row, col + 1, size))
                        {
                            if (matrix[row, col + 1] == '>')
                            {
                                matrix[row, col + 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row, col + 1] == '<')
                            {
                                matrix[row, col + 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row - 1, col + 1, size)) //
                        {
                            if (matrix[row - 1, col + 1] == '>')
                            {
                                matrix[row - 1, col + 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row - 1, col + 1] == '<')
                            {
                                matrix[row - 1, col + 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row - 1, col, size)) //
                        {
                            if (matrix[row - 1, col] == '>')
                            {
                                matrix[row - 1, col] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row - 1, col] == '<')
                            {
                                matrix[row - 1, col] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row - 1, col - 1, size)) //
                        {
                            if (matrix[row - 1, col - 1] == '>')
                            {
                                matrix[row - 1, col - 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row - 1, col - 1] == '<')
                            {
                                matrix[row - 1, col - 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row, col - 1, size)) //
                        {
                            if (matrix[row, col - 1] == '>')
                            {
                                matrix[row, col - 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row, col - 1] == '<')
                            {
                                matrix[row, col - 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row + 1, col - 1, size)) //
                        {
                            if (matrix[row + 1, col - 1] == '>')
                            {
                                matrix[row + 1, col - 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row + 1, col - 1] == '<')
                            {
                                matrix[row + 1, col - 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row + 1, col, size))
                        {
                            if (matrix[row + 1, col] == '>')
                            {
                                matrix[row + 1, col] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row + 1, col] == '<')
                            {
                                matrix[row + 1, col] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                        if (isValidCoordinates(row + 1, col + 1, size))
                        {
                            if (matrix[row + 1, col + 1] == '>')
                            {
                                matrix[row + 1, col + 1] = 'X';
                                playerTwoShips--;
                                totalShipsDestroyed++;
                            }
                            if (matrix[row + 1, col + 1] == '<')
                            {
                                matrix[row + 1, col + 1] = 'X';
                                playerOneShips--;
                                totalShipsDestroyed++;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
                if (playerOneShips == 0)
                {
                    playerTwoWon = true;
                    Console.WriteLine($"Player Two has won the game! {totalShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
                if (playerTwoShips == 0)
                {
                    playerOneWon = true;
                    Console.WriteLine($"Player One has won the game! {totalShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
            }
            if (!playerOneWon && !playerTwoWon)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static bool isValidCoordinates(int row, int col, int rows)
        {
            return row >= 0 && row < rows && col >= 0 && col < rows;
        }
    }
}
