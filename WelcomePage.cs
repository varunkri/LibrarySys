using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {

        }

        private void LibrarianBtn_Click(object sender, EventArgs e)
        {
            LibrarianMenu libMenu = new LibrarianMenu();
            libMenu.Show();
        }
    }
}
