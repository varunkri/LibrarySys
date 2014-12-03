using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    class Customer: Icustomer
    {
        private string name;
        private string username;
        private string password;
        private string idnum;
        private string phone;
        private int ID;
        public Customer()
        {
        }
        
        public Customer(int id)
        {
            this.ID = id;
        }
        public string Idnum
        {
            get { return idnum; }
            set { idnum = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        #region Icustomer Members

        public bool addCustomer(string userName, string password)
        {
            Database db = Database.Instance;
            this.username = userName;
            this.password = password;
          //  return db.addCustomer(this);
            throw new NotImplementedException();
        }
        public bool editPassword(int ID, string existingPassword, string newPassword)
        {
            Database db=Database.Instance;
            this.password=existingPassword;
            this.password=newPassword;
          //  return db.editPassword(this);
            throw new NotImplementedException();
        }
        public void blackListCustomer(int ID)
        {
            throw new NotImplementedException();
        }
        public int getBooksBorrowedCount(int ID)
        {
            throw new NotImplementedException();
        }
        public float getPenalty(int ID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Icustomer Members

        bool Icustomer.addCustomer(string name, string idNumber, string phone, string userName, string password)
        {
            throw new NotImplementedException();
        }

        bool Icustomer.editPassword(int ID, string existingPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        void Icustomer.blackListCustomer(int ID)
        {
            throw new NotImplementedException();
        }

        int Icustomer.getBooksBorrowedCount(int ID)
        {
            throw new NotImplementedException();
        }

        float Icustomer.getPenalty(int ID)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
