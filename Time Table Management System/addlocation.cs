using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;


namespace Time_Table_Management_System
{
    public partial class addlocation : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public addlocation()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        LocationControl LocationControl = new LocationControl();
        LocationModel locationModel = new LocationModel();

        private void addbtn_Click(object sender, EventArgs e)
        {
  MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

}
