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


        public bool addNewCustomer(string username, string password)
        {
            Customer c = new Customer();
            if (c.addCustomer(username, password))
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