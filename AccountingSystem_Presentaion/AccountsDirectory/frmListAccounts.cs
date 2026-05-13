using System;
using System.Data;
using System.Windows.Forms;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.BasicData
{
    public partial class frmListAccounts : Form
    {
        private static DataTable _dtAllAccounts;

        public frmListAccounts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListAccounts_Load(object sender, EventArgs e)
        {
            _dtAllAccounts = clsAccount.GetAllAccounts();
            dgvAccounts.DataSource = _dtAllAccounts;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvAccounts.Rows.Count.ToString();

            if (dgvAccounts.Rows.Count > 0)
            {
                // Aligning headers with the Accounts table schema
                dgvAccounts.Columns[0].HeaderText = "Account ID";
                dgvAccounts.Columns[0].Width = 110;

                dgvAccounts.Columns[1].HeaderText = "Account Name";
                dgvAccounts.Columns[1].Width = 200;

                dgvAccounts.Columns[2].HeaderText = "Person Name";
                dgvAccounts.Columns[2].Width = 300;

                dgvAccounts.Columns[3].HeaderText = "Account Type";
                dgvAccounts.Columns[3].Width = 120;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
            {
                txtFilterValue.Enabled = true;
            }

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // Map Selected Filter to real Business Layer Column names
            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    FilterColumn = "AccountID";
                    break;
                case "Account Name":
                    FilterColumn = "Name";
                    break;
                case "Person Name":
                    FilterColumn = "FullName"; // From the Joined view in Data Access
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset the filters if nothing selected or text is empty
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllAccounts.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAccounts.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "AccountID")
                // Numeric filter
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                // String filter
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllAccounts.DefaultView.Count.ToString();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frmAddUpdateAccount Frm1 = new frmAddUpdateAccount();
            Frm1.ShowDialog();
            frmListAccounts_Load(null, null); // Refresh data
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountID = (int)dgvAccounts.CurrentRow.Cells[0].Value;
            frmAddUpdateAccount Frm1 = new frmAddUpdateAccount(AccountID);
            Frm1.ShowDialog();
            frmListAccounts_Load(null, null); // Refresh data
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int AccountID = (int)dgvAccounts.CurrentRow.Cells[0].Value;

            if (clsAccount.DeleteAccount(AccountID))
            {
                MessageBox.Show("Account has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListAccounts_Load(null, null);
            }
            else
            {
                MessageBox.Show("Account cannot be deleted because it has linked data in the system.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers if Account ID is selected
            if (cbFilterBy.Text == "Account ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementation for Account Info screen if you have one
            // int AccountID = (int)dgvAccounts.CurrentRow.Cells[0].Value;
            // frmAccountInfo Frm1 = new frmAccountInfo(AccountID);
            // Frm1.ShowDialog();
        }
    }
}