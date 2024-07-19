using spotify_business;
using spotify_DL;
using spotify_model;

namespace spotify_BL
{
    public class SongCUD
    {
        SongValidationServices validationServices = new SongValidationServices();
        SqlDbData songData = new SqlDbData();

        public bool CreateSong(Song song)
        {
            bool result = false;

            if (!validationServices.CheckIfSongExists(song.top, song.title, song.artist))
            {
                result = songData.AddSong(song.top, song.title, song.artist) > 0;
            }

            return result;
        }

        public bool UpdateSong(Song song)
        {
            bool result = false;

            if (validationServices.CheckIfTopExists(song.top))
            {
                result = songData.UpdateSong(song.top, song.title, song.artist) > 0;
            }

            return result;
        }

        public bool DeleteSong(Song song)
        {
            bool result = false;

            if (validationServices.CheckIfSongExists(song.top, song.title, song.artist))
            {
                result = songData.DeleteSong(song.top, song.title, song.artist) > 0;
            }

            return result;
        }
    }
}
