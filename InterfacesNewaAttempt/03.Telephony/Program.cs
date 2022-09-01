
namespace _03.Telephony
{
    using System;
    using _03.Telephony.Models;
    using _03.Telephony.Exceptions;
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            SmartPhone smartphone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string phoneNumber = phoneNumbers[i];

                try
                {
                    if (phoneNumber.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(phoneNumber));
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            for (int i = 0; i < urls.Length; i++)
            {
                string url = urls[i];

                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (InvalidURLException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
