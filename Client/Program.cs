using spotify_DL;
using spotify_model;
using spotify_BL;
using System;
using System.Collections.Generic;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbData data = new SqlDbData();
            var songs = data.GetSongs();

            foreach (var song in songs)
            {
                Console.WriteLine(song.top);
                Console.WriteLine(song.title);
                Console.WriteLine(song.artist);
                Console.WriteLine("-------------------");
            }
        }
    }
}
