using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string colour, int batteries)
        {
            Model = model;
            Colour = colour;
            Battery = batteries;
        }
        public int Battery
        {
            get; private set;
        }

        public string Model
        {
            get; private set;
        }

        public string Colour
        {
            get; private set;
        }

        public string Start()
        {

            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Colour} Tesla {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
