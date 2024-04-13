using System;
using System.Collections.Generic;
using spotify_model;

namespace Spotify
{
    public class Playlist
    {
        public string name;
        List<Song> songs = new List<Song>();
        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        public void SearchSong(string artist)
        {
            foreach (var song in songs)
            {
                if (song.artist.Contains(artist))
                {
                    Console.WriteLine("SONG FOUND...");
                    DisplaySongInfo(song);
                }
            }
        }
        public void DisplaySongInfo(Song song)
        {
            Console.WriteLine("My Top 10 " + name + "...");
            Console.WriteLine("");
            Console.WriteLine("Top: " + song.top);
            Console.WriteLine("TITLE: " + song.title);
            Console.WriteLine("ARTIST: " + song.artist);
            Console.WriteLine("ALBUM: " + song.album);
            Console.WriteLine("SONGWRITER: " + song.songwriter);
            Console.WriteLine("PRODUCER: " + song.producer);
            Console.WriteLine("RELEASE YEAR: " + song.releaseyear);
            Console.WriteLine("LENGTHTIME: " + song.lengthTime);
            Console.WriteLine("-------------------");
        }
        public void DeleteSong(Song song)
        {
            songs.Remove(song);
        }
    }
}
