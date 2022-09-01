using System;

namespace SellingExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, rows];
            int currRow = 0;
            int currCol = 0;

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
                }
            }

            int totalMoney = 0;
            bool hasSucceded = false;

            while (true)
            {
                string direction = Console.ReadLine();
                int newPlayerRow = currRow;
                int newPlayerCol = currCol;

                switch (direction)
                {
                    case "up": // row --
                        newPlayerRow--;
                        break;
                    case "down":
                        newPlayerRow++;
                        break;
                    case "left":
                        newPlayerCol--;
                        break;
                    case "right":
                        newPlayerCol++;
                        break;
                    default:
                        break;
                }
                matrix[currRow, currCol] = '-';
                if (newPlayerRow < 0 || newPlayerRow >= rows || newPlayerCol < 0 || newPlayerCol >= rows )
                {
                    break;
                }
                if (matrix[newPlayerRow, newPlayerCol] == 'O')
                {
                    matrix[newPlayerRow, newPlayerCol] = '-';
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == 'O')
                            {
                                matrix[i, j] = 'S';
                                currRow = i;
                                currCol = j;
                            }
                        }
                    }
                    continue;
                }
                else if (char.IsDigit(matrix[newPlayerRow, newPlayerCol]))
                {
                    char currentValue = matrix[newPlayerRow, newPlayerCol];
                    int value = int.Parse(currentValue.ToString());
                    totalMoney += value;
                    matrix[newPlayerRow, newPlayerCol] = 'S';

                    if (totalMoney >= 50)
                    {
                        hasSucceded = true;
                        break;
                    }
                }
                matrix[newPlayerRow, newPlayerCol] = 'S';
                currRow = newPlayerRow;
                currCol = newPlayerCol;
            }
            if (hasSucceded)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!"); 
            }
            else
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {totalMoney}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
