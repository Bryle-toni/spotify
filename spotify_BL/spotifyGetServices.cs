using spotify_model;
using spotify_data;
using System.Collections.Generic;

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

            foreach (var song in GetAllSongs())
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

            foreach (var song in GetAllSongs())
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
