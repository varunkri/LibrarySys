using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;


namespace LibraryApp.Classes
{    //a singleton static class

    class  Database
    {
       private static Database instance;

       private Database() { }

       public static Database Instance
       {
           get
           {
               if (instance == null)
               {
                   instance = new Database();
               }
               return instance;
           }
       }
       public bool renewBook(int bookid, Customer borrower, DateTime newDueDate)
       {
           SqlCeCommand sqlSt = new SqlCeCommand();
           sqlSt.CommandText = "update bookborrow set timesRenewed=timesRenewed+1, DueDate='" + newDueDate + "'" +
                               "  where returned=0 and  bookID=" + bookid + " and CustomerID=" + borrower.Id;




           return runCommand(sqlSt);
       }
       public bool returnBook(int bookid, Customer borrower, float penaltyImposed)
       {
           SqlCeCommand sqlSt = new SqlCeCommand();
           sqlSt.CommandText = "update bookborrow set returned=1, DateReturned='" + DateTime.Now.Date + "'" +
                               " ,penaltyImposed=" + penaltyImposed + " where returned=0 and   bookID=" + bookid + " and CustomerID=" + borrower.Id;




           return runCommand(sqlSt);
       }

       public DataTable getBooksBorrowedForCustomer(int custID)
       {
           SqlCeCommand sqlSt = new SqlCeCommand();
           sqlSt.CommandText = "select * from bookborrow inner join book on bookborrow.bookid = book.id "
                               + " where customerID=" + custID + " and returned=0";




           return readTable(sqlSt);
       }

        public  bool borrowBook(int bookID, int custID)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText =
                "INSERT INTO [BookBorrow] " +
                "([BookID] " +
                ",[CustomerID] " +
                ",[DateBorrowed]" +
                ",[dueDate]) " +
                "VALUES (@BookID,@CustomerID,@DateBorrowed, @dueDate)";

            sqlSt.Parameters.Add(new SqlCeParameter("BookID", bookID));
            sqlSt.Parameters.Add(new SqlCeParameter("CustomerID", custID));
            sqlSt.Parameters.Add(new SqlCeParameter("DateBorrowed", DateTime.Now));
            sqlSt.Parameters.Add(new SqlCeParameter("dueDate", DateTime.Now.AddDays(7)));

          

            return runCommand(sqlSt);
        }

        public  int getBooksBorrowedCountByCustomer(int cusID)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select count(*) as count from BookBorrow where CustomerID='" + cusID + "' and returned=0";
            DataTable dt = readTable(sqlSt);
            int count = 0;
            if (dt.Rows.Count > 0)
                count = int.Parse(dt.Rows[0]["count"].ToString());
            return count;
        }
        public  int checkCustomerPassword(string email, string password)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select * from customer where email='" + email + "' and password='" + password + "' and blacklisted=0";
            DataTable dt = readTable(sqlSt);
            int ID = 0;
            if( dt.Rows.Count > 0)
             ID = int.Parse(dt.Rows[0]["ID"].ToString());
            return ID;
        }

        public int checkLibrarianPassword(string username, string password)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select * from librarian where username='" + username + "' and password='" + password + "'";
            DataTable dt = readTable(sqlSt);
            int ID = 0;
            if (dt.Rows.Count > 0)
                ID = int.Parse(dt.Rows[0]["ID"].ToString());
            return ID;
        }

       public bool doesCustomerExist(string Idnum)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select * from customer where idNumber='" + Idnum + "'";
            DataTable dt =  readTable(sqlSt);
            bool exists = dt.Rows.Count > 0;
            return exists;
        }

       public bool addCustomer(Customer c)
       {
           SqlCeCommand sqlSt = new SqlCeCommand();
           sqlSt.CommandText =
               "INSERT INTO [customer] " +
               "([name] " +
               ",[idNumber] " +
               ",[phone] " +
               ",[email] " +
               ",[password]) " +
               "VALUES (@name,@idNumber,@phone,@email,@password)";

           sqlSt.Parameters.Add(new SqlCeParameter("name", c.Name));
           sqlSt.Parameters.Add(new SqlCeParameter("idNumber", c.Idnum));
           sqlSt.Parameters.Add(new SqlCeParameter("phone", c.Phone));
           sqlSt.Parameters.Add(new SqlCeParameter("email", c.Email));
           sqlSt.Parameters.Add(new SqlCeParameter("password", c.Password));

           int ID = runCommandScalar(sqlSt);
           c.Id = ID;
           return true;
       }

       public bool blacklistCustomer(Customer c)
       {
           SqlCeCommand sqlSt = new SqlCeCommand();
           sqlSt.CommandText =
               "Update Customer set [blacklist] = @blacklist" + "WHERE ID= @ID";

           sqlSt.Parameters.Add(new SqlCeParameter("blacklisted", c.Blacklisted));
           bool success = runCommand(sqlSt);
           return success;
       }

        public  DataTable searchBook(string title, string author, string isbn)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select book.*, case when bookborrow.returned=0 then 0 else 1 end as available, bookborrow.dueDate " +
                                " from book left join bookborrow on book.id = bookborrow.bookid and bookborrow.returned=0 where " +
                                " ('" + title + "' = '' or title like '%" + title + "%') " +
                                " and ('" + author + "' = '' or author like '%" + author + "%') " +
                                " and ('" + isbn + "' = '' or isbn like '%" + isbn + "%') ";


          

            return readTable(sqlSt);
        }

        public bool deleteBook(Book b)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText =
                "delete from Book  " +
                " WHERE ID= @ID";
            sqlSt.Parameters.Add(new SqlCeParameter("ID", b.Id));
            bool success = runCommand(sqlSt);
            return success;
        }

        public bool editBook(Book b)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText =
                "Update Book  set [title] = @title,[author] = @author ,[isbn] = @isbn,[genre] = @genre " +
                " WHERE ID= @ID";
            sqlSt.Parameters.Add(new SqlCeParameter("title", b.Title));
            sqlSt.Parameters.Add(new SqlCeParameter("author", b.Author));
            sqlSt.Parameters.Add(new SqlCeParameter("isbn", b.Isbn));
            sqlSt.Parameters.Add(new SqlCeParameter("genre", b.Genre));
            sqlSt.Parameters.Add(new SqlCeParameter("ID", b.Id));

            bool success = runCommand(sqlSt);
            return success;
        }

        public  bool addBook(Book b)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText =
                "INSERT INTO Book ( [title],[author],[isbn],[genre]) " +
                "VALUES(@title,@author,@isbn,@genre)";
            sqlSt.Parameters.Add(new SqlCeParameter("title", b.Title));
            sqlSt.Parameters.Add(new SqlCeParameter("author", b.Author));
            sqlSt.Parameters.Add(new SqlCeParameter("isbn", b.Isbn));
            sqlSt.Parameters.Add(new SqlCeParameter("genre", b.Genre));
            int ID = runCommandScalar(sqlSt);
            b.Id = ID;
            return true;
        }

        public bool addLibrarian(Librarian l)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText =
                "INSERT INTO Librarian ( [username],[password]) " +
                "VALUES(@username,@password)";
            sqlSt.Parameters.Add(new SqlCeParameter("username", l.Username));
            sqlSt.Parameters.Add(new SqlCeParameter("password", l.Password));

            int ID = runCommandScalar(sqlSt);
            l.Id = ID;
            return true;
        }

        public bool runCommand(SqlCeCommand command)
        {
            SqlCeConnection conn = null;
            bool success = true;
            string connecString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                conn = new SqlCeConnection(connecString);
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                success = false;
                Console.WriteLine(e.ToString());
            }
            finally
            {

                conn.Close();
            }
            return success;
        }

        public int runCommandScalar(SqlCeCommand command)
        {
            SqlCeConnection conn = null;
            bool success = true;
            int newID = 0;
            string connecString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                conn = new SqlCeConnection(connecString);
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();

                command.CommandText = "SELECT @@IDENTITY";
                newID = Convert.ToInt32((decimal)command.ExecuteScalar());

            }
            catch (Exception e)
            {
                success = false;
                Console.WriteLine(e.ToString());
            }
            finally
            {

                conn.Close();
            }
            return newID;
        }


        public DataTable readTable(SqlCeCommand command)
        {
            DataTable dt = new DataTable(); ;
            SqlCeConnection conn = null;
            bool success = true;
            string connecString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                conn = new SqlCeConnection(connecString);
                conn.Open();
                command.Connection = conn;
                SqlCeDataAdapter da = new SqlCeDataAdapter(command);
                da.Fill(dt);

            }
            catch (Exception e)
            {
                success = false;
                Console.WriteLine(e.ToString());
            }
            finally
            {

                conn.Close();
            }

            return dt;

        }
    }
}
