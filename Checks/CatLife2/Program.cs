using System;

namespace CatLife2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 human months = 1 cat month.

            string catStray = Console.ReadLine();
            string gender = Console.ReadLine();
            int years = 0;

            if (gender == "m")
            {
                switch (catStray)
                {
                    case "British Shorthair":
                        years = 13;
                        break;
                    case "Siamese":
                        years =15;
                        break;
                    case "Persian":
                        years = 14;
                        break;
                    case "Ragdoll":
                        years = 16;
                        break;
                    case "American Shorthair":
                        years = 12;
                        break;
                    case "Siberian":
                        years = 11;
                        break;
                    default:
                        Console.WriteLine($"{catStray} is invalid cat!");
                        break;
                }
            }
            else if (gender == "f")
            {
                switch (catStray)
                {
                    case "British Shorthair":
                        years = 14;
                        break;
                    case "Siamese":
                        years = 16;
                        break;
                    case "Persian":
                        years = 15;
                        break;
                    case "Ragdoll":
                        years = 17;
                        break;
                    case "American Shorthair":
                        years = 13;
                        break;
                    case "Siberian":
                        years = 12;
                        break;
                    default:
                        Console.WriteLine($"{catStray} is invalid cat!");
                        break;
                }
            }
            int monthsHuman = years * 12;
            double catMonth = monthsHuman / 6;

            
        }
    }
}
