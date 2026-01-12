using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracking_Software
{
    class clsUser
    {
        private string UName, FName, LName, UPassword, Email, DOB, UGender, Phone, UAddress;
        private int W, H;

        public string UserName
        {
            get
            {
                return UName;
            }
            set
            {
                UName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public string Password
        {
            get
            {
                return UPassword;
            }
            set
            {
                UPassword = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string DateofBirth
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }
        public string Gender
        {
            get
            {
                return UGender;
            }
            set
            {
                UGender = value;
            }
        }
        public string Phone_Number
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string Address
        {
            get
            {
                return UAddress;
            }
            set
            {
                UAddress = value;
            }
        }
        public int Weight
        {
            get
            {
                return W;
            }
            set
            {
                W = value;
            }
        }
        public int Height
        {
            get
            {
                return H;
            }
            set
            {
                H = value;
            }
        }
    }
}
