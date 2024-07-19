using System;
using System.Collections.Generic;

namespace spotify_business
{
    public class SongValidationServices
    {
        SongGetServices getServices = new SongGetServices();

        public bool CheckIfArtistExists(string artist)
        {
            bool result = getServices.GetSongsByArtist(artist).Count > 0;
            return result;
        }

        public bool CheckIfSongExists(string top, string title, string artist)
        {
            bool result = getServices.GetSong(top, title, artist) != null;
            return result;
        }
        public bool CheckIfTopExists(string top)
        {
            bool result = getServices.GetSongByTop(top) != null;
            return result;
        }
    }
}
