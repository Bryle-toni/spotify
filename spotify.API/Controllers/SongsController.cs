using Microsoft.AspNetCore.Mvc;
using spotify_BL;
using spotify_business;
using spotify_model;
using System.Collections.Generic;

namespace spotifyAPI.Controllers
{
    [ApiController]
    [Route("api/song")]
    public class SongsController : ControllerBase
    {
        SongGetServices _songGetServices;
        SongCUD _songCUD;

        public SongsController()
        {
            _songGetServices = new SongGetServices();
            _songCUD = new SongCUD();
        }

        [HttpGet]
        public IEnumerable<Song> GetSongs()
        {
            var songs = _songGetServices.GetAllSongs();
            List<Song> songList = new List<Song>();

            foreach (var item in songs)
            {
                songList.Add(new Song { top = item.top, title = item.title, artist = item.artist });
            }

            return songList;
        }

        [HttpPost]
        public JsonResult AddSong(Song request)
        {
            var result = _songCUD.CreateSong(request);
            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateSong(Song request)
        {
            var result = _songCUD.UpdateSong(request);
            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteSong(Song request)
        {
            var result = _songCUD.DeleteSong(request);
            return new JsonResult(result);
        }
    }
}
