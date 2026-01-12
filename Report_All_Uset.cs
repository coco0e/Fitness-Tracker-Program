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
   
    public partial class Report_All_Uset : Form
    {
        dsFitnessTrackingTableAdapters.UsersTableAdapter uds = new dsFitnessTrackingTableAdapters.UsersTableAdapter();
        public Report_All_Uset()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_All_Uset_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int uid = Loginpage.UID;
            uds.CheckUser_Data(uid);
            dt = uds.CheckUser_Data(uid);
            if(dt.Rows.Count>0)
            {
                string AName = dt.Rows[0]["UserName"].ToString();
                //if(AName != "Admin")
                //{
                //    dgvDisplay.DataSource = uds.GetData();
                //}
            }
           

        }
    }
}
