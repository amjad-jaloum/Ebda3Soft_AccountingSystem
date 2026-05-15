using System;
using System.Data;
using System.Windows.Forms;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem
{
    public partial class frmListItems : Form
    {
        private static DataTable _dtAllItems;

        public frmListItems()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshItemsList()
        {
            _dtAllItems = clsItem.GetAllItems();
            dgvItems.DataSource = _dtAllItems;
            lblRowsCountValue.Text = dgvItems.Rows.Count.ToString();

            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Columns[0].HeaderText = "Item ID";
                dgvItems.Columns[0].Width = 110;

                dgvItems.Columns[1].HeaderText = "Item Name";
                dgvItems.Columns[1].Width = 350;

                dgvItems.Columns[2].HeaderText = "Unit Name";
                dgvItems.Columns[2].Width = 150;

                dgvItems.Columns[3].HeaderText = "Default Unit Price";
                dgvItems.Columns[3].Width = 150;
            }
        }

        private void frmListItems_Load(object sender, EventArgs e)
        {
            _RefreshItemsList();

            cbFilter.SelectedIndex = 0; // Default to "None"
            txtSearch.Focus();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _dtAllItems.DefaultView.RowFilter = "";
                lblRowsCountValue.Text = dgvItems.Rows.Count.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // Map UI filter selection to DataTable column names
            switch (cbFilter.Text)
            {
                case "Item ID":
                    FilterColumn = "ItemID";
                    break;
                case "Item Name":
                    FilterColumn = "Name";
                    break;
                case "Unit Name":
                    FilterColumn = "UnitName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllItems.DefaultView.RowFilter = "";
                lblRowsCountValue.Text = dgvItems.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "ItemID")
            {
                // Numerical filter for ID
                _dtAllItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
            }
            else
            {
                // String filter using LIKE for Names
                _dtAllItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());
            }

            lblRowsCountValue.Text = dgvItems.Rows.Count.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateItem frm = new frmAddUpdateItem();
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemID = (int)dgvItems.CurrentRow.Cells[0].Value;
            frmAddUpdateItem frm = new frmAddUpdateItem(ItemID);
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delelte this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int ItemID = (int)dgvItems.CurrentRow.Cells["ItemID"].Value;
                clsItem.DeleteItem(ItemID);
                _RefreshItemsList();
            }
        }

        private void showItemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementation for a Read-Only Info form if required
        }
    }
}