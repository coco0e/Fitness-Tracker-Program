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
    public partial class Loginpage : Form
    {
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        int count = 0;
        public static string FName, LName;
        public static int UID;
        public Loginpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister r = new UserRegister();
            r.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string UserName, Password;
            UserName = txtUserName.Text;
            Password = txtPws.Text;
           dt = uds.CheckUser(UserName, Password);
            if(dt.Rows.Count > 0)
            {
                FName = dt.Rows[0]["FirstName"].ToString();
                LName = dt.Rows[0]["LastName"].ToString();
                UID =Convert.ToInt32 (dt.Rows[0]["UserID"].ToString());
                string UName = dt.Rows[0]["UserName"].ToString();
                if(UName == "Admin")
                {
                    MessageBox.Show("Admin Login Successful", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminHomePage ahp = new AdminHomePage();
                    ahp.ShowDialog();
                }


                MessageBox.Show("Login Successful", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
               CustomerHomPage chp = new CustomerHomPage();
                chp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fail Login", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count += 1;
                if(count>=3)
                {
                   
                    MessageBox.Show("Over there time login", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
