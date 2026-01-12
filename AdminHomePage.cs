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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void mnuRpAllu_Click(object sender, EventArgs e)
        {
            Report_All_Uset auser = new Report_All_Uset();
            auser.ShowDialog();
                
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void mnuActivity_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
