using System;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine(); // + - * / %


            // При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е ЧЕТЕН или НЕЧЕТЕН
            //При обикновеното деление – резултата. При модулното деление – остатъка.
            //Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. 

            double results = 0.00; 
            string type = "";

            switch (op)
            {
                case "+":
                    results = n1 + n2;
                    break;
                case "-":
                    results = n1 - n2;
                    break;
                case "*":
                    results = n1 * n2;
                    break;
                case "/":
                    results = n1 / n2;
                    break;
                case "%":
                    results = n1 % n2;
                    break;
            }
            if (op == "+" || op == "-" || op == "*")
            {
                if (results % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                Console.WriteLine($"{n1} {op} {n2} = {results} - {type}");
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{n1} / {n2} = {results:F2}");
            }
            else if (op == "%")
            {
                Console.WriteLine($"{n1} % {n2} = {results}");
            }


            // Да се отпечата на конзолата един ред:
            //•	Ако операцията е събиране, изваждане или умножение:
            //o    "{N1} {оператор} {N2} = {резултат} – {even/odd}"
            
            
            //•	Ако операцията е деление:
            //o   "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            
            
            //•	Ако операцията е модулно деление:
            // o   "{N1} % {N2} = {остатък}"
            
            
            //•	В случай на деление с 0(нула): 
            //o   "Cannot divide {N1} by zero"

        }
    }
}
