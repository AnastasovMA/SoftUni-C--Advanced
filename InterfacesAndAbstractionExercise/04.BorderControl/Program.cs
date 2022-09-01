using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> citizens = new List<IIdentifiable>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string id = (tokens[1]);
                    Robots robot = new Robots(model, id);
                    citizens.Add(robot);
                    // Robots
                }
                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = (tokens[2]);
                    Citizen citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                    // Citizen
                }
            }

            string fakeIdNumber = Console.ReadLine();

            // use list modification 
            citizens.Where(c => c.Id.EndsWith(fakeIdNumber)) // Ends with for string
            .Select(c => c.Id)
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
