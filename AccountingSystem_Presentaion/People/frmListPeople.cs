using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingSystem_Business;

namespace Ebda3Soft_AccountingSystem.people
{
    public partial class frmListPeople : Form
    {
        private DataTable _dtPeople = clsPerson.GetAllPeople();

        private void _RefreshPeopleList()
        {
            _dtPeople = clsPerson.GetAllPeople();

            dgvPeople.DataSource = _dtPeople;
            lblRowsCountValue.Text = dgvPeople.RowCount.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            lblRowsCountValue.Text = dgvPeople.RowCount.ToString();

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "First Name";
                dgvPeople.Columns[1].Width = 120;

                dgvPeople.Columns[2].HeaderText = "Second Name";
                dgvPeople.Columns[2].Width = 140;

                dgvPeople.Columns[3].HeaderText = "Third Name";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns[4].HeaderText = "Last Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Gender";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gender Caption";
                dgvPeople.Columns[6].Width = 170;

                dgvPeople.Columns[7].HeaderText = "Phone";
                dgvPeople.Columns[7].Width = 120;

                dgvPeople.Columns[8].HeaderText = "Email";
                dgvPeople.Columns[8].Width = 200;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxbSearch.Enabled = cbFilter.Text != "None";
            if (mtxbSearch.Enabled)
            {
                mtxbSearch.Text = string.Empty;
                mtxbSearch.Focus();
            }
        }

        private void mtxbSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (mtxbSearch.Text.Trim() == string.Empty || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = string.Empty;
                lblRowsCountValue.Text = dgvPeople.RowCount.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, mtxbSearch.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, mtxbSearch.Text.Trim());
            }

            lblRowsCountValue.Text = dgvPeople.RowCount.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form showDetails = new frmShowPersonInfo(PersonID);
            showDetails.ShowDialog();
        }

        private void mtxbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
