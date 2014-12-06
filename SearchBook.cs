using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryApp.Classes;

namespace LibraryApp
{
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
            setVisibleElements();
            styleDataGrid();
            loadData();

        }

        private void setVisibleElements()
        {
            if (LoginInfo.CustomerLoggedIn)
            {
                tipsPanel.Visible = false;
                bookList.AllowUserToDeleteRows = false;
                bookList.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            BookControl bc = new BookControl();
            List<Book> list = new List<Book>();
            list = bc.searchBook(titleText.Text, authorText.Text, isbnText.Text);
            var bindingList = new BindingList<Book>(list);
            var source = new BindingSource(bindingList, null);
            bookList.DataSource = source;
         
        }

       



        private void bookList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void styleDataGrid()
        {
            bookList.AutoGenerateColumns = false;

            bookList.RowsDefaultCellStyle.BackColor = Color.Bisque;
            bookList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            bookList.CellBorderStyle = DataGridViewCellBorderStyle.None;

            bookList.DefaultCellStyle.SelectionBackColor = Color.Red;
            bookList.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            bookList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            bookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookList.AllowUserToResizeColumns = false;
        }

        private void bookList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string id = bookList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string title = bookList.Rows[e.RowIndex].Cells["title"].Value.ToString();
            string author = bookList.Rows[e.RowIndex].Cells["author"].Value.ToString();
            string isbn = bookList.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
            string genre = bookList.Rows[e.RowIndex].Cells["genre"].Value.ToString();

            if (e.RowIndex % 2 == 0)
                bookList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = bookList.RowsDefaultCellStyle;
            else
                bookList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = bookList.AlternatingRowsDefaultCellStyle;

            BookControl bc = new BookControl();
            bc.editBook(int.Parse(id), isbn, author, title, genre);
            MessageBox.Show(bc.Message);





        }

        private void bookList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.White;
            style.ForeColor = Color.Black;
            bookList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = style;
        }

        private void bookList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string id = bookList.Rows[e.Row.Index].Cells["ID"].Value.ToString();
            BookControl bc = new BookControl();
            bc.deleteBook(int.Parse(id));
            MessageBox.Show(bc.Message);

        }

        private void bookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string id = bookList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                bool available = bool.Parse(bookList.Rows[e.RowIndex].Cells["availablebool"].Value.ToString());
                if(!available)
                {
                    MessageBox.Show("Sorry. This book is not available");
                    return;
                }
                BookControl bc = new BookControl();
                bc.borrowBook(int.Parse(id), LoginInfo.LoggedInId);
                MessageBox.Show(bc.Message);
                loadData();
            }
        }






    }
}
