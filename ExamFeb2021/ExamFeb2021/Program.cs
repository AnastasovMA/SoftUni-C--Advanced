using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFeb2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lootFirstBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] lootSecondBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstBox = new Queue<int>(lootFirstBox);
            Stack<int> secondBox = new Stack<int>(lootSecondBox);

            int sumItems = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int firstItem = firstBox.Peek(); // Dequeue
                int lastItem = secondBox.Peek(); // Pop 

                if ((firstItem + lastItem) % 2 == 0)
                {
                    sumItems += firstBox.Dequeue() + secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop()); // gets the last element and put it first
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sumItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumItems}");
            }
        }
    }
}
