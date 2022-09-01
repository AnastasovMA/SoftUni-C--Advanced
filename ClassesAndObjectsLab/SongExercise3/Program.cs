using System;
using System.Collections.Generic;
using System.Linq;

namespace SongExercise3
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    };


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song(); // песен в класа песни

                song.TypeList = type; // песента има вид
                song.Name = name; // песента има име
                song.Time = time; // песента има време

                songs.Add(song); // добавяме песента в листа "Песни"
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs) // Минаваме през песента в списъка песни!
                {
                    Console.WriteLine(song.Name); // пишем всички песни
                }
            }
            else
            {
                foreach (Song song in songs) 
                {
                    if (song.TypeList == typeList) // Ако вида песен е същия като зададения тип, пишем името на песента.
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
