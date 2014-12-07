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
        private string email;
        private int ID;
        private bool blacklisted;

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

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Blacklisted
        {
            get { return blacklisted; }
            set { blacklisted = value; }
        }

        #region Icustomer Members

        public bool addCustomer(string name, string idNumber, string phone, string email, string password)
        {
            Database db = Database.Instance;
            this.password = password;
            this.name = name;
            this.idnum = idNumber;
            this.phone = phone;
            this.email = email;
            return db.addCustomer(this);
           
        }
        public bool editPassword(int ID, string existingPassword, string newPassword)
        {
            Database db=Database.Instance;
            this.password=existingPassword;
            this.password=newPassword;
          //  return db.editPassword(this);
            throw new NotImplementedException();
        }
        public bool blackListCustomer(int ID)
        {
            Database db = Database.Instance;
            this.blacklisted = true;
            return db.blacklistCustomer(this);
        }
        public int getBooksBorrowedCount(int ID)
        {
            throw new NotImplementedException();
        }
        public float getPenalty(int ID)
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
