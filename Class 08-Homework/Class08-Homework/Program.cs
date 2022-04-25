using Class08_Homework.Models;
using System;
using System.Collections.Generic;

namespace Class08_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Tiesto-Love comes again", 4, Genre.Techno);
            Song song2 = new Song("ACDC-Thunderstruck", 6, Genre.Rock);
            List<Song> songList = new List<Song> { song1, song2 };



            Person vojce = new Person("Vojce", "Jakovleski", 28, Genre.Techno, songList);
            Person hater = new Person("Hater", "Hejterovski", 33);




            static void GetFavSongs(Person list)
            {
                Console.WriteLine($"The favourte songs of {list.FirstName}, {list.LastName}, age {list.Age}  are :");
                if (list.FavoriteSongs != null)
                {
                    foreach (Song song in list.FavoriteSongs)

                        Console.WriteLine($"{song.Title} genre {song.Genre} - {song.Length}min");

                }
                else
                    Console.WriteLine($"There are no favourte song of {list.FirstName}  {list.LastName} cos hereaally hates  music ");

            }



            GetFavSongs(vojce);
            GetFavSongs(hater);
        }
    }
}
