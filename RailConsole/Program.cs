using RailModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;


namespace RailConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            
           // List<string> l = new List<string>();

            DataTable allStations = RoutSearch.GetRoute("BB", "D");
            for (int i = 0; i < allStations.Rows.Count; i++)
                Debug.WriteLine(allStations.Rows[i][0].ToString());
    

            Debug.WriteLine("");

                //          foreach (string s in l)
               ;

        }

        //public static DataTable GetRoute(string arriv, string depart)
        //{
        //    string line = null;

        //    DataTable dtArr = new DataTable();
        //    dtArr = RailDAL.GetLineByStation(arriv);
        //    DataTable dtDep = new DataTable();
        //    dtDep = RailDAL.GetLineByStation(depart);
        //    for (int i = 0; i < dtArr.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dtDep.Rows.Count; j++)
        //        {
        //            if (dtArr.Rows[i][0].ToString() == dtDep.Rows[j][0].ToString())
        //                line = dtArr.Rows[i][0].ToString();
        //        }
        //    }
        //    DataTable dtRes = RailDAL.GetStationsByLine(line);
        //    int start = 0, fin = 0;

        //    for (int i = 0; i < dtRes.Rows.Count; i++)
        //    {
        //        if (dtRes.Rows[i]["StationName"].ToString() == arriv)
        //            start = Convert.ToInt32(dtRes.Rows[i]["Position"]);
        //        if (dtRes.Rows[i]["StationName"].ToString() == depart)
        //            fin = Convert.ToInt32(dtRes.Rows[i]["Position"]);
        //    }
        //    for (int i = 0; i < dtRes.Rows.Count; i++)
        //    {
        //        if (Convert.ToInt32(dtRes.Rows[i]["Position"]) < (start < fin ? start : fin))
        //        {
        //            dtRes.Rows.Remove(dtRes.Rows[i]);
        //            i--;
        //            continue;
        //        }
        //        if (Convert.ToInt32(dtRes.Rows[i]["Position"]) > (start < fin ? fin : start))
        //        {
        //            dtRes.Rows.Remove(dtRes.Rows[i]);
        //            i--;
        //        }
        //    }
        //    if (start > fin)
        //    {
        //        DataView dv = dtRes.DefaultView;
        //        dv.Sort = "Position desc";
        //        dtRes = dv.ToTable();
        //    }

        //    return dtRes;
        //}
    }
}
