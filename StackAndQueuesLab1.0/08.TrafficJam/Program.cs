using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitCars = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            string commands = Console.ReadLine();
            int count = 0;

            while (commands != "end")
            {
                if (commands == "green")
                {
                    if (queue.Count >= limitCars)
                    {
                        for (int i = 0; i < limitCars; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                    else
                    {
                        while (queue.Count != 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(commands);
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}
