using System;

namespace ConditionalStatementsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            switch (weather) // винаги е стойност
            {
                case "sunny": // Изброяване на условия (стойности) за проверка
                    Console.WriteLine("Take your sunscreen!");
                    break;
                case "rainy":
                case "stormy":
                case "clody":
                    Console.WriteLine("Take your umbrella!");
                    break;
                case "icy":
                    Console.WriteLine("Go skiing!");
                    break;
                default: // в нито един случай
                    Console.WriteLine("Invalid weather");
                    break;
            }
        }
    }
}
