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
            CustomerControl myc = new CustomerControl();
            bool authenticated = myc.checkCustomerPassword(cusEmail.Text, cusPassword.Text);
            if(!authenticated)
            {
                MessageBox.Show(myc.Message);
                return;
            }
            CustomerMenu myCustomerMenu = new CustomerMenu();
            myCustomerMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LibrarianControl myLib = new LibrarianControl();
            //bool authenticated = myLib.checkLibrarianPassword(libUsername.Text, libPassword.Text);
            //if (!authenticated)
            //{
            //    MessageBox.Show(myLib.Message);
            //    return;
            //}
            LibrarianMenu myLibrarianMenu = new LibrarianMenu();
            myLibrarianMenu.Show();
            this.Hide();
        }


    }
}
