/**
 *  Troskunov Anton
 *  310746482
 *  
 *  Railway route finder
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RailModels;

namespace RailForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable allStations1 = RailDAL.GetAllStations();
            DataTable allStations2 = RailDAL.GetAllStations();
            cmbArriv.DataSource = allStations1;
            cmbArriv.DisplayMember = "StationName";
            cmbDepp.DataSource = allStations2;
            cmbDepp.DisplayMember = "StationName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
            foreach (DataRow dr in RoutSearch.GetRoute(cmbArriv.Text, cmbDepp.Text).Rows)
            {
                if (dr != null)
                {
                    var s = dr["Line"].ToString() + "\t" + dr["StationName"].ToString();
                    lstRes.Items.Add(s);
                }
            }
        }
    }
}
