using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists2021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();

            // numbers.Count;
            // numbers.Capacity;

            // numbers.Add(); - adds an element, count++
            // numbers.TrimExcess();
            // numbers.AddRange(); - adds the element of the specified collection at the end of the List
            // numbers.Remove(); - removes an element, count--;
            // numbers.Insert(index, element) - inserts an element to a given index
            // numbers.Contain(); - checks if the element is in there.
            // numbers.Sort(); - sorts the array/list in ascending order.
            // numbers.Reverse()- writes the list in reverse order.

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
