using System;
using System.Collections.Generic;


namespace LibraryApp.Classes
{
    class Librarian: Ilibrarian
    {
        private string username;
        private string password;
        private int ID;

        public Librarian()
        {
        }


        public  Librarian(int id)
        {
            this.ID = id;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        #region Ilibrarian Members

        public bool addLibrarian(string userName, string password)
        {
            Database db = Database.Instance;
            this.username = userName;
            this.password = password;
            return db.addLibrarian(this);
        }

        public bool deleteLibrarian(int ID)
        {
            throw new NotImplementedException();
        }

        public bool editPassword(int ID, string existingPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
