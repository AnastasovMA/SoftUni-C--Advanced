using System;

namespace CustomRandomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = "Mario";
            RandomList random = new RandomList(input);

            Console.WriteLine(random.RemoveRandomElement());
            
        }
    }
}
