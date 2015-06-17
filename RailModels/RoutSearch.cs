using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RailModels
{
    public class RoutSearch
    {

        public static DataTable GetRoute(string arriv, string depart)
        {
            string line = null;
            DataTable dtRes = new DataTable();

            DataTable dtArr = new DataTable();
            dtArr = RailDAL.GetLineByStation(arriv);
            DataTable dtDep = new DataTable();
            dtDep = RailDAL.GetLineByStation(depart);
            for (int i = 0; i < dtArr.Rows.Count; i++)
            {
                for (int j = 0; j < dtDep.Rows.Count; j++)
                {
                    if (dtArr.Rows[i][0].ToString() == dtDep.Rows[j][0].ToString())
                    {
                        line = dtArr.Rows[i][0].ToString();
                        break;
                    }
                }
            }


            if (line != null)
            {
                dtRes = RailDAL.GetStationsByLine(line);
                int start = 0, fin = 0;

                for (int i = 0; i < dtRes.Rows.Count; i++)
                {
                    if (dtRes.Rows[i]["StationName"].ToString() == arriv)
                        start = Convert.ToInt32(dtRes.Rows[i]["Position"]);
                    if (dtRes.Rows[i]["StationName"].ToString() == depart)
                        fin = Convert.ToInt32(dtRes.Rows[i]["Position"]);
                }
                for (int i = 0; i < dtRes.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtRes.Rows[i]["Position"]) < (start < fin ? start : fin))
                    {
                        dtRes.Rows.Remove(dtRes.Rows[i]);
                        i--;
                        continue;
                    }
                    if (Convert.ToInt32(dtRes.Rows[i]["Position"]) > (start < fin ? fin : start))
                    {
                        dtRes.Rows.Remove(dtRes.Rows[i]);
                        i--;
                    }
                }
                if (start > fin)
                {
                    DataView dv = dtRes.DefaultView;
                    dv.Sort = "Position desc";
                    dtRes = dv.ToTable();
                }

                return dtRes;
               // Combain(dtRes, null);

            }
            else
            {
                string lineMid = null;
                DataTable dtDepMid = new DataTable();
                dtDepMid = RailDAL.GetLineByStation(arriv);
                lineMid = dtDepMid.Rows[0][0].ToString();
                dtDepMid = RailDAL.GetStationsByLine(lineMid);

                for (int i = 0; i < dtDepMid.Rows.Count; i++)
                {
                    if ((bool)dtDepMid.Rows[i][2])
                    {
                       // dtDepMid.Rows[i][0].ToString();
                        GetRoute(arriv, dtDepMid.Rows[i][0].ToString());
                        dtRes= Combain(dtRes, GetRoute(arriv, dtDepMid.Rows[i][0].ToString()));
                        GetRoute(dtDepMid.Rows[i][0].ToString(), depart);
                        dtRes= Combain(dtRes, GetRoute(dtDepMid.Rows[i][0].ToString(), depart));
                        return dtRes;
                    }
                }

                return dtRes;

            }
               // return null;
        }

        private static DataTable Combain(DataTable origin, DataTable additional)
        {
            DataRow dr;
            if (origin.Rows.Count != 0 )
                for (int i = 0; i < additional.Rows.Count; i++)
                {
                    if (origin.Rows[origin.Rows.Count - 1][0].ToString() != additional.Rows[i][0].ToString())
                    {
                        dr = origin.NewRow();
                        dr[0] = additional.Rows[i][0];
                        dr[1] = additional.Rows[i][1];
                        dr[2] = additional.Rows[i][2];
                        origin.Rows.Add(dr);
                    }
                }
            else
                origin = additional;
            return origin;
        }
            

    }
}
