using System;

namespace ExamSuperMario_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, rows];

            int marioRow = 0;
            int marioCol = 0;
            bool isMarioDead = false;
            bool isMarioWon = false;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }


            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string moveCommand = input[0];
                int bRow = int.Parse(input[1]);
                int bCol = int.Parse(input[2]);
                matrix[bRow, bCol] = 'B';
                int newMarioRow = marioRow;
                int newMarioCol = marioCol;

                switch (moveCommand)
                {
                    case "W":
                        newMarioRow--;
                        break;
                    case "S":
                        newMarioRow++;
                        break;
                    case "A":
                        newMarioCol--;
                        break;
                    case "D":
                        newMarioCol++;
                        break;
                    default:
                        break;
                }
                lives--;
                if (newMarioRow >= 0 && newMarioRow < matrix.GetLength(0) && newMarioCol >= 0 && newMarioCol < matrix.GetLength(1))
                {
                    if (matrix[newMarioRow, newMarioCol] == 'P')
                    {
                        matrix[marioRow, marioCol] = '-';
                        matrix[newMarioRow, newMarioCol] = '-';
                        isMarioWon = true;
                        break;
                    }
                    if (lives <= 0)
                    {
                        matrix[marioRow, marioCol] = '-';
                        matrix[newMarioRow, newMarioCol] = 'X';
                        isMarioDead = true;
                        marioRow = newMarioRow;
                        marioCol = newMarioCol;
                        break;
                    }
                    if (matrix[newMarioRow, newMarioCol] == 'B')
                    {
                        lives -= 2;
                        if (lives <= 0)
                        {
                            matrix[marioRow, marioCol] = '-';
                            matrix[newMarioRow, newMarioCol] = 'X';
                            isMarioDead = true;
                            marioRow = newMarioRow;
                            marioCol = newMarioCol;
                            break;
                        }
                        else
                        {
                            matrix[marioRow, marioCol] = '-';
                            matrix[newMarioRow, newMarioCol] = 'M';
                        }
                    }
                    else if (matrix[newMarioRow, newMarioCol] == '-')
                    {
                        matrix[marioRow, marioCol] = '-';
                        matrix[newMarioRow, newMarioCol] = 'M';
                    }
                }
                else
                {
                    if (lives <= 0)
                    {
                        matrix[marioRow, marioCol] = 'X';
                        isMarioDead = true;
                        break;
                    }
                    continue;
                }

                marioRow = newMarioRow;
                marioCol = newMarioCol;

                //if (isMarioWon || isMarioDead)
                //{
                //    break;
                //}
            }

            if (isMarioWon)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else if (isMarioDead)
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }

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
