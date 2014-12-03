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

        public  DataTable searchBook(string title, string author, string isbn)
        {
            SqlCeCommand sqlSt = new SqlCeCommand();
            sqlSt.CommandText = "select * from book where " +
                                " ('" + title + "' = '' or title like '%" + title + "%') " +
                                " and ('" + author + "' = '' or author like '%" + author + "%') " +
                                " and ('" + isbn + "' = '' or isbn like '%" + isbn + "%') ";


          

            return readTable(sqlSt);
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
