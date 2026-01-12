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
    public partial class Apply_Acticity : Form
    {
        dsFitnessTrackingTableAdapters.GoalsTableAdapter gds = new dsFitnessTrackingTableAdapters.GoalsTableAdapter();
        dsFitnessTrackingTableAdapters.ActivityTableAdapter ads = new dsFitnessTrackingTableAdapters.ActivityTableAdapter();
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        dsFitnessTrackingTableAdapters.ApplyActivityTableAdapter aads = new dsFitnessTrackingTableAdapters.ApplyActivityTableAdapter();
        int UserWeight;
        int TotalActivity;
       
        public Apply_Acticity()
        {
            InitializeComponent();
        }
        private void AutoID()
        {
            DataTable dt = new DataTable();
            dt = aads.GetData();

            if (dt.Rows.Count == 0)
            {
                lblActivityID.Text = "AA_001";
            }
            else
            {
                int sizerow = dt.Rows.Count - 1;
                string oldID = dt.Rows[sizerow][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(3, 3));

                if (newID >= 0 && newID <= 9)
                {
                    lblActivityID.Text = "AA_00" + (newID + 1);
                }

            }
        }
        private void Apply_Acticity_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            AutoID();
            txtMatric1.Text = "0";
            txtMatric2.Text = "0";
            txtMatric3.Text = "0";
            //task 1 b display when form load 
            int UserID = Loginpage.UID;
          dt =  uds.CheckUser_Data(UserID);
            if(dt.Rows.Count>0)
            {
                txtFullname.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                txtGender.Text = dt.Rows[0]["Gender"].ToString();
                txtWeight.Text = dt.Rows[0]["Weight"].ToString();
                txtHeight.Text = dt.Rows[0]["Height"].ToString();
                
            }
            //
            DataTable dtt = new DataTable();
            dtt = ads.GetData();
            if(dtt.Rows.Count>0)
            {
                for(int i = 0; i< dtt.Rows.Count; i++)
                {
                    cboActivityN.Items.Add(dtt.Rows[i][1].ToString());
                }
            }
        }

        private void cboActivityN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt, dtt = new DataTable();
            String AName = cboActivityN.SelectedItem.ToString();
            dt = ads.Check_Activity(AName);
            if(dt.Rows.Count>0)
            {
                lblMatric1.Text = dt.Rows[0][2].ToString();
                lblMatric2.Text = dt.Rows[0][3].ToString();
                lblMatric3.Text = dt.Rows[0][4].ToString();
            }
          
                int M1, M2, M3, Total_Calories;
                M1 = Convert.ToInt32(txtMatric1.Text);
                M2 = Convert.ToInt32(txtMatric2.Text);
                M3 = Convert.ToInt32(txtMatric3.Text);
                if(cboActivityN.SelectedIndex ==0)
            {
                int UserID = Loginpage.UID;
                dtt = gds.CheckTargetCalories(UserID);
                if (dtt.Rows.Count > 0)
                {
                    int TargetCal = Convert.ToInt32(dtt.Rows[0]["TotalCalories"].ToString());
                    int Cal_Per_Minute = Convert.ToInt32(5 * 3.5 * UserWeight) / TargetCal;
                    Total_Calories = Cal_Per_Minute * M3;
                    txtTtCalories.Text = Total_Calories.ToString();
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
