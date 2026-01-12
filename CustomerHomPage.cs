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
    public partial class CustomerHomPage : Form
    {
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        public CustomerHomPage()
        {
            InitializeComponent();
        }

        private void CustomerHomPage_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "Welcome to " + Loginpage.FName + " "+ Loginpage.LName + " " ;

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuSetGoal_Click(object sender, EventArgs e)
        {
            SetGoal sg = new SetGoal();
            sg.ShowDialog();
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            UpdateUser uu = new UpdateUser();
            uu.ShowDialog();
        }

        private void mnuRemoveAcc_Click(object sender, EventArgs e)
        {
            int UserID = Loginpage.UID;
            int data = uds.RemoveAcc(UserID);
            if(data>0)
            {
                MessageBox.Show("Remove Account Success", "User Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void mnuProgress_Click(object sender, EventArgs e)
        {
            Apply_Acticity aa = new Apply_Acticity();
            aa.ShowDialog();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePws up = new UpdatePws();
            up.ShowDialog();
        }
    }
}
