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
using Bunifu.UI.WinForms.BunifuButton;

namespace Time_Table_Management_System
{
    public partial class AddRooms : Form
    {
   
        public AddRooms()
        {
            InitializeComponent();

            string value = "";
            bool isChecked = rbLecHall.Checked;
            if (isChecked)
                value = rbLecHall.Text;
            else
                value = rbLab.Text;


        }

        private void AddRooms_Load(object sender, EventArgs e)
        {

        }



        private void addbtn_Click(object sender, EventArgs e)
        {
        
           

        }
    }
}
