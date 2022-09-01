using System;
using System.Collections.Generic;
using System.Text;

namespace _03.PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public int Level { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Name} Level: {this.Level}";
        }
    }
}
