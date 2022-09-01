using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bestSequenceSize = 0;
            int bestSeuqenceNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentSequence = 1; // минималният sequence е 1;
                int currentNumber = array[i];

                for (int j = i+1; j < array.Length; j++) // проверяваме числата от дясно
                {
                    int rightNumber = array[j];
                    if (currentNumber == rightNumber)
                    {
                        currentSequence++; // увеличаваме поредицата с 1
                    }
                    else
                    {
                        break; // приключваме с поредицата
                    }
                }
                if (currentSequence > bestSequenceSize)
                {
                    bestSequenceSize = currentSequence; // отделяме дължината на поредицата, която гледаме
                    bestSeuqenceNumber = currentNumber; // отделяме числото, което гледаме
                }
            }
            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSeuqenceNumber} ");
            }
            Console.WriteLine();
        }
    }
}
