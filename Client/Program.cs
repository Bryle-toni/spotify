using spotify_DL;
using spotify_model;
using spotify_BL;
using new_email_tool;
using System;
using Org.BouncyCastle.Utilities;
using spotify_business;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SongGetServices songServices = new SongGetServices();
            SongCUD songCUD = new SongCUD();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Spotify Song Management");
                Console.WriteLine("1. Display all songs");
                Console.WriteLine("2. Add a song");
                Console.WriteLine("3. Update a song");
                Console.WriteLine("4. Delete a song");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        DisplaySongs(songServices);
                        break;
                    case "2":
                        AddSong(songCUD, emailService);
                        break;
                    case "3":
                        UpdateSong(songCUD, emailService);
                        break;
                    case "4":
                        DeleteSong(songCUD, emailService);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void DisplaySongs(SongGetServices songServices)
        {
            var songs = songServices.GetAllSongs();
            foreach (var song in songs)
            {
                Console.WriteLine("Top: " + song.top);
                Console.WriteLine("Title: " + song.title);
                Console.WriteLine("Artist: " + song.artist);
                Console.WriteLine();
            }
        }

        static bool AddSong(SongCUD songCUD, EmailService emailservice)
        {
            Console.Write("Enter Song Top: ");
            string top = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Artist: ");
            string artist = Console.ReadLine();

            Song newSong = new Song { top = top, title = title, artist = artist };

            if (songCUD.CreateSong(newSong))
            {
                Console.WriteLine("Song added successfully.");

                emailservice.SendEmail("Song Added", "A new song has been added");
                return true;
            }
            return false;
        }

        static bool UpdateSong(SongCUD songCUD, EmailService emailService)
        {
            Console.Write("Enter Song Top: ");
            string top = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Artist: ");
            string artist = Console.ReadLine();

            Song updatedSong = new Song { top = top, title = title, artist = artist };

            if (songCUD.UpdateSong(updatedSong))
            {
                Console.WriteLine("Song updated successfully.");

                emailService.SendEmail("Song Updated", "A song has been updated");
                return true;
            }
            return false;
        }

        static bool DeleteSong(SongCUD songCUD, EmailService emailservice)
        {
            Console.Write("Enter Song Top: ");
            string top = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Song songToDelete = new Song { top = top, title = title };

            if (songCUD.DeleteSong(songToDelete))
            {
                Console.WriteLine("Song deleted successfully.");

                emailservice.SendEmail("Song Deleted", "A song has been deleted");
                return true;
            }
            return false;
        }
    }
}
