using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracking_Software
{
    public partial class UpdateUser : Form
    {
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int UserID = Loginpage.UID;
            dt = uds.CheckUser_Data(UserID);
            if(dt.Rows.Count>0)
            {
                txtFirstN.Text = dt.Rows[0][1].ToString();
                txtLastN.Text = dt.Rows[0][2].ToString();
                txtUserN.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtWeight.Text = dt.Rows[0]["Weight"].ToString();
                txtHeight.Text = dt.Rows[0]["Height"].ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, UserName, Password, Email;
            int Weight, Height;
            int UserID = Loginpage.UID;
            FirstName = txtFirstN.Text;
            LastName = txtLastN.Text;
            UserName = txtUserN.Text;
            Password = txtPws.Text;
            Email = txtEmail.Text;
            Weight = Convert.ToInt32(txtWeight.Text);
            Height = Convert.ToInt32(txtHeight.Text);
           int data = uds.UpdateUser(FirstName, LastName, UserName, Password, Email, Weight, Height, UserID);
            if (data>0)
            {
                MessageBox.Show("Update User Success", " Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
