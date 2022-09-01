using System;

using ManufacturingPhones.InvalidExceptions;
using ManufacturingPhones.Models;
namespace ManufacturingPhones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urlLinks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currentNumber = phoneNumbers[i];
                try
                {
                    if (currentNumber.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(currentNumber));
                    }
                    else
                    {
                        Console.WriteLine(smartPhone.Call(currentNumber));
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            for (int i = 0; i < urlLinks.Length; i++)
            {
                string url = urlLinks[i];
                try
                {
                    Console.WriteLine(smartPhone.Browse(url));
                }
                catch (InvalidUrlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
