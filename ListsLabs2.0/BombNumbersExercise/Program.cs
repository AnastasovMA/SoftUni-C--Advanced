using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] bombData = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombData[0];
            int bombPower = bombData[1];

            while (true)
            {
                int idx = numbers.IndexOf(bombNumber); // Търсим дали имаме бомба в нашия списък

                if (idx == -1) // ако имаме бомба, намираме нейният индекс и изчисляваме индекса, от който да почва нашата бомба
                {
                    break;
                }

                int startIdx = idx - bombPower; // Стартовият ни индекс е индекса на самата бомба - силата на самата бомба

                if (startIdx < 0) // Ако този индекс е по-малък от 0, ние го сетваме да е 0, защото бомбата ще излезе извън границата на масива
                {
                    startIdx = 0;
                }

                int count = 2 * bombPower + 1; // колко на брой елемента нашата бомба маха от масива

                // какво става обаче, ако искам да махна повече на брой елемента, отколкото мога?

                if (count > numbers.Count - startIdx) // Ако се опитам да махна повече елементи, отколкото се опитам да взема на края,
                {
                    count = numbers.Count - startIdx; // То тогава сетвам бройката елементи от края до този индекс.
                }

                numbers.RemoveRange(startIdx, count);
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
