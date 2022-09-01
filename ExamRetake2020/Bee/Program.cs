using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, rows];
            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            string direction;
            bool hasSucceeded = false;
            int flowers = 0;
            bool gotLost = false;
            while ((direction = Console.ReadLine()) != "End")
            {
                int newBeeRow = beeRow;
                int newBeeCol = beeCol;

                switch (direction)
                {
                    case "up":
                        newBeeRow--;
                        break;
                    case "down":
                        newBeeRow++;
                        break;
                    case "left":
                        newBeeCol--;
                        break;
                    case "right":
                        newBeeCol++;
                        break;
                    default:
                        break;
                }
                if (newBeeRow < 0 || newBeeRow >= rows || newBeeCol < 0 || newBeeCol >= rows)
                {
                    matrix[beeRow, beeCol] = '.';
                    gotLost = true;
                    break;
                }
                matrix[beeRow, beeCol] = '.';

                if (matrix[newBeeRow, newBeeCol] == 'O')
                {
                    matrix[newBeeRow, newBeeCol] = '.';
                    switch (direction)
                    {
                        case "up":
                            newBeeRow--;
                            break;
                        case "down":
                            newBeeRow++;
                            break;
                        case "left":
                            newBeeCol--;
                            break;
                        case "right":
                            newBeeCol++;
                            break;
                        default:
                            break;
                    }
                    if (newBeeRow < 0 || newBeeRow >= rows || newBeeCol < 0 || newBeeCol >= rows)
                    {
                        gotLost = true;
                        break;
                    }
                    if (matrix[newBeeRow, newBeeCol] == 'f')
                    {
                        flowers++;
                    }
                }
                else if (matrix[newBeeRow, newBeeCol] == 'f')
                {
                    flowers++;
                }
                matrix[newBeeRow, newBeeCol] = 'B';
                beeRow = newBeeRow;
                beeCol = newBeeCol;
            }
            if (gotLost)
            {
                Console.WriteLine("The bee got lost!");
            }
            if (flowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
