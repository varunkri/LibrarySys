using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryApp.Classes
{
    internal class BookControl
    {
        public string Message;
        private bool success = false;
        private static readonly int maxBorrowLimit = 5;

        public BookControl()
        {

        }
       

        public bool renewBook(int bookID, int custID, DateTime newDueDate)
        {
            Book b = new Book();
            Customer borrower = new Customer(custID);
            if (b.renewBook(bookID, borrower, newDueDate))
            {
                success = true;
                Message = "Your due date for this book book has been extended by a week.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

        }

        public bool returnBook(int bookID, int custID, float penaltyImposed)
        {
            Book b = new Book();
            Customer borrower = new Customer(custID);
            if (b.returnBook(bookID, borrower, penaltyImposed))
            {
                success = true;
                Message = "Thank you for returning the book.";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;
            
        }

        public bool borrowBook(int bookID, int custID)
        {
            Database mydb = Database.Instance;
            int borrowed = mydb.getBooksBorrowedCountByCustomer(custID);
            if(borrowed >= 5)
            {
                Message = "You have already borrowed 5 books. You may not borrow more at this moment. ";
                return false;
            }

            Customer borrower = new Customer(custID);
            Book myBook = new Book(bookID);

            if (myBook.borrowBook(bookID, borrower))
            {
                success = true;
                Message = "Than you for using the library. You may return this book within a week. You have a limit of " + (maxBorrowLimit - borrowed - 1).ToString() + " book(s) that you may borrow";
            }
            else
            {
                Message = "An error occurred.";
            }
            return success;

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
