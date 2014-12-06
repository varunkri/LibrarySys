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
    public partial class CustBooksBorrowed : Form
    {
        private static readonly int penaltyPerDay = 2;
        private static readonly int dueDateExtendDays = 7;
        private static readonly int maxRenewTimes = 1;

        public CustBooksBorrowed()
        {
            InitializeComponent();
        }

        private void CustBooksBorrowed_Load(object sender, EventArgs e)
        {
            styleDataGrid();
            loadData();
        }

        private  void loadData()
        {
              CustomerControl myc = new CustomerControl();
            bookList.DataSource = myc.getBooksBorrowedByCustomer(LoginInfo.LoggedInId);
            
        }

        private void styleDataGrid()
        {
            bookList.AutoGenerateColumns = false;

            bookList.RowsDefaultCellStyle.BackColor = Color.Bisque;
            bookList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            bookList.CellBorderStyle = DataGridViewCellBorderStyle.None;

            bookList.DefaultCellStyle.SelectionBackColor = Color.Red;
            bookList.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            bookList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            bookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookList.AllowUserToResizeColumns = false;
        }

        private void bookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewButtonColumn bc = (DataGridViewButtonColumn) senderGrid.Columns[e.ColumnIndex];
                string id = bookList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string timesRenewed = bookList.Rows[e.RowIndex].Cells["RenewedTimes"].Value.ToString();
                DateTime dueDate = DateTime.Parse(bookList.Rows[e.RowIndex].Cells["DueDate"].Value.ToString());
                TimeSpan ts = DateTime.Now.Date - dueDate;

                if (bc.Text.ToLower() == "renew")
                    renewBook(id, ts, dueDate, timesRenewed);
                else
                {
                    returnBook(id,ts);
                }
            }
        }

        private void renewBook(string id, TimeSpan ts, DateTime dueDate, string timesRenewed)
        {
            if(ts.Days > 0)
            {
                MessageBox.Show("Sorry you cannot renew the book when its due date has already passed.");
                return;
            }
            if(int.Parse(timesRenewed) >= maxRenewTimes)
            {
                MessageBox.Show("Sorry you can only renew a maximum of " + maxRenewTimes + " time(s).");
                return;
            }
            BookControl bc = new BookControl();
            bc.renewBook(int.Parse(id), LoginInfo.LoggedInId, dueDate.AddDays(dueDateExtendDays));
            MessageBox.Show(bc.Message);
            loadData();
        }

        private void returnBook(string id, TimeSpan ts)
        {
            float penalty = 0;
            string penaltyMsg = "";
            if (ts.Days > 0)
                penalty = penaltyPerDay*ts.Days;
            if (penalty > 0)
                penaltyMsg = "You have been imposed a penality of $" + penalty + ". ";
            BookControl bc = new BookControl();
            bc.returnBook(int.Parse(id), LoginInfo.LoggedInId, penalty);
            MessageBox.Show(bc.Message + " " + penaltyMsg);
            loadData();
        }

    }
}
