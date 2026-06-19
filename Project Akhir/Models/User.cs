using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Akhir.Models
{
        // ABSTRACT CLASS
        public abstract class User
        {
            // ENCAPSULATION
            private string username;
            private string password;

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public abstract string GetRole();
        }

        // INHERITANCE
        public class Admin : User
        {
            public override string GetRole()
            {
                return "Admin";
            }
        }

        // INHERITANCE
        public class DonaturLogin : User
        {
            public override string GetRole()
            {
                return "Donatur";
            }
        }
        
}
