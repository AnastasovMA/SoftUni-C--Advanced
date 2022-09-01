using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, string>();

            string username = string.Empty;
            string licensePlateNumber = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] commands = line.Split();
                username = commands[1];

                switch (commands[0])
                {
                    case "register":
                        licensePlateNumber = commands[2];
                        if (dictionary.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        else
                        {
                            dictionary.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    case "unregister":
                        if (dictionary.ContainsKey(username))
                        {
                            dictionary.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
