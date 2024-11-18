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
        private bool _twoFactorAuthEnabled;

        // Public properties
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

        public bool TwoFactorAuthEnabled
        {
            get { return _twoFactorAuthEnabled; }
            set { _twoFactorAuthEnabled = value; }
        }

        // Method for User signup
        public void Signup()
        {
            Console.Write("Enter a username: ");
            Username = Console.ReadLine();

            Console.Write("Enter a password: ");
            Password = Console.ReadLine();

            Console.Write("Enable two-factor authentication? (yes/no): ");
            string twoFactorInput = Console.ReadLine().ToLower();

            TwoFactorAuthEnabled = twoFactorInput == "yes";

            Console.WriteLine("User signed up successfully.");
        }

        // Method for User login
        public void Login()
        {
            Console.Write("Enter your username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Enter your password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == Username && inputPassword == Password)
            {
                Console.WriteLine("User logged in successfully.");
                if (TwoFactorAuthEnabled)
                {
                    Console.WriteLine("Two-factor authentication is enabled.");
                    // Here, you could add additional steps for two-factor authentication.
                }
            }
            else
            {
                Console.WriteLine("Login failed. Incorrect username or password.");
            }
        }

        // Method for User logout
        public void Logout()
        {
            Console.WriteLine("User logged out.");
        }
    }
}