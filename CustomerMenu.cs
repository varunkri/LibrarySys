using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage myp = new WelcomePage();
            
            myp.Show();
        }

        private void addLibBtn_Click(object sender, EventArgs e)
        {
            CustBooksBorrowed cb = new CustBooksBorrowed();
            cb.Show();
        }
    }
}
