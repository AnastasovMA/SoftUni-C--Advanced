﻿namespace _04.BorderControl
{
    public class Robots : IIdentifiable
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; }
    }
}
