using LibraryApp.Classes;
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
    public partial class Blacklist : Form
    {
        public Blacklist()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryAppDataSet);

        }

        private void Blacklist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAppDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.libraryAppDataSet.customer);
        }

        private void blacklistTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.blacklistTable.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Customer cus = new Customer();
            cus.blackListCustomer(int.Parse(ID));
            this.customerTableAdapter.Fill(this.libraryAppDataSet.customer);
        }
    }
}
