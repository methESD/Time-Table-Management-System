using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDialog();
        }

        private void customizeDialog()
        {
            panellocation.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panellocation.Visible = true)
                panellocation.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                // hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            showSubMenu(panellocation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddRooms());
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

    
    }
}
