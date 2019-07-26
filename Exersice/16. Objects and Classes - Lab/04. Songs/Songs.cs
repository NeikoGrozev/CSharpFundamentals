using System;
using System.Collections.Generic;

namespace Songs
{
    class Songs
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] date = Console.ReadLine()
                    .Split('_');

                string type = date[0];
                string name = date[1];
                string time = date[2];

                Song song = new Song(type, name, time);

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }   
}
