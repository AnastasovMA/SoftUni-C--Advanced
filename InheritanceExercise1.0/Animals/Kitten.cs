﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        private const string KittenGenre = "Female";
        public Kitten(string name, int age) : base(name, age, KittenGenre)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}