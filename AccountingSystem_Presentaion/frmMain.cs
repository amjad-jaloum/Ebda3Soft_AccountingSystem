using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using _19___Project___DVLD;
using Ebda3Soft_AccountingSystem.AccountsDirectory;
using Ebda3Soft_AccountingSystem.BasicData;
using Ebda3Soft_AccountingSystem.Invoices;
using Ebda3Soft_AccountingSystem.people;
using Ebda3Soft_AccountingSystem.Reports;
using Ebda3Soft_AccountingSystem.Users;

namespace Ebda3Soft_AccountingSystem
{

    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void AccountsDirectorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAccounts frm = new frmListAccounts();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToShortDateString();
            tssUsername.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ItemsDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListItems frm = new frmListItems();
            frm.ShowDialog();
        }

        private void VouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListVouchers frm = new frmListVouchers();
            frm.ShowDialog();
        }

        private void InvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInvoices frm = new frmListInvoices();
            frm.ShowDialog();
        }

        private void AccountStatusReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountStateReport frm = new frmAccountStateReport();
            frm.ShowDialog();
        }

        private void ItemsInventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            frm.ShowDialog();
        }

        private void showCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm  = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
    }
}
