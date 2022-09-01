using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IBirthtable> livingThings = new List<IBirthtable>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] dataInput = input.Split();
                string slaveType = dataInput[0];
                string name = dataInput[1];
                switch (slaveType)
                {
                    case "Citizen":
                        // Citizen <name> <age> <id> <birthdate>" 
                        int age = int.Parse(dataInput[2]);
                        string id = dataInput[3];
                        string birthdate = dataInput[4];
                        livingThings.Add(new Citizen(name, age, id, birthdate));
                        break;
                    case "Pet":
                        // Pet <name> <birthdate
                        livingThings.Add(new Pet(name, dataInput[2]));
                        break;
                    case "Robot":
                        // Robot <model> <id>
                        Robot robot = new Robot(name, dataInput[2]);
                        break;
                    default:
                        break;
                }
            }
            string birthYear = Console.ReadLine();

            livingThings.Where(x => x.Birthdate.EndsWith(birthYear))
                .Select(c => c.Birthdate)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
