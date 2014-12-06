using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryApp.Classes;

namespace LibraryApp
{
    public partial class CustomerReg : Form
    {
        public CustomerReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerControl cc = new CustomerControl();
            cc.addNewCustomer(name.Text, idNumber.Text, phone.Text, email.Text, password.Text);
            MessageBox.Show(cc.Message);
        }

        private void CustomerReg_Load(object sender, EventArgs e)
        {

        }
    }
}
