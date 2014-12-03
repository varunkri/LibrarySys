using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    internal class BookControl
    {
        public string Message;
        private bool success = false;

        public BookControl()
        {

        }

        public bool addNewBook(string isbn, string author, string title, string genre)
        {
            //check if librarian exists
            //
            //

            //if not
            Book b = new Book();

            if (b.addBook(title, author, isbn, genre))
            {
                success = true;
                Message = "Book Added Successfully.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

        }
    }
}
