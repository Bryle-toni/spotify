using spotify_model;
using spotify_data;
using System.Collections.Generic;
using System.Linq;

namespace spotify_business
{
    public class SongGetServices
    {
        public List<Song> GetAllSongs()
        {
            SpotifyData songData = new SpotifyData();
            return songData.GetSongs();
        }

        public List<Song> GetSongsByArtist(string artist)
        {
            List<Song> songsByArtist = new List<Song>();
            var allSongs = GetAllSongs();
            foreach (var song in allSongs)
            {
                if (song.artist == artist)
                {
                    songsByArtist.Add(song);
                }
            }
            return songsByArtist;
        }

        public Song GetSong(string top, string title, string artist)
        {
            Song foundSong = null;
            var allSongs = GetAllSongs();
            foreach (var song in allSongs)
            {
                if (song.top == top && song.title == title && song.artist == artist)
                {
                    foundSong = song;
                    break;
                }
            }
            return foundSong;
        }
    }
}
