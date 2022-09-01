using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                .Split("!")
                .ToList();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Go Shopping!")
                {
                    break;
                }

                string[] parts = line.Split(" ");
                string command = parts[0];
                string item = parts[1];

                switch (command)
                {
                    case "Urgent":
                        if (initialList.Contains(item))
                        {
                            break;
                        }
                        else
                        {
                            initialList.Insert(0,item);
                        }
                        break;
                    case "Unnecessary":
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                        }
                        break;
                    case "Correct":
                        //string[] splitted = item.Split(" ");
                        string oldItem = parts[1];
                        string newItem = parts[2];

                        if (initialList.Contains(oldItem))
                        {
                            //Correct {oldItem} {newItem} – if the item with the given old name exists, 
                            //change its name with the new one
                            initialList.Insert(initialList.IndexOf(oldItem), newItem);
                            initialList.Remove(oldItem);
                        }
                        break;
                    case "Rearrange":
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                            initialList.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", initialList));

        }
    }
}
