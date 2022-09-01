using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Craft!")
                {
                    break;
                }

                string[] parts = line.Split(" - ");

                string command = parts[0];
                string item = parts[1];

                switch (command)
                {
                    case "Collect":
                        if (!items.Contains(item))
                        {
                            items.Add(item);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Drop":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Combine Items":
                        string[] itemsToCombine = item.Split(":");

                        string oldItem = itemsToCombine[0];

                        string newItem = itemsToCombine[1];

                        if (items.Contains(oldItem))
                        {
                            // "Combine Items - {oldItem}:{newItem}" – You should check if the old item exists,
                            // if so, add the new item after the old one. Otherwise, ignore the command.
                            //items.Insert((items.IndexOf(item) + 1), newItem);
                            items.Insert((items.IndexOf(oldItem) + 1), newItem);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
