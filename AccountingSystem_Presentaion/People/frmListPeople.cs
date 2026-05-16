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
                dgvPeople.Columns[0].HeaderText = "الرقم التعريفي";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "الاسم الأول";
                dgvPeople.Columns[1].Width = 120;

                dgvPeople.Columns[2].HeaderText = "الاسم الثاني";
                dgvPeople.Columns[2].Width = 140;

                dgvPeople.Columns[3].HeaderText = "الاسم الثالث";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns[4].HeaderText = "الاسم الأخير";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "الجنس";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "حالة الجنس";
                dgvPeople.Columns[6].Width = 170;

                dgvPeople.Columns[7].HeaderText = "الهاتف";
                dgvPeople.Columns[7].Width = 120;

                dgvPeople.Columns[8].HeaderText = "البريد الإلكتروني";
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
            mtxbSearch.Enabled = cbFilter.Text != "لا شيء";
            if (mtxbSearch.Enabled)
            {
                mtxbSearch.Text = string.Empty;
                mtxbSearch.Focus();
            }
        }

        private void mtxbSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // Matches the localized items in your ComboBox
            switch (cbFilter.Text)
            {
                case "الرقم التعريفي":
                    FilterColumn = "PersonID";
                    break;

                case "الاسم الأول":
                    FilterColumn = "FirstName";
                    break;

                case "الاسم الثاني":
                    FilterColumn = "SecondName";
                    break;

                case "الاسم الثالث":
                    FilterColumn = "ThirdName";
                    break;

                case "الاسم الأخير":
                    FilterColumn = "LastName";
                    break;

                case "الجنس":
                    FilterColumn = "GenderCaption";
                    break;

                case "الهاتف":
                    FilterColumn = "Phone";
                    break;

                case "البريد الإلكتروني":
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
            if (MessageBox.Show("هل أنت متأكد أنك تريد حذف الشخص الذي يحمل الرقم التعريفي [" + dgvPeople.CurrentRow.Cells[0].Value + "]؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الشخص بنجاح.", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("لم يتم حذف الشخص لوجود بيانات أخرى مرتبطة به.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cbFilter.Text == "الرقم التعريفي")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
