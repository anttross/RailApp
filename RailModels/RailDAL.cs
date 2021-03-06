﻿/**
 *  Troskunov Anton
 *  310746482
 *  
 *  Railway route finder
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace RailModels
{
    public class RailDAL
    {
        private static string conStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ant\Documents\Visual Studio 2013\Projects\RailApp\RailModels\RailDB.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection = new SqlConnection(conStr);

        public static DataTable GetAllStations()
        {
            return StoredProcedure("GetAllStations", null, null);
        }

        public static DataTable GetStationsByLine(string line)
        {
            return StoredProcedure("GetAllStationsByLine", line, null);
        }

        public static DataTable GetLineByStation(string station, string line)
        {
            return StoredProcedure("GetLineByStation", line, station);
        }

        private static DataTable StoredProcedure(string procName, string line, string station)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.CommandText = procName;
            if(line !=null)
                command.Parameters.AddWithValue("@Line", line);
            if (station != null)
                command.Parameters.AddWithValue("@Station", station);
            SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
            
            connection.Close();
            return dt;
        }

    }
}
