using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private int age;
        private string firstName;
        private string lastName;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lastName = value;
            }
        }
        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value <= 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }
            Salary *= (1 + percentage / 100);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.");
            return sb.ToString().TrimEnd();
        }

    }
}
