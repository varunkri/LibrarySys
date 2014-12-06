using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    interface Icustomer
    {
        bool addCustomer(string name, string idNumber, string phone, string email, string password);
        bool editPassword(int ID, string existingPassword, string newPassword);
        void blackListCustomer(int ID);
        int getBooksBorrowedCount(int ID);
        float getPenalty(int ID);
    }
}
