using System;

namespace Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            // отпечата книга като екипът му поеме част от сумата 
            // % намаления
            // заплащатане на дизайнер

            double pricePerPage = double.Parse(Console.ReadLine());
            double pricePerCover = double.Parse(Console.ReadLine());
            int percentagePaper = int.Parse(Console.ReadLine());
            double designer = double.Parse(Console.ReadLine());
            int percetageTeam = int.Parse(Console.ReadLine());

            double bookPrice = pricePerPage * 899 + pricePerCover * 2;
            double discountPaper = (bookPrice * percentagePaper / 100);
            double discountedBookPrice = bookPrice - discountPaper + designer;
            double discountTeam = (discountedBookPrice * percetageTeam / 100);
            double money = discountedBookPrice - discountTeam;

            Console.WriteLine($"Avtonom should pay {money:f2} BGN.");

        }
    }
}
