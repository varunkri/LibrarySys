using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.Classes
{
    public partial class CustomerControl
    {
        public string Message;
        private bool success = false;

        public CustomerControl()
        {
           

        }
        public DataTable getBooksBorrowedByCustomer(int custID)
        {
            Database mydb = Database.Instance;
            return mydb.getBooksBorrowedForCustomer(custID);
        }

        public  bool checkCustomerPassword(string email, string password)
        {
            Database mydb = Database.Instance;
            int ID = mydb.checkCustomerPassword(email, password);
            if (ID == 0)
            {
                Message = "The information you have entered does not match our records or your account has been blacklisted.";
                return false;
            }

            LoginInfo.LoggedInId = ID;
            LoginInfo.CustomerLoggedIn = true;
            return true;
        }


        public bool addNewCustomer(string name, string idNumber, string phone, string email, string password)
        {
            Database mydb = Database.Instance;
            if (mydb.doesCustomerExist(idNumber))
            {
                Message = "This ID Number is already in use. Please check with librarian to have password reset.";
                return false;
            }
            Customer c = new Customer();
            if (c.addCustomer( name,
                idNumber,
                phone,
                email,
                password))
            {
                success = true;
                Message = "Customer Added Successfully.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;
        }
    }
}
