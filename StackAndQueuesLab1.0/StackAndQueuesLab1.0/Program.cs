using System;
using System.Collections.Generic;

namespace StackAndQueuesLab1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()}");
            }
        }
    }
}
