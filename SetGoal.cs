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
    public partial class SetGoal : Form
    {
        dsFitnessTrackingTableAdapters.GoalsTableAdapter gds = new dsFitnessTrackingTableAdapters.GoalsTableAdapter();
        public SetGoal()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if(txtTargetCal.Text == "")
            {
                MessageBox.Show("Pls Enter Target Calories", "Goals Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clsGoal g = new clsGoal();
            g.StartDate = dtpStartDate.Value;
            g.EndDate = dtpEndDate.Value;
            string Status = "Accept";
            g.TotalCalories = Convert.ToInt32(txtTargetCal.Text);
            int data=gds.SetGoal(Loginpage.UID, g.StartDate.ToString(), g.EndDate.ToString(), g.TotalCalories, Status);
            if (data > 0)
            {
                MessageBox.Show("SetGoals Success", "Goals Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
