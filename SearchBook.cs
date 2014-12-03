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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookControl bc = new BookControl();
            List<Book> list = new List<Book>();
            list = bc.searchBook(titleText.Text,authorText.Text,isbnText.Text);
            var bindingList = new BindingList<Book>(list);
            var source = new BindingSource(bindingList, null);
            bookList.DataSource = source;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
