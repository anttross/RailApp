using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailModels
{
    public class RailDAL
    {
        private static string conStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ant\Documents\Visual Studio 2013\Projects\RailApp\RailModels\RailDB.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = new SqlConnection(conStr);

        public void GetAllStations()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Stations", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                int i = 1;
                while(reader.Read())
                {
                    Debug.WriteLine(i + "\t" + reader[0]);
                    i++;
                }

            }
            connection.Close();
        }
    }
}
