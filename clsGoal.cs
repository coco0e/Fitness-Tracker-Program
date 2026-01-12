using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracking_Software
{
    class clsGoal
    {
        private DateTime SDate, EDate;
        private int TCalories;
        private string s;
       

        public DateTime StartDate
        {
            get
            {
                return SDate;
            }
            set
            {
                SDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return EDate;
            }
            set
            {
                EDate = value;
            }
        }
        public int TotalCalories
        {
            get
            {
                return TCalories;
            }
            set
            {
                TCalories = value;
            }
        }
    }
}
