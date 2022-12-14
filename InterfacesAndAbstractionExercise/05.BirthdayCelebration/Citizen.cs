using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebration
{
    public class Citizen : IIdentifiable, IBirthtable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; }
        public string Birthdate { get; }
    }
}
