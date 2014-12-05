using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryApp.Classes
{
    class Book: Ibook
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
            return db.addBook(this);
          
        }


        public bool deleteBook(int ID)
        {
            Database db = Database.Instance;
            this.Id = ID;
            return db.deleteBook(this);
        }

       public bool editBook(int ID, string title, string author, string isbn, string genre)
        {
            Database db = Database.Instance;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.genre = genre;
            this.Id = ID;
            return db.editBook(this);
        }
        public List<Book> searchBook(string title, string author, string isbn)
        {
            Database db = Database.Instance;
            DataTable dt = db.searchBook(title, author, isbn);
            List<Book> bkList = new List<Book>();
            foreach (DataRow dr in dt.Rows)
            {
                Book b = new Book();
                b.title = dr["title"].ToString();
                b.author = dr["author"].ToString();
                b.isbn = dr["isbn"].ToString();
                b.genre = dr["genre"].ToString();
                b.Id = int.Parse(dr["id"].ToString());
                bkList.Add(b);

            }
            return bkList;
        }
        public bool borrowBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }
        public bool returnBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }
        public bool renewBook(int ID, Customer borrower)
        {
            throw new NotImplementedException();
        }

      
    }
}
