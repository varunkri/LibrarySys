using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp.Classes
{
    static  class LoginInfo
    {
        private static int loggedInID;
        private static bool customerLoggedIn;
        private static bool librarianLoggedIn;


       

        public static int LoggedInId
        {
            get { return loggedInID; }
            set { loggedInID = value; }
        }

        public static bool CustomerLoggedIn
        {
            get { return customerLoggedIn; }
            set { customerLoggedIn = value; }
        }

        public static bool LibrarianLoggedIn
        {
            get { return librarianLoggedIn; }
            set { librarianLoggedIn = value; }
        }
    }
}
