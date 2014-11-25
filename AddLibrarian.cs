using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using LibraryApp.Classes;

namespace LibraryApp
{
    public partial class AddLibrarian : Form
    {
        public AddLibrarian()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LibrarianControl lc = new LibrarianControl();
            lc.addNewLibrarin(txtUsername.Text, txtPassword.Text);
            MessageBox.Show(lc.Message);
        }
    }
}
