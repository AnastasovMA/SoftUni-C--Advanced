using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Person first = new Person();
            //Person second = new Person(18);
            //Person third = new Person("Stamat", 43);
            //
            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //Console.WriteLine(third);

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }
            //Console.WriteLine(family.GetOldestMember());

            HashSet<Person> peopleAbove30 = family.GetRequiredAge(); // create a new list of people which is the filtered one
            Console.WriteLine(string.Join(Environment.NewLine, peopleAbove30)); // this prints each member on a new line;
        }
    }
}
