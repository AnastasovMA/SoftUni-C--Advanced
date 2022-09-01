using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamWarshipsRedo
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
                List<int[]> currBombIndex = GetBombIndexes(matrix);

                if (isValidCoordinates(row, col, size))
                {
                    if (matrix[row, col] == '#')
                    {
                        SpreadBombs(currBombIndex, matrix, playerOneShips, playerTwoShips, totalShipsDestroyed);
                        continue;
                    }
                    else if (matrix[row, col] == '*')
                    {
                        continue;
                    }
                    if (i % 2 == 0) // Player 1
                    {
                        if (matrix[row, col] == '>')
                        {
                            matrix[row, col] = 'X';
                            totalShipsDestroyed++;
                            playerTwoShips--;
                        }
                    }
                    if (i % 2 != 0) // Player 2
                    {
                        if (matrix[row, col] == '<')
                        {
                            matrix[row, col] = 'X';
                            totalShipsDestroyed++;
                            playerOneShips--;
                        }
                    }
                }
                else
                {

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
        }

        static void SpreadBombs(List<int[]> currBombIndex, char[,] matrix, int playerOneShips, int playerTwoShips, int shipsDestoyed)
        {
            //player = '>';
            foreach (int[] bombIndexes in currBombIndex)
            {
                int bombRow = bombIndexes[0];
                int bombCol = bombIndexes[1];

                if (isValidCoordinates(bombRow + 1, bombCol, matrix.GetLength(0)) && (matrix[bombRow +1, bombCol] == '>' ||
                    matrix[bombRow +1, bombCol] == '<'))
                {
                    if (matrix[bombRow + 1, bombCol] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow + 1, bombCol] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow + 1, bombCol] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow + 1, bombCol + 1, matrix.GetLength(0)) && (matrix[bombRow + 1, bombCol + 1] == '>' ||
                    matrix[bombRow + 1, bombCol + 1] == '<'))
                {
                    if (matrix[bombRow + 1, bombCol + 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow + 1, bombCol + 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow + 1, bombCol + 1] = 'X';
                    shipsDestoyed++;
                } 
                if (isValidCoordinates(bombRow, bombCol + 1, matrix.GetLength(0)) && (matrix[bombRow, bombCol + 1] == '>' ||
                    matrix[bombRow, bombCol + 1] == '<'))
                {
                    if (matrix[bombRow, bombCol + 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow, bombCol + 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow, bombCol + 1] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow - 1, bombCol + 1, matrix.GetLength(0)) && (matrix[bombRow - 1, bombCol + 1] == '>' ||
                    matrix[bombRow - 1, bombCol + 1] == '<'))
                {
                    if (matrix[bombRow - 1, bombCol + 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow - 1, bombCol + 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow - 1, bombCol + 1] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow - 1, bombCol, matrix.GetLength(0)) && (matrix[bombRow - 1, bombCol] == '>' ||
                    matrix[bombRow - 1, bombCol] == '<'))
                {
                    if (matrix[bombRow - 1, bombCol] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow - 1, bombCol] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow - 1, bombCol] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow - 1, bombCol - 1, matrix.GetLength(0)) && (matrix[bombRow - 1, bombCol - 1] == '>' ||
                    matrix[bombRow - 1, bombCol - 1] == '<'))
                {
                    if (matrix[bombRow - 1, bombCol - 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow - 1, bombCol - 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow - 1, bombCol - 1] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow, bombCol - 1, matrix.GetLength(0)) && (matrix[bombRow, bombCol - 1] == '>' ||
                    matrix[bombRow, bombCol - 1] == '<'))
                {
                    if (matrix[bombRow, bombCol - 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow, bombCol - 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow, bombCol - 1] = 'X';
                    shipsDestoyed++;
                }
                if (isValidCoordinates(bombRow + 1, bombCol - 1, matrix.GetLength(0)) && (matrix[bombRow + 1, bombCol - 1] == '>' ||
                    matrix[bombRow + 1, bombCol - 1] == '<'))
                {
                    if (matrix[bombRow + 1, bombCol - 1] == '>')
                    {
                        playerTwoShips--;
                    }
                    if (matrix[bombRow + 1, bombCol - 1] == '<')
                    {
                        playerOneShips--;
                    }
                    matrix[bombRow + 1, bombCol - 1] = 'X';
                    shipsDestoyed++;
                }
            }
        }

        static List<int[]> GetBombIndexes(char[,] matrix) // намираме данните.
        {
            List<int[]> bombs = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == '#')
                    {
                        bombs.Add(new[] { row, col });
                    }
                }
            }
            return bombs;
        }

        static bool isValidCoordinates(int row, int col, int rows)
        {
            return row >= 0 && row < rows && col >= 0 && col < rows;
        }
    }
}
