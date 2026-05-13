using System;
using System.Data;
using System.Windows.Forms;
using Ebda3Soft_AccountingBusinessLayer;

namespace Ebda3Soft_AccountingSystem.AccountsDirectory
{
    public partial class frmListVouchers : Form
    {
        private DataTable _dtAllVouchers;

        public frmListVouchers()
        {
            InitializeComponent();
        }

        private void _RefreshVouchersList()
        {
            _dtAllVouchers = clsVoucher.GetAllVouchers();
            dgvVouchers.DataSource = _dtAllVouchers;
            lblRecordsCount.Text = dgvVouchers.Rows.Count.ToString();

            if (dgvVouchers.Rows.Count > 0)
            {
                // ضبط أسماء الأعمدة بالعربية وتنسيقها
                dgvVouchers.Columns["VoucherId"].HeaderText = "رقم السند";
                dgvVouchers.Columns["VoucherId"].Width = 110;

                dgvVouchers.Columns["AccountID"].HeaderText = "رقم الحساب";
                dgvVouchers.Columns["AccountID"].Width = 110;

                dgvVouchers.Columns["Name"].HeaderText = "اسم الحساب";
                dgvVouchers.Columns["Name"].Width = 200;

                dgvVouchers.Columns["Amount"].HeaderText = "المبلغ";
                dgvVouchers.Columns["Amount"].Width = 120;

                dgvVouchers.Columns["TypeName"].HeaderText = "نوع السند";
                dgvVouchers.Columns["TypeName"].Width = 100;

                // hide type - used only for filtering, not for display
                dgvVouchers.Columns["Type"].Visible = false;

                dgvVouchers.Columns["CreatedDate"].HeaderText = "التاريخ";
                dgvVouchers.Columns["CreatedDate"].Width = 150;
            }
        }

        private void frmListVouchers_Load(object sender, EventArgs e)
        {
            _RefreshVouchersList();
            cbFilterBy.SelectedIndex = 0; // الافتراضي: لا شيء
            cbVoucherType.SelectedIndex = 0; // إعادة تعيين نوع السند إلى "الكل"
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            frmAddUpdateVoucher frm = new frmAddUpdateVoucher();
            frm.ShowDialog();
            _RefreshVouchersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VoucherID = (int)dgvVouchers.CurrentRow.Cells[0].Value;
            frmAddUpdateVoucher frm = new frmAddUpdateVoucher(VoucherID);
            frm.ShowDialog();
            _RefreshVouchersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف هذا السند؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int VoucherID = (int)dgvVouchers.CurrentRow.Cells[0].Value;

                if (clsVoucher.DeleteVoucher(VoucherID))
                {
                    MessageBox.Show("تم حذف السند بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshVouchersList();
                }
                else
                    MessageBox.Show("فشل حذف السند", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط إذا كان الفلتر هو رقم السند
            if (cbFilterBy.Text == "رقم السند")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyCombinedFilter();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyCombinedFilter();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // إظهار أو إخفاء حقل النص بناءً على خيار الفلترة
            txtFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _ApplyCombinedFilter();
        }

        private void _ApplyCombinedFilter()
        {
            string FilterClause = "";

            // 1. منطق فلترة النوع (Type)
            // بفرض أن Index 0 = الكل، 1 = قبض، 2 = صرف
            if (cbVoucherType.SelectedIndex > 0)
            {
                FilterClause = string.Format("Type = {0}", cbVoucherType.SelectedIndex);
            }

            // 2. منطق فلترة نص البحث (Search Value)
            string SearchValue = txtFilterValue.Text.Trim();
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "رقم السند":
                    FilterColumn = "VoucherId";
                    break;
                case "اسم الحساب":
                    FilterColumn = "Name";
                    break;
            }

            if (!string.IsNullOrEmpty(SearchValue) && FilterColumn != "")
            {
                // إذا كان هناك فلتر نوع مسبقاً، نضيف AND
                if (FilterClause != "")
                    FilterClause += " AND ";

                if (FilterColumn == "VoucherId")
                    FilterClause += string.Format("[{0}] = {1}", FilterColumn, SearchValue);
                else
                    FilterClause += string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
            }

            // تطبيق الفلتر النهائي
            _dtAllVouchers.DefaultView.RowFilter = FilterClause;

            // تحديث عدد السجلات
            lblRecordsCount.Text = dgvVouchers.Rows.Count.ToString();
        }
    }
}

