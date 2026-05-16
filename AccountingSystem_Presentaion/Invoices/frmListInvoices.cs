using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using AccountingSystem_Business;

namespace Ebda3Soft_AccountingSystem.Invoices
{
    public partial class frmListInvoices : Form
    {
        // استخدام DataView للفلترة السريعة في الذاكرة
        private DataView _dvInvoices;

        public frmListInvoices()
        {
            InitializeComponent();
        }

        private void _RefreshInvoicesList()
        {
            DataTable dtInvoices = clsInvoice.GetAllInvoices();
            _dvInvoices = dtInvoices.DefaultView;

            dgvInvoices.DataSource = _dvInvoices;
            lblRowsCountValue.Text = _dvInvoices.Count.ToString();

            if (dgvInvoices.Rows.Count > 0)
            {
                // Translating headers to Arabic while keeping database original column names for data mapping
                dgvInvoices.Columns["InvoiceId"].HeaderText = "رقم الفاتورة";
                dgvInvoices.Columns["Name"].HeaderText = "اسم الحساب";
                dgvInvoices.Columns["TypeName"].HeaderText = "نوع الفاتورة";
                dgvInvoices.Columns["PaymentMethodName"].HeaderText = "طريقة الدفع";
                dgvInvoices.Columns["TotalAmount"].HeaderText = "إجمالي المبلغ";
                dgvInvoices.Columns["CreatedDate"].HeaderText = "التاريخ";

                // Hide underlying numeric ID columns that don't need to be displayed
                if (dgvInvoices.Columns.Contains("Type")) dgvInvoices.Columns["Type"].Visible = false;
                if (dgvInvoices.Columns.Contains("PaymentMethod")) dgvInvoices.Columns["PaymentMethod"].Visible = false;

                dgvInvoices.Columns["TotalAmount"].DefaultCellStyle.Format = "N2"; // for decimal formatting
                dgvInvoices.Columns["CreatedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

        private string _GetSearchFilterExpression()
        {
            if (cbFilter.Text == "لا شيء" || cbFilter.Text == "None" || string.IsNullOrEmpty(txtSearch.Text.Trim()))
                return "";

            // Mapping the localized ComboBox text to backend data filter queries
            switch (cbFilter.Text)
            {
                case "رقم الفاتورة":
                case "Invoice ID":
                    return string.Format("[InvoiceId] = {0}", txtSearch.Text.Trim());

                case "اسم الحساب":
                case "Account Name":
                    return string.Format("[Name] LIKE '{0}%'", txtSearch.Text.Trim());

                default:
                    return "";
            }
        }

        private string _GetTypeFilterExpression()
        {
            if (cbInvoiceType.Enabled && cbInvoiceType.Text != "الكل")
            {
                return string.Format("[TypeName] = '{0}'", cbInvoiceType.Text);
            }
            return "";
        }

        private string _GetPaymentMethodFilterExpression()
        {
            if (cbPaymentMethod.Enabled && cbPaymentMethod.Text != "الكل")
            {
                return string.Format("[PaymentMethodName] = '{0}'", cbPaymentMethod.Text);
            }
            return "";
        }
        private void _ApplyFilter()
        {
            if (_dvInvoices == null) return;

            // List to hold valid active filters
            List<string> filterParts = new List<string>();

            string searchFilter = _GetSearchFilterExpression();
            string typeFilter = _GetTypeFilterExpression();
            string paymentFilter = _GetPaymentMethodFilterExpression();

            if (!string.IsNullOrEmpty(searchFilter))
                filterParts.Add(searchFilter);

            if (!string.IsNullOrEmpty(typeFilter))
                filterParts.Add(typeFilter);

            if (!string.IsNullOrEmpty(paymentFilter))
                filterParts.Add(paymentFilter);

            // Combine all filters using AND operator
            // If the list is empty, finalFilter will be empty string (Shows all records)
            string finalFilter = string.Join(" AND ", filterParts);

            _dvInvoices.RowFilter = finalFilter;

            lblRowsCountValue.Text = _dvInvoices.Count.ToString();
        }

        private void frmListInvoices_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // "None" or "لا شيء"
            cbInvoiceType.SelectedIndex = 0; // "All"
            cbPaymentMethod.SelectedIndex = 0; // "All"

            _RefreshInvoicesList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle visibility based on selected filter type
            bool isSearchVisible = (cbFilter.Text != "None" && cbFilter.Text != "لا شيء");
            txtSearch.Enabled = isSearchVisible;

            if (isSearchVisible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void cbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            // Open screen to add a new invoice
            frmAddUpdateInvoice frm = new frmAddUpdateInvoice();
            frm.ShowDialog();
            _RefreshInvoicesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get invoice ID using safe column name mapping to avoid index breaking
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells["InvoiceId"].Value;

            if (MessageBox.Show($"هل أنت متأكد من رغبتك في حذف الفاتورة رقم [{invoiceID}]؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsInvoice.DeleteInvoice(invoiceID))
                {
                    // Invoice deleted successfully
                    MessageBox.Show("تم حذف الفاتورة بنجاح.");
                    _RefreshInvoicesList();
                }
                else
                {
                    // Failed to delete invoice
                    MessageBox.Show("خطأ: تعذر حذف الفاتورة.");
                }
            }
        }

        private void showInvoiceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells["InvoiceId"].Value;
            frmShowInvoiceInfo frm = new frmShowInvoiceInfo(invoiceID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use precise string mapping instead of hardcoded 0 index for higher reference safety
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells["InvoiceId"].Value;
            frmAddUpdateInvoice frm = new frmAddUpdateInvoice(invoiceID);
            frm.ShowDialog();
            _RefreshInvoicesList();
        }
    }
}