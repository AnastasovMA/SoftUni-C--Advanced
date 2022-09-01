using System;

namespace _03.PlayersAndMonsters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var wizard = new Wizard("Joe", 20);
            var darkKnight = new Elf("Pesho", 69);

            Console.WriteLine(wizard);
            Console.WriteLine(darkKnight);
        }
    }
}
