using System;
using System.Collections.Generic;
using System.Text;

namespace Class08_Homework.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstname,string lastname,int age) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public Person(string firstname, string lastname, int age, Genre favoritemusictype, List<Song> favoritesongs)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            FavoriteMusicType = favoritemusictype;
            FavoriteSongs = favoritesongs;
        }

       

        public Song GetFavSongs(List<Song> list)
        {
            foreach (Song song in list)
            {
                Console.WriteLine($"{song.Title} by {song.Genre} - {song.Length}min");

            }
            return null;
        }

    }
}
