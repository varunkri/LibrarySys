﻿using LibraryApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LibrarianMenu : Form
    {
        public LibrarianMenu()
        {
            InitializeComponent();
        }

        private void addLibBtn_Click(object sender, EventArgs e)
        {
            AddLibrarian alform = new AddLibrarian();
            alform.Show();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            SearchBook sb = new SearchBook();
            sb.Show();
        }

        private void blBtn_Click(object sender, EventArgs e)
        {
            Blacklist myBl = new Blacklist();
            myBl.Show();
        }
    }
}
