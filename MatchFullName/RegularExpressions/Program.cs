using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string name = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var matchedNames = regex.Matches(name);

            foreach (var item in matchedNames)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
