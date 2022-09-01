using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            bool change = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(' '); // масив с елементи от командата 
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]); // превръщаме елемента в число
                        numbers.Add(numberToAdd);
                        change = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        change = true;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index); // добавяме на мястото на индекса
                        change = true;
                        break;
                    case "Insert":
                        int number = int.Parse(tokens[1]);
                        int insertAtIndex = int.Parse(tokens[2]);
                        numbers.Insert(insertAtIndex, number);
                        change = true;// означаваме индекса, добавяме число
                        break;
                    case "Contains":
                        int numberOfInteresnt = int.Parse(tokens[1]);
                        if (numbers.Contains(numberOfInteresnt))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven": // Създаваме нов лист, намираме числата вътре, добавяме ги към листа, принтираме листа
                        List<int> evens = new List<int>();
                        for (int i = 0; i < numbers.Count; i++) // въртим цикъл да намерим числата вътре
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evens.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evens));
                        break;
                        //numbers.RemoveAll(n => n % 2 != 0);
                        //Console.WriteLine(string.Join(" ",numbers));
                    case "PrintOdd":
                        List<int> odds = new List<int>(); // Същото като горното
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                odds.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odds));
                        break;
                       //numbers.RemoveAll(n => n % 2 == 0);
                       //Console.WriteLine(string.Join(" ", numbers));
                    case "GetSum":
                        Console.WriteLine(numbers.Sum()); // взима сумата от всички числа
                        break;
                    case "Filter"://{condition}{number} - <=, >=, >, <;
                        string sign = tokens[1];
                        int numberOfInterest = int.Parse(tokens[2]);
                        if (sign == ">")
                        {
                            List<int> nov = new List<int>(); // правим лист, намираме числата отговарящи на условието, добавяме ги в листа, принтираме
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > numberOfInterest)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", nov));
                        }
                        else if (sign == "<")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < numberOfInterest)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", nov));
                        }
                        else if (sign == ">=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= numberOfInterest)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", nov));
                        }
                        else if (sign == "<=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= numberOfInterest)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", nov));
                        }
                        break;
                }

            }
            if (change)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
