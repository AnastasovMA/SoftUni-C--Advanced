using System;
using System.Collections.Generic;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colour = input[0];
                string clothes = input[1];
                string[] cloth = clothes.Split(",");

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < cloth.Length; j++)
                {
                    string currentCloth = cloth[j];
                    if (!wardrobe[colour].ContainsKey(currentCloth))
                    {
                        wardrobe[colour].Add(currentCloth, 1);
                    }
                    else
                    {
                        wardrobe[colour][currentCloth]++;
                    }
                }
            }

            string[] requiredInfo = Console.ReadLine().Split();
            string requiredColour = requiredInfo[0];
            string requiredCloth = requiredInfo[1];

            foreach (var kvp in wardrobe)
            {
                string colour = kvp.Key;

                Console.WriteLine($"{colour} clothes:");

                foreach (var item in kvp.Value)
                {
                    string cloth = item.Key;
                    if (requiredCloth == cloth 
                        && requiredColour == colour)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }

            //foreach (var colour in wardrobe)
            //{
            //    string currentColour = colour.Key;
            //
            //    foreach (var cloth in colour.Value)
            //    {
            //        if (requiredColour == currentColour 
            //            && requiredCloth == cloth.Key)
            //        {
            //
            //        }
            //    }
            //}
        }
    }
}
