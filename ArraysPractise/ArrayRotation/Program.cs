using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();

            int rotation = int.Parse(Console.ReadLine()); // При ротации ти трябват 2 цикъла

            for (int rotations = 0; rotations < rotation; rotations++) // с този цикъл взимаме първия елемент и го слагаме последен
            {
                string firstElement = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    // Местим индекса на ляво
                    int prevIndex = i - 1;
                    array[prevIndex] = array[i];
                }
                array[array.Length - 1] = firstElement; // първият елемент става последен
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
