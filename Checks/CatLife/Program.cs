using System;

namespace CatLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 human months == 1 cat month

            string catStray = Console.ReadLine(); //British Shorthair", "Siamese", "Persian", "Ragdoll", "American Shorthair" или "Siberian"
            string gender = Console.ReadLine();

            int years = 0;
            

            switch (catStray)
            {
                case "British Shorthair":
                    if (gender == "m")
                    {
                        years = 13;
                    }
                    else if (gender == "f")
                    {
                        years = 14;
                    }
                    break;
                case "Siamese":
                    if (gender == "m")
                    {
                        years =15;
                    }
                    else if (gender == "f")
                    {
                        years =16;
                    }
                    break;
                case "Persian":
                    if (gender == "m")
                    {
                        years =14;
                    }
                    else if (gender == "f")
                    {
                        years =15;
                    }
                    break;
                case "Ragdoll":
                    if (gender == "m")
                    {
                        years =16;
                    }
                    else if (gender == "f")
                    {
                        years =17;
                    }
                    break;
                case "American Shorthair":
                    if (gender == "m")
                    {
                        years =12;
                    }
                    else if (gender == "f")
                    {
                        years =13;
                    }
                    break;
                case "Siberian":
                    if (gender == "m")
                    {
                        years =11;
                    }
                    else if (gender == "f")
                    {
                        years =12;
                    }
                    break;

            }
            int monthsHuman = years * 12;
            double monthsCat = (monthsHuman / 6);


            switch (catStray)
            {
                case "British Shorthair":
                case "Siamese":
                case "Persian":
                case "Ragdoll":
                case "American Shorthair":
                case "Siberian":
                    Console.WriteLine($"{Math.Round(monthsCat)} cat months");
                    break;
                default:
                    Console.WriteLine($"{catStray} is invalid cat!");
                    break;
            }
            
        }
    }
}
