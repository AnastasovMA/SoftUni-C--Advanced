using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                bool isTopNumber = true; // приемаме че числото е topNumber

                // Ако обходим всички чилса и намерим някое по-голямо, това означава, че числото не е topNumber
                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightnumber = array[j];

                    if (rightnumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }

                }
                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
