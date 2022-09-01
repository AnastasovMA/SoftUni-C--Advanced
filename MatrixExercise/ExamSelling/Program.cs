using System;
using System.Collections.Generic;

namespace ExamSelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int currRow = 0;
            int currCol = 0;

            int totalMoney = 0;
            bool canRent = false;

            List<int[]> pillarPositions = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'S')
                    {
                        currRow = row;
                        currCol = col;
                    }
                    if (matrix[row, col] == 'O')
                    {
                        pillarPositions.Add(new int[] { row, col });
                    }
                }
            }

            while (true)
            {
                string directions = Console.ReadLine();
                int newMarioRow = currRow;
                int newMarioCol = currCol;

                switch (directions)
                {
                    case "up":
                        newMarioRow--;
                        break;
                    case "down":
                        newMarioRow++;
                        break;
                    case "left":
                        newMarioCol--;
                        break;
                    case "right":
                        newMarioCol++;
                        break;
                    default:
                        break;
                }

                if (newMarioRow < 0 || newMarioRow >= size || newMarioCol < 0 || newMarioCol >= size)
                {
                    matrix[currRow, currCol] = '-';
                    break;
                }
                if (matrix[newMarioRow, newMarioCol] == 'O')
                {
                    matrix[currRow, currCol] = '-';
                    matrix[newMarioRow, newMarioCol] = 'S';

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == 'O')
                            {
                                matrix[i, j] = 'S';
                                matrix[newMarioRow, newMarioCol] = '-';
                                newMarioRow = i;
                                newMarioCol = j;
                                
                            }
                        }
                    }
                }
                else if (matrix[newMarioRow, newMarioCol] == '-')
                {
                    matrix[currRow, currCol] = '-';
                    matrix[newMarioRow, newMarioCol] = 'S';
                }
                else if (char.IsDigit(matrix[newMarioRow, newMarioCol]))
                {
                    matrix[currRow, currCol] = '-';
                    string money = matrix[newMarioRow, newMarioCol].ToString();
                    int value = int.Parse(money);
                    matrix[newMarioRow, newMarioCol] = 'S';
                    totalMoney += value;
                }

                if (totalMoney >= 50)
                {
                    canRent = true;
                    break;
                }

                currRow = newMarioRow;
                currCol = newMarioCol;
            }
            if (canRent)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }
            else
            {
                Console.WriteLine($"Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {totalMoney}");

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
