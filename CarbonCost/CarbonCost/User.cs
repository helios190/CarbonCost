using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    class User
    {
        // Private fields for the class
        private string _username;
        private string _password;
        private int _empID;
        private bool _twoFactorAuthEnabled;

        // Public properties

        public User(string loginName, string password)
        {
            Username = loginName;
            Password = password;
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int EmployeeID
        {
            get { return _empID; }
        }
        public bool TwoFactorAuthEnabled
        {
            get { return _twoFactorAuthEnabled; }
            set { _twoFactorAuthEnabled = value; }
        }

        // Method for User signup
        public void Signup()
        {

        }

        // Method for User login
        public bool Login()
        {
            if (Username == "Jono" & Password == "wkwk")
            {
                _empID = 1;
                return true;
            }
            else if (Username == "Jones" && Password == "haha")
            {
                _empID = 2;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method for User logout
        public void Logout()
        {
            Console.WriteLine("User logged out.");
        }
    }
}