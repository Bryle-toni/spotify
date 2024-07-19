using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using spotify_model;

namespace spotify_DL
{
    public class SqlDbData
    {
        string connectionString = "Data Source=BRYLE\\SQLEXPRESS01;Initial Catalog=Spotifying;Integrated Security=True;";


        SqlConnection sqlConnection;

        public SqlDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Song> GetSongs()
        {
            string selectStatement = "SELECT [top], title, artist FROM Song";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            List<Song> songs = new List<Song>();

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    string top = reader["top"].ToString();
                    string title = reader["title"].ToString();
                    string artist = reader["artist"].ToString();

                    Song readSong = new Song
                    {
                        top = top,
                        title = title,
                        artist = artist
                    };

                    songs.Add(readSong);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return songs;
        }





        public int AddSong(string top, string title, string artist)
        {
            string insertStatement = "INSERT INTO Song ([top], title, artist) VALUES (@top, @title, @artist)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@top", top);
            insertCommand.Parameters.AddWithValue("@title", title);
            insertCommand.Parameters.AddWithValue("@artist", artist);

            sqlConnection.Open();
            int success = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return success;
        }


        public int UpdateSong(string top, string title, string artist)
        {
            string updateStatement = "UPDATE Song SET title = @title, artist = @artist WHERE [top] = @top";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@title", title);
            updateCommand.Parameters.AddWithValue("@artist", artist);
            updateCommand.Parameters.AddWithValue("@top", top);

            sqlConnection.Open();
            int success = updateCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return success;
        }


        public int DeleteSong(string top, string title, string artist)
        {
            string deleteStatement = "DELETE FROM Song WHERE [top] = @top AND title = @title AND artist = @artist";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);

            deleteCommand.Parameters.AddWithValue("@top", top);
            deleteCommand.Parameters.AddWithValue("@title", title);
            deleteCommand.Parameters.AddWithValue("@artist", artist);

            sqlConnection.Open();
            int success = deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return success;
        }


        public spotify_mo GetUser(string userName)
        {
            string selectStatement = "SELECT USERName FROM User WHERE USERName = @USERName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@USERName", userName);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            spotify_mo user = null;

            if (reader.Read())
            {
                user = new spotify_mo();
                user.USERName = reader["USERName"].ToString();
            }

            sqlConnection.Close();

            return user;
        }

    }
}
