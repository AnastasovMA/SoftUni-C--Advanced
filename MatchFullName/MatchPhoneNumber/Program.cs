using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";
            string phones = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var matchedPhones = regex.Matches(phones);

            var phoneNumbers = matchedPhones
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}
