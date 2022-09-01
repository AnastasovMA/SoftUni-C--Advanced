using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            bool partyStarted = false;

            string guest = Console.ReadLine();

            while (guest != "END")
            {
                if (guest == "PARTY")
                {
                    while (true)
                    {
                        guest = Console.ReadLine();

                        if (vipGuests.Contains(guest))
                        {
                            vipGuests.Remove(guest);
                        }
                        if (regularGuests.Contains(guest))
                        {
                            regularGuests.Remove(guest);
                        }
                        if (guest == "END")
                        {
                            partyStarted = true;
                            break;
                        }
                    }

                }
                if (partyStarted)
                {
                    break;
                }
                char firstElement = guest.First();
                if (char.IsDigit(firstElement))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }
                guest = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            if (vipGuests.Count >0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }
            if (regularGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
            }
        }
    }
}
