using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebration
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; }
    }
}
