using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Person
    {
        private List<Person> players;
        private decimal salary;
        public Person(string name, int age, decimal salary)
        {
            FirstName = name;
            Age = age;
            Salary = salary;
        }
        //public List<Person> Players { get { return players; } }  -> can access through the getter
        public IReadOnlyCollection<Person> Players { get { return players.AsReadOnly(); } }
        public void AddPlayers(Person player)
        {
            players.Add(player);
        }
        public string FirstName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.salary = value;
                }
            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} at {Age} receives {Salary}";
        }
    }
}
