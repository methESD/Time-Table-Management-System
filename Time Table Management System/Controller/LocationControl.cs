using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{
    class LocationControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public LocationControl()
        {
            con = DBConnection.getDBConnection();
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

        //Insert queries

        public void insertLocationDetails(LocationModel buildingMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            

          
        }

        //datagridview

        public DataTable getlocationvalues() {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select * from locationTB";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }

        //delete quarry

        public void DeleteLocationDet(LocationModel buildingMod)
        {
           
         

        }







    }
}
