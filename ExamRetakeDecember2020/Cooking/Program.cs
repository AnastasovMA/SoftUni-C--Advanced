using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] ingredientsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> liquids = new Queue<int>(liquidsInfo);
            Stack<int> ingredients = new Stack<int>(ingredientsInfo);

            SortedDictionary<string, int> products = new SortedDictionary<string, int>();


            products.Add("Bread", 0);
            products.Add("Cake", 0);
            products.Add("Pastry", 0);
            products.Add("Fruit Pie", 0);

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currentLiquid = liquids.Peek();
                int currentIngredient = ingredients.Peek();

                if (currentLiquid + currentIngredient == 25)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Bread"]++;

                }
                else if (currentLiquid + currentIngredient == 50)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Cake"]++;
                }
                else if (currentLiquid + currentIngredient == 75)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Pastry"]++;
                }
                else if (currentLiquid + currentIngredient == 100)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Fruit Pie"]++;
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    currentIngredient += 3;
                    ingredients.Push(currentIngredient);
                }
            }
            if (products.All(x=>x.Value != 0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else 
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else 
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
