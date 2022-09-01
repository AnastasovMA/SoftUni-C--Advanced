using System;

namespace _04.BorderControl
{
    using _04.BorderControl.Slaves;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Citizen> citizens = new List<Citizen>();
            List<Robots> robots = new List<Robots>();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    int id = int.Parse(tokens[2]);
                    Citizen citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }
                else
                {
                    string model = tokens[0];
                    int id = int.Parse(tokens[1]);
                    Robots robot = new Robots(model, id);
                    robots.Add(robot);
                }

                input = Console.ReadLine();
            }

            string endsWith = Console.ReadLine();

            foreach (var item in collection)
            {

            }
        }
    }
}
