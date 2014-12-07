using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    class LibrarianControl
    {
        public string Message;
        private bool success = false;
        public  LibrarianControl()
        {
            
        }

        public bool checkLibrarianPassword(string username, string password)
        {
            Database mydb = Database.Instance;
            int ID = mydb.checkLibrarianPassword(username, password);
            if (ID == 0)
            {
                Message = "The login information you entered was incorrect.";
                return false;
            }

            LoginInfo.LoggedInId = ID;
            LoginInfo.LibrarianLoggedIn= true;
            return true;
        }

        public  bool addNewLibrarin(string username, string password)
        {
            //check if librarian exists
            //
            //

            //if not
            Librarian l = new Librarian();

            if(l.addLibrarian(username, password))
            {
                success = true;
                Message = "Librarian Added Successfully.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

        }
    }
}
