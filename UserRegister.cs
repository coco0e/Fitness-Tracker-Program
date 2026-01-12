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
    public partial class UserRegister : Form
    {
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        public UserRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstN.Text == "")
            {
                MessageBox.Show("Please Enter First Name", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstN.Focus();
            }
            else if (txtLastN.Text == "")
            {
                MessageBox.Show("Please Enter Last Name", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastN.Focus();
            }
            else if (txtUserN.Text == "")
            {
                MessageBox.Show("Please Enter UserName", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserN.Focus();
            }
            else if (txtPws.Text == "")
            {
                MessageBox.Show("Please Enter Password", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPws.Focus();

            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpDOB.Text == "")
            {
                MessageBox.Show("Please Enter Date of birth", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
            }
            else if (cboGender.Text == "")
            {
                MessageBox.Show("Please Choose Gender", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGender.Focus();
            }
            else if (txtPh.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPh.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Enter Address", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
            }
            else if (txtWeight.Text == "")
            {
                MessageBox.Show("Please Enter Weight", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
            }
            else if (txtHeight.Text == "")
            {
                MessageBox.Show("Please Enter Height", " Register Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();
            }
            else
            {
              int data=  uds.RegisterUser(txtFirstN.Text,txtLastN.Text,txtUserN.Text,txtPws.Text,txtEmail.Text,dtpDOB.Value.ToString(), cboGender.Text, txtPh.Text, txtaddress.Text, Convert.ToInt32(txtWeight.Text), Convert.ToInt32(txtHeight.Text));
                if (data > 0)
                {
                    MessageBox.Show("Register User Success", "Register Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
