namespace P03_FootballBetting
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data;
    using System;
    using System.Data;
    //Това ни е конзолното приложение - client
    public class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext db = new FootballBettingContext();

            db.Database.EnsureCreated();

            Console.WriteLine("Db created successfully!");

        }
    }
}
