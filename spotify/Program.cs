using System;
using spotify_model;
using spotify_BL;
using spotify_DL;

namespace Spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string userName = Console.ReadLine();

            verify spotifyData = new verify();
            bool result = spotifyData.verifyUser(userName);

            if (result)
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Please choose a date:");
                    Console.WriteLine("1. April 1, 2024");
                    Console.WriteLine("2. April 2, 2024");
                    Console.WriteLine("3. April 3, 2024");
                    Console.WriteLine("4. April 4, 2024");
                    Console.WriteLine("5. April 5, 2024");
                    Console.Write("Enter your choice (1-5): ");
                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                    {

                        Console.Write("Enter your choice (1-5): ");
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    }

                    DateTime selectedDate;
                    switch (choice)
                    {
                        case 1:
                            selectedDate = new DateTime(2024, 4, 1);
                            break;
                        case 2:
                            selectedDate = new DateTime(2024, 4, 2);
                            break;
                        case 3:
                            selectedDate = new DateTime(2024, 4, 3);
                            break;
                        case 4:
                            selectedDate = new DateTime(2024, 4, 4);
                            break;
                        case 5:
                            selectedDate = new DateTime(2024, 4, 5);
                            break;
                        default:
                            selectedDate = DateTime.Now;
                            break;
                    }

                    Song[] top10Songs = SpotifyList.GetTop10Songs(selectedDate);

                    SongInfo myBestSongsPlaylist = new SongInfo();
                    myBestSongsPlaylist.name = "Top 10";

                    Console.WriteLine("Top 10 Songs for {selectedDate.ToShortDateString()}:");

                    foreach (var song in top10Songs)
                    {
                        myBestSongsPlaylist.DisplaySongInfo(song);
                    }

                    Console.WriteLine("Do you want to choose another date? (yes/no)");
                    string response = Console.ReadLine();
                    exit = response.ToLower() != "yes";
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
