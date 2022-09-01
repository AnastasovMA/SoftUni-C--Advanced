using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() // пишем числата в листа
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] command = line.Split(" "); // командата, която искаме да екзекутираме в листа

                if (command[0] == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd); // добавяме число в КРАЯ на листата
                }
                else if (command[0] == "Insert")
                {

                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (!isValid(index, numbers)) // Метод да проверим дали числото е в диапазона на индекса
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (!isValid(index, numbers))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Shift")
                {
                    string direction = command[1]; // на коя посока ще сменяме
                    int count = int.Parse(command[2]); // броят пъти в който ще сменяме

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++) // въртим цикъл, за да добавим точния брой пъти на въртене
                        {
                            int firstNumber = numbers[0]; // първото число е в първият индекс
                            numbers.RemoveAt(0); // махаме първият индекс
                            numbers.Add(firstNumber); // добавяме първото числото отзад
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++) // въртим цикъл да добавим точния брой пъти на въртене
                        {
                            int lastNumber = numbers[numbers.Count - 1]; // последното число е последно в листата
                            numbers.RemoveAt(numbers.Count - 1); // махаме последното число
                            numbers.Insert(0, lastNumber); // добавяме го в първия индекс
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool isValid(int index, List<int> number) // Числото е в диапазона на индекса, ако е по-голямо от 0 и по-малко от дължината на листа
        {
            return index >= 0 && index < number.Count;
        }
    }
}
