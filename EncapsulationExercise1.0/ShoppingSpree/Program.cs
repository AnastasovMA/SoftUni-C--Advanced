using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var peopleInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            var people = new List<Person>();

            try
            {
                foreach (var person in peopleInput)
                {
                    try
                    {
                        var inputs = person.Split("=");
                        var name = inputs[0];
                        var money = int.Parse(inputs[1]);
                        var currentPerson = new Person(name, money);
                        people.Add(currentPerson);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

                var productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                var products = new List<Product>();

                foreach (var product in productsInput)
                {
                    try
                    {
                        var inputs = product.Split("=");
                        var name = inputs[0];
                        var price = int.Parse(inputs[1]);
                        var currentProduct = new Product(name, price);
                        products.Add(currentProduct);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                string cmdArgument = Console.ReadLine();

                while (cmdArgument != "END")
                {
                    try
                    {
                        var tokens = cmdArgument.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        var personName = tokens[0];
                        var productName = tokens[1];


                        if (people.Any(e => e.Name == personName) && products.Any(p => p.Name == productName))
                        {
                            var person = people.Find(e => e.Name == personName);
                            var product = products.Find(p => p.Name == productName);

                            person.Buy(product);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    cmdArgument = Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
