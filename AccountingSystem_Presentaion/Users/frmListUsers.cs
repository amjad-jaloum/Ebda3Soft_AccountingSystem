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

namespace Ebda3Soft_AccountingSystem.Users
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "الرقم التعريفي للمستخدم";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "الرقم التعريفي للشخص";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "الاسم الكامل";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "اسم المستخدم";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "هل هو نشط؟";
                dgvUsers.Columns[4].Width = 120;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "هل هو نشط؟")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "لا شيء");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "لا شيء")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "الرقم التعريفي للمستخدم":
                    FilterColumn = "UserID";
                    break;
                case "اسم المستخدم":
                    FilterColumn = "UserName";
                    break;

                case "الرقم التعريفي للشخص":
                    FilterColumn = "PersonID";
                    break;

                case "الاسم الكامل":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "الكل":
                    FilterValue = "All";
                    break;
                case "نعم":
                    FilterValue = "1";
                    break;
                case "لا":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser();
            Frm1.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmChangePassword Frm1 = new frmChangePassword(UserID);
            Frm1.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "الرقم التعريفي للشخص" || cbFilterBy.Text == "الرقم التعريفي للمستخدم")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if the user want to delete or not.
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا المستخدم؟", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("تم حذف المستخدم بنجاح.", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListUsers_Load(null, null);
            }
            else
                MessageBox.Show("فشل حذف المستخدم لوجود بيانات مرتبطة به.", "فشل العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
