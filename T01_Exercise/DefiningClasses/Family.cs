using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members; // good Practise

        public Family()
        {
            this.members = new HashSet<Person>(); // инициализираме нашият сет от мембъри
        }
        public void AddMember(Person member) // adds new members
        {
            this.members.Add(member);
        }
        public Person GetOldestMember() // only gives 1 Person from the collection
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //{
        //     explictly typed
        //     Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault(); // достъпваме колекцията, и взимаме най-старият 
        //     return person;
        //}
        public HashSet<Person> GetRequiredAge() // this gives a new list of people
            => members.Where(p => p.Age > 30)
            .OrderBy(p => p.Name).ToHashSet();
    }
}
