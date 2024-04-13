using System;
using spotify_model;
using spotify_BL;
namespace Spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string USERName = Console.ReadLine();

            verify spotify_data = new verify();
            bool result = spotify_data.verifyUser(USERName);

            if (result)
            {

                Playlist myBestSongsPlaylist = new Playlist();
                myBestSongsPlaylist.name = "recommended songs..";
                Song No1Song = new Song();

                No1Song.top = "1";
                No1Song.title = "Talking To The Moon";
                No1Song.artist = "Bruno Mars";
                No1Song.album = "Doo-Wops & Hooligans";
                No1Song.songwriter = "Bruno Mars, Philip Lawrence, Ari Levine, Albert Winkler, Jeff Bhasker";
                No1Song.producer = "The Smeezingtons";
                No1Song.releaseyear = "2011";
                No1Song.lengthTime = "3:37";

                Song No2Song = new Song
                {
                    top = "2",
                    title = "You Belong With Me",
                    artist = "Taylor Swift",
                    album = "Fearless",
                    songwriter = "Taylor Swift, Liz Rose",
                    producer = "Taylor Swift, Nathan Chapman",
                    releaseyear = "2009",
                    lengthTime = "3:52",
                };

                Song No3Song = new Song
                {
                    top = "3",
                    title = "Circles",
                    artist = "Post Malone",
                    album = "Hollywood's Bleeding",
                    songwriter = "Austin Post, Louis Bell, Adam Feeney, Kaan Gunesberk",
                    producer = "Post Malone, Louis Bell, Frank Dukes",
                    releaseyear = "2019",
                    lengthTime = "3:35",
                };

                Song No4Song = new Song
                {
                    top = "4",
                    title = "Baby",
                    artist = "Justin Bieber",
                    album = "My World 2.0",
                    songwriter = "Justin Bieber, Christopher Stewart, Terius Nash, Christopher Bridges, Christina Milian",
                    producer = "Tricky Stewart, The-Dream",
                    releaseyear = "2010",
                    lengthTime = "3:34",
                };

                Song No5Song = new Song
                {
                    top = "5",
                    title = "Every Breath You Take",
                    artist = "The Police",
                    album = "Synchronicity",
                    songwriter = "Sting",
                    producer = "The Police, Hugh Padgham",
                    releaseyear = "1983",
                    lengthTime = "3:56",
                };

                Song No6Song = new Song
                {
                    top = "6",
                    title = "An Art Gallery Could Never Be As Unique As You",
                    artist = "mrld",
                    album = "An Art Gallery Could Never Be As Unique As You",
                    songwriter = "mrld, Meriel de Jesus",
                    producer = "mrld, Meriel de Jesus",
                    releaseyear = "2019",
                    lengthTime = "2:38",
                };

                Song No7Song = new Song
                {
                    top = "7",
                    title = "Sleep Tonight",
                    artist = "December Avenue",
                    album = "December Avenue",
                    songwriter = "December Avenue",
                    producer = "December Avenue",
                    releaseyear = "2017",
                    lengthTime = "4:49",
                };

                Song No8Song = new Song
                {
                    top = "8",
                    title = "Beauty And A Beat",
                    artist = "Justin Bieber, Nicki Minaj",
                    album = "Believe",
                    songwriter = "Max Martin, Anton Zaslavski, Savan Kotecha, Onika Maraj",
                    producer = "Max Martin, Zedd",
                    releaseyear = "2012",
                    lengthTime = "3:47",
                };

                Song No9Song = new Song
                {
                    top = "9",
                    title = "I Like Me Better",
                    artist = "Lauv",
                    album = "I Met You When I Was 18",
                    songwriter = "Lauv, Michael Matosic",
                    producer = "Lauv",
                    releaseyear = "2017",
                    lengthTime = "3:17",
                };

                Song No10Song = new Song
                {
                    top = "10",
                    title = "Mean It",
                    artist = "Lauv, LANY",
                    album = "How I'm Feeling",
                    songwriter = "Ari Leff, Paul Klein, Michael Matosic, Michael Pollack, John Hill, Jordan Palmer",
                    producer = "LANY, Mike Crossey, Lauv",
                    releaseyear = "2019",
                    lengthTime = "3:52",
                };

                myBestSongsPlaylist.DisplaySongInfo(No1Song);
                myBestSongsPlaylist.DisplaySongInfo(No2Song);
                myBestSongsPlaylist.DisplaySongInfo(No3Song);
                myBestSongsPlaylist.DisplaySongInfo(No4Song);
                myBestSongsPlaylist.DisplaySongInfo(No5Song);
                myBestSongsPlaylist.DisplaySongInfo(No6Song);
                myBestSongsPlaylist.DisplaySongInfo(No7Song);
                myBestSongsPlaylist.DisplaySongInfo(No8Song);
                myBestSongsPlaylist.DisplaySongInfo(No9Song);
                myBestSongsPlaylist.DisplaySongInfo(No10Song);
            }

            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
