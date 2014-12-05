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

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void newCustomerLabel_Click(object sender, EventArgs e)
        {
            CustomerReg customerReg = new CustomerReg();
            customerReg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
        }


    }
}
