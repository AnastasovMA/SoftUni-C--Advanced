using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|");

            int initialHealth = 100;
            int initalBTC = 0;
            bool survived = true;

            int currHealth = 0;
            int tempHealth = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string part = rooms[i];
                string[] command = part.Split();

                if (command[0] == "potion")
                {
                    currHealth = initialHealth;
                    tempHealth = initialHealth;
                    
                    int healing = int.Parse(command[1]);
                    currHealth += healing;
                    if (currHealth <= 100)
                    {
                        initialHealth += int.Parse(command[1]);
                        Console.WriteLine($"You healed for {command[1]} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else if (currHealth > 100)
                    {
                        int diff = 100 - tempHealth;
                        initialHealth = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    continue;
                }
                if (command[0] == "chest")
                {
                    int btcFound = int.Parse(command[1]);

                    Console.WriteLine($"You found {btcFound} bitcoins.");

                    initalBTC += btcFound;
                }
                else
                {
                    string monster = command[0];
                    int damage = int.Parse(command[1]);

                    initialHealth -= damage;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        survived = false;
                        break;
                    }
                }
            }

            if (survived)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initalBTC}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
