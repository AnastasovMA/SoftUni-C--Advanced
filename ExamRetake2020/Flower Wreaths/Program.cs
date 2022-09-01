using System;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilesInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rosesInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> liles = new Stack<int>(lilesInfo);
            Queue<int> roses = new Queue<int>(rosesInfo);

            List<int> wreaths = new List<int>();
            int wreathCount = 0;
            bool hasCompleted = false;

            while (liles.Count > 0 && roses.Count > 0)
            {
                int currentLile = liles.Peek();
                int currentRoses = roses.Peek();

                if (currentLile + currentRoses == 15)
                {
                    liles.Pop();
                    roses.Dequeue();
                    wreathCount++;
                }
                else if (currentLile + currentRoses > 15)
                {
                    liles.Pop();
                    currentLile -= 2;
                    liles.Push(currentLile);
                }
                else if (currentLile + currentRoses < 15)
                {
                    liles.Pop();
                    roses.Dequeue();
                    wreaths.Add(currentLile + currentRoses);
                }
            }
            int sum = wreaths.Sum();

            while (sum > 15)
            {
                sum -= 15;
                wreathCount++;
            }
            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
        }
    }
}
