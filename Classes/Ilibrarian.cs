using System;
using System.Collections.Generic;

using System.Text;


namespace LibraryApp.Classes
{
    interface Ilibrarian
    {
         bool addLibrarian(string userName, string password);
         bool deleteLibrarian(int ID);
         bool editPassword(int ID, string existingPassword, string newPassword);

    }
}
