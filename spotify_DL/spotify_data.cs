using System.Collections.Generic;
using spotify_model;
using spotify_DL;

namespace spotify_data
{
    public class SpotifyData
    {
        List<Song> songs;
        SqlDbData sqlData;

        public SpotifyData()
        {
            songs = new List<Song>();
            sqlData = new SqlDbData();
        }

        public List<Song> GetSongs()
        {
            songs = sqlData.GetSongs();
            return songs;
        }

        public spotify_mo GetUser(string userName)
        {
            return sqlData.GetUser(userName);
        }

        public int AddSong(Song song)
        {
            return sqlData.AddSong(song.top, song.title, song.artist);
        }

        public int UpdateSong(Song song)
        {
            return sqlData.UpdateSong(song.top, song.title, song.artist);
        }

        public int DeleteSong(Song song)
        {
            return sqlData.DeleteSong(song.top, song.title, song.artist);
        }
    }
}
