using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song newSong = new Song(typeList, name, time);
                songs.Add(newSong);
            }

            string sortingCriteria = Console.ReadLine();

            if (sortingCriteria == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(x => x.TypeList == sortingCriteria))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
