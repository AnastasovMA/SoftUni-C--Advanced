using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxesLab
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            // First way - create a new instance of Item in the Box constructor
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of Item in such a way, that when you try to set a value to some of the properties,
            //it will not throw you an exception.

            //Box box = new Box();             // creating a box
            //box.Item = new Item();             // access the Item property and create an instance

            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] data = Console.ReadLine()
                    .Split(" ");

                if (data[0] == "end")
                {
                    break;
                }

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };
                box.Quantity = itemQuantity;
                box.PriceBox = itemPrice * itemQuantity;
                boxes.Add(box);
            }


            foreach (Box currentBox in boxes.OrderByDescending(x => x.PriceBox).ToList())
            {
                Console.WriteLine($"{currentBox.SerialNumber}");
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:f2}: {currentBox.Quantity}");
                Console.WriteLine($"-- ${currentBox.PriceBox:f2}");

            }
        }
    }
}
