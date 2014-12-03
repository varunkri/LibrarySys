using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Classes
{
    class Book
    {
        private string author;
        private string title;
        private string isbn;
        private string genre;
        private int ID;

        public Book()
        {

        }
        public  Book(string isbn,string author,string title,string genre,int Id)
        {
            this.ID=Id;   
            this.isbn = isbn;
            this.author= author ;
            this.title =title ;
            this.genre =genre ;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value;}
        }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }


        public bool addBook(string title, string author, string isbn, string genre)
        {
            Database db = Database.Instance;
            this.title =title ;
            this.author= author ;
            this.isbn = isbn;
            this.genre =genre ;
          //  return db.addBook(this);
            throw new NotImplementedException();
        }


        public bool deleteBook(string title, string author, string isbn, string genre)
        {
            throw new NotImplementedException();
        }

        public bool editBook(int ID, string existingPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
        List<Book> searchBook(string title, string author, string isbn)
        {
            throw new NotImplementedException();
        }
        bool borrowBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }
        bool returnBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }
        bool renewBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }

      
    }
}
