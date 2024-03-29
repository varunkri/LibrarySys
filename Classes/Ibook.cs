using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    interface Ibook
    {
        bool addBook(string title, string author, string isbn, string genre);
        bool editBook(int ID, string title, string author, string isbn, string genre);
        bool deleteBook(int ID);
        List<Book> searchBook(string title, string author, string isbn);
        bool borrowBook(int ID, Customer borrower);
        bool returnBook(int ID, Customer borrower,float penaltyImposed);
        bool renewBook(int ID, Customer borrower, DateTime newDueDate);
    }
}
