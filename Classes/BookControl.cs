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

        public bool deleteBook(int ID)
        {

            Book b = new Book();

            if (b.deleteBook(ID))
            {
                success = true;
                Message = "Book Deleted Successfully.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

        }

        public bool editBook(int ID,string isbn, string author, string title, string genre)
        {

            Book b = new Book();

            if (b.editBook(ID,title, author, isbn, genre))
            {
                success = true;
                Message = "Book Edited Successfully.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

        }

        public bool addNewBook(string isbn, string author, string title, string genre)
        {
            
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

        public List<Book> searchBook(string title, string author, string isbn)
        {
            Book book = new Book();
            return book.searchBook(title, author, isbn);

        }
    }
}
