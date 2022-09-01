using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < array.Length; i++) // взимаме числото и го обхождаме с другите
            {
                int numberOfInterest = array[i];
                int sumLeft = 0;
                int sumRight = 0;

                for (int right = i + 1; right < array.Length; right++) // обхождаме числата на дясно
                {
                    int rightNumber = array[right];
                    sumRight += rightNumber;
                }

                for (int left = i - 1; left >= 0; left--) // Обхождаме числото на ляво
                {
                    int leftNumber = array[left];
                    sumLeft += leftNumber;
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
