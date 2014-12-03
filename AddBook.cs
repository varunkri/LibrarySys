using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.Classes
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            BookControl bc = new BookControl();
            bc.addNewBook(isbnText.Text, authorText.Text, titleText.Text, genreText.Text);
            MessageBox.Show(bc.Message);
        }
    }
}
