using System;
using System.Collections.Generic;
using System.Linq;

namespace HousePartyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(); // Създаваме лист с имената, които са в списъка
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ");

                string name = parts[0]; // името, което искаме да добавим

                if (parts.Length == 4)
                {
                    bool removed = guests.Remove(name);

                    if (!removed)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else // Да добавим в листа
                {
                    if (guests.Contains(name)) // Ако името е в листа 
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else // Ако името не е в листа
                    {
                        guests.Add(name);
                    }
                }
            }

            foreach (var guest in guests) // Ползваме го когато искаме да принтираме името в Листа на нов ред
            {
                Console.WriteLine(guest);
            }
        }
    }
}
