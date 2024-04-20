using System;
using System.Collections.Generic;
using spotify_model;

namespace spotify_DL
{
    public class SongInfo
    {
        public string name;
        List<Song> songs = new List<Song>();

        public void DisplaySongInfo(Song song)
        {
            Console.WriteLine("Top {song.top}");
            Console.WriteLine("TITLE: {song.title}");
            Console.WriteLine("ARTIST: {song.artist}");
            Console.WriteLine("ALBUM: {song.album}");
            Console.WriteLine("SONGWRITER: {song.songwriter}");
            Console.WriteLine("PRODUCER: {song.producer}");
            Console.WriteLine("RELEASE YEAR: {song.releaseyear}");
            Console.WriteLine("LENGTHTIME: {song.lengthTime}");
            Console.WriteLine("-------------------");
        }
    }
}
