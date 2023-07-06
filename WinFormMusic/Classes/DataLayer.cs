using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WinFormMusic.Classes
{
    internal class DataLayer
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


        // Music

        public static DataTable SelectMusicBySongName(string songName)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Songs
              WHERE SongName like '%' + @SongName + '%'
            ";

            sqlCommand.Parameters.AddWithValue("@SongName", songName);

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }


        public static int InsertMusic(string songName, string songGenre, string writersCredits, string producerCredits)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO Songs(SongName, SongGenre, WritersCredits, ProducerCredits) VALUES (@SongName, @SongGenre, @WritersCredits, @ProducerCredits)";

            sqlCommand.Parameters.AddWithValue("@SongName", songName);
            sqlCommand.Parameters.AddWithValue("@SongGenre", songGenre);
            sqlCommand.Parameters.AddWithValue("@WritersCredits", writersCredits);
            sqlCommand.Parameters.AddWithValue("@ProducerCredits", producerCredits);

            result = UpdateData(sqlCommand);

            return result;
        }

        public static int UpdateMusic(int songID, string songName, string songGenre, string writersCredits, string producerCredits)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            UPDATE Songs
            SET SongName = @SongName,
                SongGenre = @SongGenre,
                WritersCredits = @WritersCredits,
                ProducerCredits = @ProducerCredits
            
            WHERE SongID = @SongID
            ";

            sqlCommand.Parameters.AddWithValue("@SongID", songID);
            sqlCommand.Parameters.AddWithValue("@SongName", songName);
            sqlCommand.Parameters.AddWithValue("@SongGenre", songGenre);
            sqlCommand.Parameters.AddWithValue("@WritersCredits", writersCredits);
            sqlCommand.Parameters.AddWithValue("@ProducerCredits", producerCredits);

            result = UpdateData(sqlCommand);

            return result;
        }

        public static int DeleteMusic(int songID)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
                DELETE FROM Songs WHERE SongID = @SongID";

            sqlCommand.Parameters.AddWithValue("@SongID", songID);

            result = UpdateData(sqlCommand);

            return result;
        }

        public static DataTable SelectAllMusic()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Songs
            ";

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }


        // DB Functions

        private static int UpdateData(SqlCommand sqlCommand)
        {
            int affectedRows = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    affectedRows = sqlCommand.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        public static DataTable SelectData(SqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    dataTable.Load(sqlCommand.ExecuteReader());
                }
            }

            return dataTable;
        }


    }
}
